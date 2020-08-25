namespace XMusicDownloader
{
    partial class mainFrom
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrom));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDownloadPath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.downBtn = new CCWin.SkinControl.SkinButton();
            this.pathBtn = new CCWin.SkinControl.SkinButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.resultListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageNum = new System.Windows.Forms.Label();
            this.tblSearch = new System.Windows.Forms.TabControl();
            this.tabKeyword = new System.Windows.Forms.TabPage();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.chbSaveAccount = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.statusStrip1.SuspendLayout();
            this.tblSearch.SuspendLayout();
            this.tabKeyword.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(11, 543);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "下载到：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDownloadPath
            // 
            this.txtDownloadPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDownloadPath.Location = new System.Drawing.Point(67, 540);
            this.txtDownloadPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtDownloadPath.Name = "txtDownloadPath";
            this.txtDownloadPath.Size = new System.Drawing.Size(417, 26);
            this.txtDownloadPath.TabIndex = 4;
            this.txtDownloadPath.TextChanged += new System.EventHandler(this.txtDownloadPath_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // downBtn
            // 
            this.downBtn.BackColor = System.Drawing.Color.Transparent;
            this.downBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.downBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.downBtn.DownBack = null;
            this.downBtn.DownBaseColor = System.Drawing.Color.LightBlue;
            this.downBtn.Location = new System.Drawing.Point(599, 540);
            this.downBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.downBtn.MouseBack = null;
            this.downBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.downBtn.Name = "downBtn";
            this.downBtn.NormlBack = null;
            this.downBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.downBtn.Size = new System.Drawing.Size(111, 59);
            this.downBtn.TabIndex = 10;
            this.downBtn.Text = "开始下载";
            this.downBtn.UseVisualStyleBackColor = false;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // pathBtn
            // 
            this.pathBtn.BackColor = System.Drawing.Color.Transparent;
            this.pathBtn.BaseColor = System.Drawing.Color.LightBlue;
            this.pathBtn.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pathBtn.DownBack = null;
            this.pathBtn.DownBaseColor = System.Drawing.Color.LightBlue;
            this.pathBtn.Location = new System.Drawing.Point(490, 540);
            this.pathBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pathBtn.MouseBack = null;
            this.pathBtn.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.pathBtn.Name = "pathBtn";
            this.pathBtn.NormlBack = null;
            this.pathBtn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.pathBtn.Size = new System.Drawing.Size(70, 26);
            this.pathBtn.TabIndex = 11;
            this.pathBtn.Text = "浏览";
            this.pathBtn.UseVisualStyleBackColor = false;
            this.pathBtn.Click += new System.EventHandler(this.pathBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(4, 613);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "准备就绪";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(201, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // resultListView
            // 
            this.resultListView.CheckBoxes = true;
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.singer,
            this.bitRate,
            this.size,
            this.time,
            this.source});
            this.resultListView.FullRowSelect = true;
            this.resultListView.Location = new System.Drawing.Point(8, 91);
            this.resultListView.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(786, 441);
            this.resultListView.TabIndex = 14;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "歌名";
            this.name.Width = 200;
            // 
            // singer
            // 
            this.singer.Text = "歌手";
            this.singer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.singer.Width = 200;
            // 
            // bitRate
            // 
            this.bitRate.Text = "比特率";
            this.bitRate.Width = 80;
            // 
            // size
            // 
            this.size.Text = "大小";
            this.size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.size.Width = 65;
            // 
            // time
            // 
            this.time.Text = "时长";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 100;
            // 
            // source
            // 
            this.source.Text = "来源";
            this.source.Width = 150;
            // 
            // pageNum
            // 
            this.pageNum.AutoSize = true;
            this.pageNum.Location = new System.Drawing.Point(359, 541);
            this.pageNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(0, 17);
            this.pageNum.TabIndex = 17;
            // 
            // tblSearch
            // 
            this.tblSearch.Controls.Add(this.tabKeyword);
            this.tblSearch.Location = new System.Drawing.Point(7, 17);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.SelectedIndex = 0;
            this.tblSearch.Size = new System.Drawing.Size(783, 67);
            this.tblSearch.TabIndex = 18;
            // 
            // tabKeyword
            // 
            this.tabKeyword.Controls.Add(this.skinButton2);
            this.tabKeyword.Controls.Add(this.chbSaveAccount);
            this.tabKeyword.Controls.Add(this.txtPassword);
            this.tabKeyword.Controls.Add(this.label3);
            this.tabKeyword.Controls.Add(this.label2);
            this.tabKeyword.Controls.Add(this.txtUserName);
            this.tabKeyword.Location = new System.Drawing.Point(4, 26);
            this.tabKeyword.Name = "tabKeyword";
            this.tabKeyword.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeyword.Size = new System.Drawing.Size(775, 37);
            this.tabKeyword.TabIndex = 0;
            this.tabKeyword.Text = "我喜欢的歌曲";
            this.tabKeyword.UseVisualStyleBackColor = true;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.LightBlue;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton2.Location = new System.Drawing.Point(615, 5);
            this.skinButton2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(109, 26);
            this.skinButton2.TabIndex = 20;
            this.skinButton2.Text = "获取无版权歌曲";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_ClickAsync);
            // 
            // chbSaveAccount
            // 
            this.chbSaveAccount.AutoSize = true;
            this.chbSaveAccount.Checked = true;
            this.chbSaveAccount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSaveAccount.Location = new System.Drawing.Point(506, 7);
            this.chbSaveAccount.Name = "chbSaveAccount";
            this.chbSaveAccount.Size = new System.Drawing.Size(75, 21);
            this.chbSaveAccount.TabIndex = 4;
            this.chbSaveAccount.Text = "保存账户";
            this.chbSaveAccount.UseVisualStyleBackColor = true;
            this.chbSaveAccount.CheckedChanged += new System.EventHandler(this.chbSaveAccount_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(311, 7);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(175, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(56, 7);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.LightBlue;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton1.Location = new System.Drawing.Point(490, 574);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.LightBlue;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(70, 26);
            this.skinButton1.TabIndex = 19;
            this.skinButton1.Text = "打开目录";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // mainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionHeight = 20;
            this.ClientSize = new System.Drawing.Size(800, 639);
            this.CloseBoxSize = new System.Drawing.Size(40, 20);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.tblSearch);
            this.Controls.Add(this.pageNum);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pathBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.txtDownloadPath);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 639);
            this.MinimumSize = new System.Drawing.Size(800, 639);
            this.MiniSize = new System.Drawing.Size(40, 20);
            this.Name = "mainFrom";
            this.Radius = 10;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网易音乐 无版权歌曲补全";
            this.TitleCenter = true;
            this.TitleSuitColor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tblSearch.ResumeLayout(false);
            this.tabKeyword.ResumeLayout(false);
            this.tabKeyword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDownloadPath;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinButton downBtn;
        private CCWin.SkinControl.SkinButton pathBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader bitRate;
        private System.Windows.Forms.ColumnHeader singer;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.Label pageNum;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ColumnHeader source;
        private System.Windows.Forms.TabControl tblSearch;
        private System.Windows.Forms.TabPage tabKeyword;
        private System.Windows.Forms.CheckBox chbSaveAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
    }
}

