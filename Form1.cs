using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using System.Threading.Tasks;
using System.Threading;
using XMusicDownloader.Provider;
using XMusicDownloader.Domain;
using XMusicDownloader.Http;
using System.IO;
using System.Runtime.InteropServices;
using System.Configuration;
using NeteaseCloudMusicApi;
using System.Text.RegularExpressions;

namespace XMusicDownloader
{
    public partial class mainFrom : CCSkinMain
    {
        // 用于将ListView更新的的委托类型
        delegate void UpdateListCallback(List<ListViewItem> listViewItems);

        CloudMusicApi api = new CloudMusicApi();

        public mainFrom()
        {
            InitializeComponent();
        }


        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out string pszPath);

        string target = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\Download\\";
        static readonly string configFile = "config.conf";

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings[Settings.DOWNLOAD_PATH].Length>0)
            {
                // TODO
                target = ConfigurationManager.AppSettings[Settings.DOWNLOAD_PATH];
            }
            this.txtDownloadPath.Text = target;

            this.chbSaveAccount.Checked = ConfigurationManager.AppSettings["saveAccount"] == "true";
            if (this.chbSaveAccount.Checked)
            {
                this.txtUserName.Text = ConfigurationManager.AppSettings[Settings.USER_NAME];
                this.txtPassword.Text = ConfigurationManager.AppSettings[Settings.PASSWORD];
            }
        }

        //浏览
        private void pathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDownloadPath.Text = ofd.SelectedPath + "\\";
                target = txtDownloadPath.Text;
                saveConfig();
            }
        }

        int page = 1;

        //搜索
        private void searchBtn_Click(object sender, EventArgs e)
        {
            page = 1;
            GetList(page);
        }

     

        /// <summary>
        /// 开始显示进度栏动画
        /// </summary>
        private void StartProcessBar()
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar1.MarqueeAnimationSpeed = 10;
        }

        /// <summary>
        /// 结束显示进度栏动画
        /// </summary>
        private void StopProcessBar()
        {
            toolStripProgressBar1.Visible = false;
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
        }

        MusicProviders provider = MusicProviders.Instance;


        /// <summary>
        /// 获取歌曲列表
        /// </summary>
        /// <param name="page"></param>
        private void GetList(int page)
        {
            StartProcessBar();
            pageNum.Text = "第" + page + "页";
            resultListView.Items.Clear();
            toolStripStatusLabel1.Text = "搜索中...";
        }

        /// <summary>
        /// 用于在获取歌曲列表的Task中更新界面
        /// </summary>
        /// <param name="listViewItems"></param>
        private void UpdateUI(List<ListViewItem> listViewItems)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.resultListView.InvokeRequired)//如果调用控件的线程和创建创建控件的线程不是同一个则为True
            {
                while (!this.resultListView.IsHandleCreated)
                {
                    //解决窗体关闭时出现“访问已释放句柄“的异常
                    if (this.resultListView.Disposing || this.resultListView.IsDisposed)
                        return;
                }
                UpdateListCallback d = new UpdateListCallback(UpdateUI);
                resultListView.Invoke(d, new object[] { listViewItems });
            }
            else
            {
                resultListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
                resultListView.Items.AddRange(listViewItems.ToArray());
                resultListView.EndUpdate();  //结束数据处理，UI界面一次性绘制
                toolStripStatusLabel1.Text = "搜索完成";
                StopProcessBar();

               
            }
        }

        /// <summary>
        /// 计算MD5获得下载的key值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bf = Encoding.Default.GetBytes(str);
            byte[] mbf = md5.ComputeHash(bf);
            string s = "";
            for (int i = 0; i < mbf.Length; i++)
            {
                s += mbf[i].ToString("x2");
            }
            return s;
        }



        private string getSongUrl(Song song)
        {
            return provider.getDownloadUrl(song);
        }

        SongDownloader downloader;

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downBtn_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;

                if (!Directory.Exists(target))
                {
                    Directory.CreateDirectory(target);
                }

                if (downloader == null)
                {
                    downloader = new SongDownloader(provider, target);
                }

                foreach (ListViewItem item in resultListView.CheckedItems)
                {
                    timer1.Enabled = true;
                    timer1.Interval = 500;
                    var song = (MergedSong)item.Tag;
                    downloader.AddDownload(song);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前下载："+downloader.currentSongName+" 下载进度：" + (int)(downloader.totalPercent) + "%" + string.Format(" 下载速度：{0}", (downloader.totalSpeed / 1024.0 / 1024.0).ToString("F2") + "MB/s 排队数:" + downloader.queqeCount);
            toolStripProgressBar1.Value = (int)(downloader.totalPercent);
            if (downloader.totalPercent >= 100d)
            {
                toolStripStatusLabel1.Text = "下载完成！";
                timer1.Enabled = false;
                toolStripProgressBar1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetSongList_Click(object sender, EventArgs e)
        {
            GetList(1);
        }

        private void cbSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in resultListView.Items)
            {
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter){
                searchBtn_Click(this, e);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void chbSaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void saveConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["saveAccount"].Value = this.chbSaveAccount.Checked ? "true" : "false";
            if (this.chbSaveAccount.Checked)
            {
                config.AppSettings.Settings[Settings.USER_NAME].Value = this.txtUserName.Text;
                config.AppSettings.Settings[Settings.PASSWORD].Value = this.txtPassword.Text;
            }
            config.AppSettings.Settings[Settings.DOWNLOAD_PATH].Value = this.txtDownloadPath.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (chbSaveAccount.Checked)
            {
                saveConfig();
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (chbSaveAccount.Checked)
            {
                saveConfig();
            }

        }

        private void showLog(string message)
        {
            Invoke(new  EventHandler(delegate
            {
                toolStripStatusLabel1.Text = message;
            }));
        }

        private  void skinButton2_ClickAsync(object sender, EventArgs e)
        {
            Thread seach = new Thread(async () =>
            {
                await FetchSongList();

            });
            seach.Start();
        }

        private async Task FetchSongList()
        {
            Dictionary<string, string> queries;
            string account;
            bool isPhone;
            bool isOk;
            JObject json;

            queries = new Dictionary<string, string>();
            account = txtUserName.Text;
            isPhone = Regex.Match(account, "^[0-9]+$").Success;
            queries[isPhone ? "phone" : "email"] = account;
            queries[Settings.PASSWORD] = txtPassword.Text;

            showLog("登录中...");
            (isOk, json) = await api.RequestAsync(isPhone ? CloudMusicApiProviders.LoginCellphone : CloudMusicApiProviders.Login, queries);
            if (!isOk)
            {
                showLog("登录失败，账号或密码错误");
                return;
            }

            showLog("获取用户信息...");
            (isOk, json) = await api.RequestAsync(CloudMusicApiProviders.LoginStatus, CloudMusicApi.EmptyQueries);
            if (!isOk)
            {
                showLog($"获取账号信息失败： {json}");
                return;
            }
            int uid = (int)json["profile"]["userId"];


            showLog("获取用户歌单...");
            (isOk, json) = await api.RequestAsync(CloudMusicApiProviders.UserPlaylist, new Dictionary<string, string> { { "uid", uid.ToString() } });
            if (!isOk)
            {
                showLog("获取用户歌单失败");
                return;
            }

            (isOk, json) = await api.RequestAsync(CloudMusicApiProviders.PlaylistDetail, new Dictionary<string, string> { { "id", json["playlist"][0]["id"].ToString() } });
            if (!isOk)
            {
                showLog("获取歌单详情失败");
                return;
            }

            showLog("获取用歌单歌曲...");
            int[] trackIds = json["playlist"]["trackIds"].Select(t => (int)t["id"]).ToArray();
            (isOk, json) = await api.RequestAsync(CloudMusicApiProviders.SongDetail, new Dictionary<string, string> { { "ids", string.Join(",", trackIds) } });
            if (!isOk)
                showLog("获取歌曲详情失败");

            // 搜索候选歌曲
            showLog("获取无版权歌曲...");
            List<Song> noCopyrightsSongs = FetchNoCopyrightSongs(json);

            showLog("搜索候选歌曲...");
            List<MergedSong> mergedSongs = FetchCandidateSongs(noCopyrightsSongs);

            ShowSongList(mergedSongs);
        }

        private List<MergedSong> FetchCandidateSongs(List<Song> noCopyrightsSongs)
        {
            List<MergedSong> mergedSongs = new List<MergedSong>();

            noCopyrightsSongs.ForEach(item =>
            {
                showLog($"搜索{item.name} {item.singer} 候选");
                MergedSong song = MusicProviders.Instance.SearchSong(item.singer.Trim(), trimSongName(item.name), item.source);
                if (song != null)
                {
                    mergedSongs.Add(song);
                }
            });
            return mergedSongs;
        }

        private void ShowSongList(List<MergedSong> mergedSongs)
        {
            List<ListViewItem> listViewItems = new List<ListViewItem>();
            mergedSongs.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.name;
                lvi.SubItems.Add(item.singer);
                lvi.SubItems.Add(item.rate + "kb");
                lvi.SubItems.Add((item.size / (1024 * 1024)).ToString("F2") + "MB");  //将文件大小装换成MB的单位
                TimeSpan ts = new TimeSpan(0, 0, (int)item.duration); //把秒数换算成分钟数
                lvi.SubItems.Add(ts.Minutes + ":" + ts.Seconds.ToString("00"));
                lvi.SubItems.Add(item.source);
                lvi.Tag = item;
                lvi.Checked = true;
                listViewItems.Add(lvi);
            });
            UpdateUI(listViewItems);
        }

        private string trimSongName(string songname)
        {
            if(songname.IndexOf("(") > -1)
            {
                return songname.Substring(0, songname.IndexOf("(")).Trim();
            }
            return songname.Trim();
        }

        private static List<Song> FetchNoCopyrightSongs(JObject json)
        {
            List<Song> noCopyrightsSongs = new List<Song>();
            foreach (JObject songObj in json["songs"])
            {
                int id = 0;
               
                if (songObj["noCopyrightRcmd"].HasValues || songObj["fee"].Value<int>() == 1)
                {
                    noCopyrightsSongs.Add(NeteaseProvider.extractSong(ref id, songObj));
                }
            }

            return noCopyrightsSongs;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtDownloadPath.Text);
        }

        private void txtDownloadPath_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
