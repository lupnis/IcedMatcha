
namespace IMLoader
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Label();
            this.button_settings = new System.Windows.Forms.Label();
            this.button_showLyric = new System.Windows.Forms.Label();
            this.button_showCard = new System.Windows.Forms.Label();
            this.toolTip_tips = new System.Windows.Forms.ToolTip(this.components);
            this.label_apperance = new System.Windows.Forms.Label();
            this.panel_sideStrip = new System.Windows.Forms.Panel();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.label_nextSong = new System.Windows.Forms.Label();
            this.label_continue = new System.Windows.Forms.Label();
            this.label_pause = new System.Windows.Forms.Label();
            this.label_loop = new System.Windows.Forms.Label();
            this.panel_songList = new System.Windows.Forms.Panel();
            this.splitContainer_listBox = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_emptySongList = new System.Windows.Forms.Label();
            this.listBox_songList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_emptyFinishedList = new System.Windows.Forms.Label();
            this.listBox_songFinishedList = new System.Windows.Forms.ListBox();
            this.timer_refreshList = new System.Windows.Forms.Timer(this.components);
            this.timer_refreshData = new System.Windows.Forms.Timer(this.components);
            this.timer_refreshSong = new System.Windows.Forms.Timer(this.components);
            this.musicControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_sideStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            this.panel_songList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_listBox)).BeginInit();
            this.splitContainer_listBox.Panel1.SuspendLayout();
            this.splitContainer_listBox.Panel2.SuspendLayout();
            this.splitContainer_listBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "点歌列表";
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(379, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button_exit.Size = new System.Drawing.Size(21, 20);
            this.button_exit.TabIndex = 1;
            this.button_exit.Tag = "退出点歌机";
            this.button_exit.Text = "r";
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // button_settings
            // 
            this.button_settings.AutoSize = true;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_settings.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(358, 0);
            this.button_settings.Name = "button_settings";
            this.button_settings.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button_settings.Size = new System.Drawing.Size(21, 20);
            this.button_settings.TabIndex = 2;
            this.button_settings.Tag = "设置";
            this.button_settings.Text = "5";
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            this.button_settings.MouseEnter += new System.EventHandler(this.button_settings_MouseEnter);
            this.button_settings.MouseLeave += new System.EventHandler(this.button_settings_MouseLeave);
            // 
            // button_showLyric
            // 
            this.button_showLyric.AutoSize = true;
            this.button_showLyric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showLyric.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_showLyric.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.button_showLyric.ForeColor = System.Drawing.Color.White;
            this.button_showLyric.Location = new System.Drawing.Point(337, 0);
            this.button_showLyric.Name = "button_showLyric";
            this.button_showLyric.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button_showLyric.Size = new System.Drawing.Size(21, 20);
            this.button_showLyric.TabIndex = 3;
            this.button_showLyric.Tag = "显示歌词";
            this.button_showLyric.Text = ">";
            this.button_showLyric.Visible = false;
            this.button_showLyric.Click += new System.EventHandler(this.button_showLyric_Click);
            this.button_showLyric.MouseEnter += new System.EventHandler(this.button_showLyric_MouseEnter);
            this.button_showLyric.MouseLeave += new System.EventHandler(this.button_showLyric_MouseLeave);
            // 
            // button_showCard
            // 
            this.button_showCard.AutoSize = true;
            this.button_showCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_showCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_showCard.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.button_showCard.ForeColor = System.Drawing.Color.White;
            this.button_showCard.Location = new System.Drawing.Point(316, 0);
            this.button_showCard.Name = "button_showCard";
            this.button_showCard.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.button_showCard.Size = new System.Drawing.Size(21, 20);
            this.button_showCard.TabIndex = 0;
            this.button_showCard.Tag = "显示歌曲卡片";
            this.button_showCard.Text = "1";
            this.button_showCard.Visible = false;
            this.button_showCard.Click += new System.EventHandler(this.button_showCard_Click);
            this.button_showCard.MouseEnter += new System.EventHandler(this.button_showCard_MouseEnter);
            this.button_showCard.MouseLeave += new System.EventHandler(this.button_showCard_MouseLeave);
            // 
            // label_apperance
            // 
            this.label_apperance.AutoSize = true;
            this.label_apperance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_apperance.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_apperance.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.label_apperance.ForeColor = System.Drawing.Color.White;
            this.label_apperance.Location = new System.Drawing.Point(295, 0);
            this.label_apperance.Name = "label_apperance";
            this.label_apperance.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label_apperance.Size = new System.Drawing.Size(21, 20);
            this.label_apperance.TabIndex = 4;
            this.label_apperance.Tag = "外观";
            this.label_apperance.Text = "a";
            this.label_apperance.Click += new System.EventHandler(this.label_apperance_Click);
            this.label_apperance.MouseEnter += new System.EventHandler(this.label_apperance_MouseEnter);
            this.label_apperance.MouseLeave += new System.EventHandler(this.label_apperance_MouseLeave);
            // 
            // panel_sideStrip
            // 
            this.panel_sideStrip.Controls.Add(this.trackBar_volume);
            this.panel_sideStrip.Controls.Add(this.label_nextSong);
            this.panel_sideStrip.Controls.Add(this.label_continue);
            this.panel_sideStrip.Controls.Add(this.label_pause);
            this.panel_sideStrip.Controls.Add(this.label_loop);
            this.panel_sideStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sideStrip.Location = new System.Drawing.Point(0, 0);
            this.panel_sideStrip.Name = "panel_sideStrip";
            this.panel_sideStrip.Size = new System.Drawing.Size(20, 671);
            this.panel_sideStrip.TabIndex = 7;
            this.panel_sideStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.panel_sideStrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar_volume.LargeChange = 4;
            this.trackBar_volume.Location = new System.Drawing.Point(0, 519);
            this.trackBar_volume.Maximum = 100;
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_volume.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_volume.RightToLeftLayout = true;
            this.trackBar_volume.Size = new System.Drawing.Size(45, 80);
            this.trackBar_volume.TabIndex = 11;
            this.trackBar_volume.Tag = "音量";
            this.trackBar_volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_volume.Value = 100;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // label_nextSong
            // 
            this.label_nextSong.AutoSize = true;
            this.label_nextSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_nextSong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_nextSong.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_nextSong.ForeColor = System.Drawing.Color.White;
            this.label_nextSong.Location = new System.Drawing.Point(0, 599);
            this.label_nextSong.Name = "label_nextSong";
            this.label_nextSong.Size = new System.Drawing.Size(21, 18);
            this.label_nextSong.TabIndex = 10;
            this.label_nextSong.Tag = "下一首";
            this.label_nextSong.Text = "8";
            this.label_nextSong.Click += new System.EventHandler(this.label_nextSong_Click);
            this.label_nextSong.MouseEnter += new System.EventHandler(this.label_nextSong_MouseEnter);
            this.label_nextSong.MouseLeave += new System.EventHandler(this.label_nextSong_MouseLeave);
            // 
            // label_continue
            // 
            this.label_continue.AutoSize = true;
            this.label_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_continue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_continue.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_continue.ForeColor = System.Drawing.Color.White;
            this.label_continue.Location = new System.Drawing.Point(0, 617);
            this.label_continue.Name = "label_continue";
            this.label_continue.Size = new System.Drawing.Size(21, 18);
            this.label_continue.TabIndex = 9;
            this.label_continue.Tag = "继续";
            this.label_continue.Text = "4";
            this.label_continue.Click += new System.EventHandler(this.label_continue_Click);
            this.label_continue.MouseEnter += new System.EventHandler(this.label_continue_MouseEnter);
            this.label_continue.MouseLeave += new System.EventHandler(this.label_continue_MouseLeave);
            // 
            // label_pause
            // 
            this.label_pause.AutoSize = true;
            this.label_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_pause.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_pause.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_pause.ForeColor = System.Drawing.Color.White;
            this.label_pause.Location = new System.Drawing.Point(0, 635);
            this.label_pause.Name = "label_pause";
            this.label_pause.Size = new System.Drawing.Size(21, 18);
            this.label_pause.TabIndex = 8;
            this.label_pause.Tag = "暂停";
            this.label_pause.Text = ";";
            this.label_pause.Click += new System.EventHandler(this.label_pause_Click);
            this.label_pause.MouseEnter += new System.EventHandler(this.label_pause_MouseEnter);
            this.label_pause.MouseLeave += new System.EventHandler(this.label_pause_MouseLeave);
            // 
            // label_loop
            // 
            this.label_loop.AutoSize = true;
            this.label_loop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_loop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_loop.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_loop.ForeColor = System.Drawing.Color.White;
            this.label_loop.Location = new System.Drawing.Point(0, 653);
            this.label_loop.Name = "label_loop";
            this.label_loop.Size = new System.Drawing.Size(21, 18);
            this.label_loop.TabIndex = 7;
            this.label_loop.Tag = "列表循环";
            this.label_loop.Text = "`";
            this.label_loop.Click += new System.EventHandler(this.label_loop_Click);
            this.label_loop.MouseEnter += new System.EventHandler(this.label_loop_MouseEnter);
            this.label_loop.MouseLeave += new System.EventHandler(this.label_loop_MouseLeave);
            // 
            // panel_songList
            // 
            this.panel_songList.BackColor = System.Drawing.Color.Black;
            this.panel_songList.Controls.Add(this.splitContainer_listBox);
            this.panel_songList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_songList.Location = new System.Drawing.Point(0, 0);
            this.panel_songList.Margin = new System.Windows.Forms.Padding(4);
            this.panel_songList.Name = "panel_songList";
            this.panel_songList.Padding = new System.Windows.Forms.Padding(22, 22, 2, 2);
            this.panel_songList.Size = new System.Drawing.Size(400, 671);
            this.panel_songList.TabIndex = 8;
            this.panel_songList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.panel_songList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            // 
            // splitContainer_listBox
            // 
            this.splitContainer_listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_listBox.Location = new System.Drawing.Point(22, 22);
            this.splitContainer_listBox.Name = "splitContainer_listBox";
            this.splitContainer_listBox.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_listBox.Panel1
            // 
            this.splitContainer_listBox.Panel1.Controls.Add(this.panel1);
            this.splitContainer_listBox.Panel1.Controls.Add(this.listBox_songList);
            // 
            // splitContainer_listBox.Panel2
            // 
            this.splitContainer_listBox.Panel2.Controls.Add(this.panel2);
            this.splitContainer_listBox.Panel2.Controls.Add(this.listBox_songFinishedList);
            this.splitContainer_listBox.Size = new System.Drawing.Size(376, 647);
            this.splitContainer_listBox.SplitterDistance = 309;
            this.splitContainer_listBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_emptySongList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(354, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 307);
            this.panel1.TabIndex = 1;
            // 
            // label_emptySongList
            // 
            this.label_emptySongList.AutoSize = true;
            this.label_emptySongList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_emptySongList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_emptySongList.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_emptySongList.ForeColor = System.Drawing.Color.White;
            this.label_emptySongList.Location = new System.Drawing.Point(0, 287);
            this.label_emptySongList.Name = "label_emptySongList";
            this.label_emptySongList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label_emptySongList.Size = new System.Drawing.Size(21, 20);
            this.label_emptySongList.TabIndex = 2;
            this.label_emptySongList.Tag = "清空";
            this.label_emptySongList.Text = "<";
            this.label_emptySongList.Click += new System.EventHandler(this.label_emptySongList_Click);
            this.label_emptySongList.MouseEnter += new System.EventHandler(this.label_emptySongList_MouseEnter);
            this.label_emptySongList.MouseLeave += new System.EventHandler(this.label_emptySongList_MouseLeave);
            // 
            // listBox_songList
            // 
            this.listBox_songList.BackColor = System.Drawing.Color.Black;
            this.listBox_songList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_songList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_songList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox_songList.ForeColor = System.Drawing.Color.White;
            this.listBox_songList.FormattingEnabled = true;
            this.listBox_songList.ItemHeight = 20;
            this.listBox_songList.Location = new System.Drawing.Point(0, 0);
            this.listBox_songList.Name = "listBox_songList";
            this.listBox_songList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_songList.Size = new System.Drawing.Size(374, 307);
            this.listBox_songList.TabIndex = 0;
            this.listBox_songList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_songList_DrawItem);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_emptyFinishedList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(354, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 332);
            this.panel2.TabIndex = 2;
            // 
            // label_emptyFinishedList
            // 
            this.label_emptyFinishedList.AutoSize = true;
            this.label_emptyFinishedList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_emptyFinishedList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_emptyFinishedList.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label_emptyFinishedList.ForeColor = System.Drawing.Color.White;
            this.label_emptyFinishedList.Location = new System.Drawing.Point(0, 312);
            this.label_emptyFinishedList.Name = "label_emptyFinishedList";
            this.label_emptyFinishedList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.label_emptyFinishedList.Size = new System.Drawing.Size(21, 20);
            this.label_emptyFinishedList.TabIndex = 2;
            this.label_emptyFinishedList.Tag = "清空";
            this.label_emptyFinishedList.Text = "<";
            this.label_emptyFinishedList.Click += new System.EventHandler(this.label_emptyFinishedList_Click);
            this.label_emptyFinishedList.MouseEnter += new System.EventHandler(this.label_emptyFinishedList_MouseEnter);
            this.label_emptyFinishedList.MouseLeave += new System.EventHandler(this.label_emptyFinishedList_MouseLeave);
            // 
            // listBox_songFinishedList
            // 
            this.listBox_songFinishedList.BackColor = System.Drawing.Color.Black;
            this.listBox_songFinishedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_songFinishedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_songFinishedList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox_songFinishedList.ForeColor = System.Drawing.Color.White;
            this.listBox_songFinishedList.FormattingEnabled = true;
            this.listBox_songFinishedList.ItemHeight = 20;
            this.listBox_songFinishedList.Location = new System.Drawing.Point(0, 0);
            this.listBox_songFinishedList.Name = "listBox_songFinishedList";
            this.listBox_songFinishedList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_songFinishedList.Size = new System.Drawing.Size(374, 332);
            this.listBox_songFinishedList.TabIndex = 1;
            this.listBox_songFinishedList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox_songFinishedList_DrawItem);
            // 
            // timer_refreshList
            // 
            this.timer_refreshList.Interval = 2000;
            this.timer_refreshList.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // timer_refreshData
            // 
            this.timer_refreshData.Interval = 1000;
            this.timer_refreshData.Tick += new System.EventHandler(this.timer_refreshData_Tick);
            // 
            // timer_refreshSong
            // 
            this.timer_refreshSong.Interval = 1000;
            this.timer_refreshSong.Tick += new System.EventHandler(this.timer_refreshSong_Tick);
            // 
            // musicControllerBindingSource
            // 
            this.musicControllerBindingSource.DataSource = typeof(IMLoader.Controller.MusicController);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_sideStrip);
            this.Controls.Add(this.label_apperance);
            this.Controls.Add(this.button_showCard);
            this.Controls.Add(this.button_showLyric);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel_songList);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Opacity = 0.8D;
            this.Text = "冰镇抹茶小助手 2.0";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Shown += new System.EventHandler(this.Dashboard_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            this.panel_sideStrip.ResumeLayout(false);
            this.panel_sideStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            this.panel_songList.ResumeLayout(false);
            this.splitContainer_listBox.Panel1.ResumeLayout(false);
            this.splitContainer_listBox.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_listBox)).EndInit();
            this.splitContainer_listBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label button_settings;
        private System.Windows.Forms.Label button_showLyric;
        private System.Windows.Forms.Label button_showCard;
        private System.Windows.Forms.ToolTip toolTip_tips;
        private System.Windows.Forms.Label label_apperance;
        private System.Windows.Forms.Panel panel_sideStrip;
        private System.Windows.Forms.Label label_loop;
        private System.Windows.Forms.Label label_continue;
        private System.Windows.Forms.Label label_pause;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Label label_nextSong;
        private System.Windows.Forms.Panel panel_songList;
        private System.Windows.Forms.BindingSource musicControllerBindingSource;
        private System.Windows.Forms.Timer timer_refreshList;
        private System.Windows.Forms.SplitContainer splitContainer_listBox;
        private System.Windows.Forms.ListBox listBox_songList;
        private System.Windows.Forms.ListBox listBox_songFinishedList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_emptySongList;
        private System.Windows.Forms.Label label_emptyFinishedList;
        private System.Windows.Forms.Timer timer_refreshData;
        private System.Windows.Forms.Timer timer_refreshSong;
    }
}

