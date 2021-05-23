
namespace IMLoader
{
    partial class Lyric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lyric));
            this.button_exit = new System.Windows.Forms.Label();
            this.button_settings = new System.Windows.Forms.Label();
            this.timer_refreshLyric = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_curr = new System.Windows.Forms.Label();
            this.label_come = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(779, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(21, 18);
            this.button_exit.TabIndex = 2;
            this.button_exit.Tag = "退出点歌机";
            this.button_exit.Text = "r";
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_settings
            // 
            this.button_settings.AutoSize = true;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_settings.Font = new System.Drawing.Font("Webdings", 9.75F);
            this.button_settings.ForeColor = System.Drawing.Color.White;
            this.button_settings.Location = new System.Drawing.Point(758, 0);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(21, 18);
            this.button_settings.TabIndex = 3;
            this.button_settings.Tag = "设置";
            this.button_settings.Text = "5";
            this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
            // 
            // timer_refreshLyric
            // 
            this.timer_refreshLyric.Tick += new System.EventHandler(this.timer_refreshLyric_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_come);
            this.panel1.Controls.Add(this.label_curr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6);
            this.panel1.Size = new System.Drawing.Size(758, 150);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseMove);
            // 
            // label_curr
            // 
            this.label_curr.AutoEllipsis = true;
            this.label_curr.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_curr.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_curr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_curr.Location = new System.Drawing.Point(6, 6);
            this.label_curr.Name = "label_curr";
            this.label_curr.Size = new System.Drawing.Size(746, 48);
            this.label_curr.TabIndex = 0;
            this.label_curr.Text = "--------";
            this.label_curr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_curr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseDown);
            this.label_curr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseMove);
            // 
            // label_come
            // 
            this.label_come.AutoEllipsis = true;
            this.label_come.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_come.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_come.Location = new System.Drawing.Point(6, 54);
            this.label_come.Name = "label_come";
            this.label_come.Size = new System.Drawing.Size(746, 48);
            this.label_come.TabIndex = 1;
            this.label_come.Text = "--------";
            this.label_come.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_come.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseDown);
            this.label_come.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseMove);
            // 
            // Lyric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 150);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_settings);
            this.Controls.Add(this.button_exit);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lyric";
            this.Opacity = 0.8D;
            this.Text = "歌词面板";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lyric_FormClosing);
            this.Load += new System.EventHandler(this.Lyric_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lyric_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Label button_settings;
        private System.Windows.Forms.Timer timer_refreshLyric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_come;
        private System.Windows.Forms.Label label_curr;
    }
}