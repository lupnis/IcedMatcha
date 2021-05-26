
namespace IMLoader
{
    partial class Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_album = new System.Windows.Forms.PictureBox();
            this.panel_mainContainer = new System.Windows.Forms.Panel();
            this.label_nextSong = new System.Windows.Forms.Label();
            this.label_artist = new System.Windows.Forms.Label();
            this.label_songName = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_album)).BeginInit();
            this.panel_mainContainer.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_refresh
            // 
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // pictureBox_album
            // 
            this.pictureBox_album.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pictureBox_album.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_album.ErrorImage = global::IMLoader.Properties.Resources.empty;
            this.pictureBox_album.Image = global::IMLoader.Properties.Resources.empty;
            this.pictureBox_album.InitialImage = global::IMLoader.Properties.Resources.empty;
            this.pictureBox_album.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_album.Name = "pictureBox_album";
            this.pictureBox_album.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_album.TabIndex = 4;
            this.pictureBox_album.TabStop = false;
            this.pictureBox_album.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.pictureBox_album.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Card_MouseMove);
            // 
            // panel_mainContainer
            // 
            this.panel_mainContainer.BackColor = System.Drawing.Color.Black;
            this.panel_mainContainer.Controls.Add(this.label_nextSong);
            this.panel_mainContainer.Controls.Add(this.label_artist);
            this.panel_mainContainer.Controls.Add(this.label_songName);
            this.panel_mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainContainer.Location = new System.Drawing.Point(80, 0);
            this.panel_mainContainer.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.panel_mainContainer.Name = "panel_mainContainer";
            this.panel_mainContainer.Padding = new System.Windows.Forms.Padding(6, 6, 10, 6);
            this.panel_mainContainer.Size = new System.Drawing.Size(274, 80);
            this.panel_mainContainer.TabIndex = 5;
            this.panel_mainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_mainContainer_Paint);
            this.panel_mainContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.panel_mainContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Card_MouseMove);
            // 
            // label_nextSong
            // 
            this.label_nextSong.AutoEllipsis = true;
            this.label_nextSong.AutoSize = true;
            this.label_nextSong.BackColor = System.Drawing.Color.Transparent;
            this.label_nextSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_nextSong.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nextSong.Location = new System.Drawing.Point(6, 55);
            this.label_nextSong.Name = "label_nextSong";
            this.label_nextSong.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label_nextSong.Size = new System.Drawing.Size(65, 19);
            this.label_nextSong.TabIndex = 2;
            this.label_nextSong.Text = "无下一首";
            // 
            // label_artist
            // 
            this.label_artist.AutoEllipsis = true;
            this.label_artist.AutoSize = true;
            this.label_artist.BackColor = System.Drawing.Color.Transparent;
            this.label_artist.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_artist.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_artist.Location = new System.Drawing.Point(6, 32);
            this.label_artist.Name = "label_artist";
            this.label_artist.Padding = new System.Windows.Forms.Padding(0, 0, 4, 2);
            this.label_artist.Size = new System.Drawing.Size(94, 23);
            this.label_artist.TabIndex = 1;
            this.label_artist.Text = "无作者信息";
            // 
            // label_songName
            // 
            this.label_songName.AutoEllipsis = true;
            this.label_songName.AutoSize = true;
            this.label_songName.BackColor = System.Drawing.Color.Transparent;
            this.label_songName.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_songName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_songName.Location = new System.Drawing.Point(6, 6);
            this.label_songName.Name = "label_songName";
            this.label_songName.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label_songName.Size = new System.Drawing.Size(111, 26);
            this.label_songName.TabIndex = 0;
            this.label_songName.Text = "无歌曲信息";
            // 
            // panel_container
            // 
            this.panel_container.AutoSize = true;
            this.panel_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.panel_container.Controls.Add(this.button_settings);
            this.panel_container.Controls.Add(this.button_exit);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_container.Location = new System.Drawing.Point(354, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.panel_container.Size = new System.Drawing.Size(46, 80);
            this.panel_container.TabIndex = 6;
            this.panel_container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.panel_container.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Card_MouseMove);
            // 
            // button_settings
            // 
            this.button_settings.AutoSize = true;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_settings.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(4, 0);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(21, 18);
            this.button_settings.TabIndex = 5;
            this.button_settings.Tag = "卡片大小设置";
            this.button_settings.Text = "5";
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            this.button_settings.MouseEnter += new System.EventHandler(this.button_settings_MouseEnter);
            this.button_settings.MouseLeave += new System.EventHandler(this.button_settings_MouseLeave);
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(25, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(21, 18);
            this.button_exit.TabIndex = 4;
            this.button_exit.Tag = "关闭卡片";
            this.button_exit.Text = "r";
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            this.button_exit.MouseEnter += new System.EventHandler(this.button_exit_MouseEnter);
            this.button_exit.MouseLeave += new System.EventHandler(this.button_exit_MouseLeave);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 80);
            this.Controls.Add(this.panel_mainContainer);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.pictureBox_album);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Card";
            this.Opacity = 0.8D;
            this.Text = "播放小卡片";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Card_FormClosing);
            this.Load += new System.EventHandler(this.Card_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Card_MouseMove);
            this.Resize += new System.EventHandler(this.Card_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_album)).EndInit();
            this.panel_mainContainer.ResumeLayout(false);
            this.panel_mainContainer.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.PictureBox pictureBox_album;
        private System.Windows.Forms.Panel panel_mainContainer;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Label button_settings;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_artist;
        private System.Windows.Forms.Label label_songName;
        private System.Windows.Forms.Label label_nextSong;
    }
}