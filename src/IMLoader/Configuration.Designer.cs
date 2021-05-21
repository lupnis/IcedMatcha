
namespace IMLoader
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.flow_live = new System.Windows.Forms.FlowLayoutPanel();
            this.label_roomid = new System.Windows.Forms.Label();
            this.textBox_roomid = new System.Windows.Forms.TextBox();
            this.label_cmdDelta = new System.Windows.Forms.Label();
            this.numeric_cmdDelta = new System.Windows.Forms.NumericUpDown();
            this.label_prefix = new System.Windows.Forms.Label();
            this.textBox_prefix = new System.Windows.Forms.TextBox();
            this.label_maxQueue = new System.Windows.Forms.Label();
            this.numeric_maxQueue = new System.Windows.Forms.NumericUpDown();
            this.button_testConnection = new System.Windows.Forms.Button();
            this.groupBox_live = new System.Windows.Forms.GroupBox();
            this.groupBox_lyric = new System.Windows.Forms.GroupBox();
            this.flow_lyric = new System.Windows.Forms.FlowLayoutPanel();
            this.label_font = new System.Windows.Forms.Label();
            this.textBox_font = new System.Windows.Forms.TextBox();
            this.button_chooseFont = new System.Windows.Forms.Button();
            this.label_color = new System.Windows.Forms.Label();
            this.panel_color = new System.Windows.Forms.Panel();
            this.button_chooseColor = new System.Windows.Forms.Button();
            this.groupBox_card = new System.Windows.Forms.GroupBox();
            this.flow_card = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox_loop = new System.Windows.Forms.CheckBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.button_save = new System.Windows.Forms.Button();
            this.flow_live.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cmdDelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxQueue)).BeginInit();
            this.groupBox_live.SuspendLayout();
            this.groupBox_lyric.SuspendLayout();
            this.flow_lyric.SuspendLayout();
            this.groupBox_card.SuspendLayout();
            this.flow_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // flow_live
            // 
            this.flow_live.Controls.Add(this.label_roomid);
            this.flow_live.Controls.Add(this.textBox_roomid);
            this.flow_live.Controls.Add(this.label_cmdDelta);
            this.flow_live.Controls.Add(this.numeric_cmdDelta);
            this.flow_live.Controls.Add(this.label_prefix);
            this.flow_live.Controls.Add(this.textBox_prefix);
            this.flow_live.Controls.Add(this.label_maxQueue);
            this.flow_live.Controls.Add(this.numeric_maxQueue);
            this.flow_live.Controls.Add(this.button_testConnection);
            this.flow_live.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_live.Location = new System.Drawing.Point(3, 20);
            this.flow_live.Name = "flow_live";
            this.flow_live.Size = new System.Drawing.Size(553, 100);
            this.flow_live.TabIndex = 0;
            // 
            // label_roomid
            // 
            this.label_roomid.AutoSize = true;
            this.label_roomid.Location = new System.Drawing.Point(3, 0);
            this.label_roomid.Name = "label_roomid";
            this.label_roomid.Size = new System.Drawing.Size(62, 19);
            this.label_roomid.TabIndex = 0;
            this.label_roomid.Text = "直播间id:";
            // 
            // textBox_roomid
            // 
            this.textBox_roomid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_roomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_roomid.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_roomid.ForeColor = System.Drawing.Color.White;
            this.textBox_roomid.Location = new System.Drawing.Point(71, 3);
            this.textBox_roomid.Name = "textBox_roomid";
            this.textBox_roomid.Size = new System.Drawing.Size(150, 24);
            this.textBox_roomid.TabIndex = 1;
            this.textBox_roomid.Text = "8253461";
            this.textBox_roomid.TextChanged += new System.EventHandler(this.textBox_roomid_TextChanged);
            // 
            // label_cmdDelta
            // 
            this.label_cmdDelta.AutoSize = true;
            this.label_cmdDelta.Location = new System.Drawing.Point(227, 0);
            this.label_cmdDelta.Name = "label_cmdDelta";
            this.label_cmdDelta.Size = new System.Drawing.Size(163, 19);
            this.label_cmdDelta.TabIndex = 2;
            this.label_cmdDelta.Text = "点歌间隔差值(不建议修改):";
            // 
            // numeric_cmdDelta
            // 
            this.numeric_cmdDelta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numeric_cmdDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_cmdDelta.ForeColor = System.Drawing.Color.White;
            this.numeric_cmdDelta.Location = new System.Drawing.Point(396, 3);
            this.numeric_cmdDelta.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numeric_cmdDelta.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_cmdDelta.Name = "numeric_cmdDelta";
            this.numeric_cmdDelta.Size = new System.Drawing.Size(150, 24);
            this.numeric_cmdDelta.TabIndex = 3;
            this.numeric_cmdDelta.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_cmdDelta.ValueChanged += new System.EventHandler(this.numeric_cmdDelta_ValueChanged);
            // 
            // label_prefix
            // 
            this.label_prefix.AutoSize = true;
            this.label_prefix.Location = new System.Drawing.Point(3, 30);
            this.label_prefix.Name = "label_prefix";
            this.label_prefix.Size = new System.Drawing.Size(103, 19);
            this.label_prefix.TabIndex = 4;
            this.label_prefix.Text = "点歌关键词前缀:";
            // 
            // textBox_prefix
            // 
            this.textBox_prefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_prefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_prefix.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prefix.ForeColor = System.Drawing.Color.White;
            this.textBox_prefix.Location = new System.Drawing.Point(112, 33);
            this.textBox_prefix.Name = "textBox_prefix";
            this.textBox_prefix.Size = new System.Drawing.Size(150, 24);
            this.textBox_prefix.TabIndex = 5;
            this.textBox_prefix.Text = "点歌";
            this.textBox_prefix.TextChanged += new System.EventHandler(this.textBox_prefix_TextChanged);
            // 
            // label_maxQueue
            // 
            this.label_maxQueue.AutoSize = true;
            this.label_maxQueue.Location = new System.Drawing.Point(268, 30);
            this.label_maxQueue.Name = "label_maxQueue";
            this.label_maxQueue.Size = new System.Drawing.Size(116, 19);
            this.label_maxQueue.TabIndex = 6;
            this.label_maxQueue.Text = "最多点歌队列长度:";
            // 
            // numeric_maxQueue
            // 
            this.numeric_maxQueue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.numeric_maxQueue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_maxQueue.ForeColor = System.Drawing.Color.White;
            this.numeric_maxQueue.Location = new System.Drawing.Point(390, 33);
            this.numeric_maxQueue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric_maxQueue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_maxQueue.Name = "numeric_maxQueue";
            this.numeric_maxQueue.Size = new System.Drawing.Size(100, 24);
            this.numeric_maxQueue.TabIndex = 7;
            this.numeric_maxQueue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeric_maxQueue.ValueChanged += new System.EventHandler(this.numeric_maxQueue_ValueChanged);
            // 
            // button_testConnection
            // 
            this.button_testConnection.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_testConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_testConnection.Location = new System.Drawing.Point(3, 63);
            this.button_testConnection.Name = "button_testConnection";
            this.button_testConnection.Size = new System.Drawing.Size(108, 30);
            this.button_testConnection.TabIndex = 8;
            this.button_testConnection.Text = "测试连接";
            this.button_testConnection.UseVisualStyleBackColor = true;
            this.button_testConnection.Click += new System.EventHandler(this.button_testConnection_Click);
            // 
            // groupBox_live
            // 
            this.groupBox_live.Controls.Add(this.flow_live);
            this.groupBox_live.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_live.ForeColor = System.Drawing.Color.White;
            this.groupBox_live.Location = new System.Drawing.Point(0, 0);
            this.groupBox_live.Name = "groupBox_live";
            this.groupBox_live.Size = new System.Drawing.Size(559, 123);
            this.groupBox_live.TabIndex = 0;
            this.groupBox_live.TabStop = false;
            this.groupBox_live.Text = "直播间参数设置";
            // 
            // groupBox_lyric
            // 
            this.groupBox_lyric.Controls.Add(this.flow_lyric);
            this.groupBox_lyric.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_lyric.Enabled = false;
            this.groupBox_lyric.ForeColor = System.Drawing.Color.Gray;
            this.groupBox_lyric.Location = new System.Drawing.Point(0, 174);
            this.groupBox_lyric.Name = "groupBox_lyric";
            this.groupBox_lyric.Size = new System.Drawing.Size(559, 90);
            this.groupBox_lyric.TabIndex = 2;
            this.groupBox_lyric.TabStop = false;
            this.groupBox_lyric.Text = "歌词设置";
            // 
            // flow_lyric
            // 
            this.flow_lyric.Controls.Add(this.label_font);
            this.flow_lyric.Controls.Add(this.textBox_font);
            this.flow_lyric.Controls.Add(this.button_chooseFont);
            this.flow_lyric.Controls.Add(this.label_color);
            this.flow_lyric.Controls.Add(this.panel_color);
            this.flow_lyric.Controls.Add(this.button_chooseColor);
            this.flow_lyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_lyric.Location = new System.Drawing.Point(3, 20);
            this.flow_lyric.Name = "flow_lyric";
            this.flow_lyric.Size = new System.Drawing.Size(553, 67);
            this.flow_lyric.TabIndex = 0;
            // 
            // label_font
            // 
            this.label_font.AutoSize = true;
            this.label_font.Enabled = false;
            this.label_font.ForeColor = System.Drawing.Color.Gray;
            this.label_font.Location = new System.Drawing.Point(3, 0);
            this.label_font.Name = "label_font";
            this.label_font.Size = new System.Drawing.Size(64, 19);
            this.label_font.TabIndex = 5;
            this.label_font.Text = "歌词字体:";
            // 
            // textBox_font
            // 
            this.textBox_font.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_font.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_font.Enabled = false;
            this.textBox_font.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_font.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_font.Location = new System.Drawing.Point(73, 3);
            this.textBox_font.Name = "textBox_font";
            this.textBox_font.ReadOnly = true;
            this.textBox_font.Size = new System.Drawing.Size(439, 24);
            this.textBox_font.TabIndex = 6;
            this.textBox_font.Text = "Microsoft YaHei UI, 9.75pt";
            this.textBox_font.TextChanged += new System.EventHandler(this.textBox_font_TextChanged);
            // 
            // button_chooseFont
            // 
            this.button_chooseFont.Enabled = false;
            this.button_chooseFont.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_chooseFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chooseFont.ForeColor = System.Drawing.Color.Gray;
            this.button_chooseFont.Location = new System.Drawing.Point(518, 3);
            this.button_chooseFont.Name = "button_chooseFont";
            this.button_chooseFont.Size = new System.Drawing.Size(32, 24);
            this.button_chooseFont.TabIndex = 9;
            this.button_chooseFont.Text = "...";
            this.button_chooseFont.UseVisualStyleBackColor = true;
            this.button_chooseFont.Click += new System.EventHandler(this.button_chooseFont_Click);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Enabled = false;
            this.label_color.ForeColor = System.Drawing.Color.Gray;
            this.label_color.Location = new System.Drawing.Point(3, 30);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(64, 19);
            this.label_color.TabIndex = 10;
            this.label_color.Text = "歌词颜色:";
            // 
            // panel_color
            // 
            this.panel_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_color.Enabled = false;
            this.panel_color.Location = new System.Drawing.Point(73, 33);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(57, 24);
            this.panel_color.TabIndex = 11;
            // 
            // button_chooseColor
            // 
            this.button_chooseColor.Enabled = false;
            this.button_chooseColor.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_chooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chooseColor.ForeColor = System.Drawing.Color.Gray;
            this.button_chooseColor.Location = new System.Drawing.Point(136, 33);
            this.button_chooseColor.Name = "button_chooseColor";
            this.button_chooseColor.Size = new System.Drawing.Size(32, 24);
            this.button_chooseColor.TabIndex = 12;
            this.button_chooseColor.Text = "...";
            this.button_chooseColor.UseVisualStyleBackColor = true;
            this.button_chooseColor.Click += new System.EventHandler(this.button_chooseColor_Click);
            // 
            // groupBox_card
            // 
            this.groupBox_card.Controls.Add(this.flow_card);
            this.groupBox_card.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_card.ForeColor = System.Drawing.Color.White;
            this.groupBox_card.Location = new System.Drawing.Point(0, 123);
            this.groupBox_card.Name = "groupBox_card";
            this.groupBox_card.Size = new System.Drawing.Size(559, 51);
            this.groupBox_card.TabIndex = 1;
            this.groupBox_card.TabStop = false;
            this.groupBox_card.Text = "播放器设置";
            // 
            // flow_card
            // 
            this.flow_card.Controls.Add(this.checkBox_loop);
            this.flow_card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_card.Location = new System.Drawing.Point(3, 20);
            this.flow_card.Name = "flow_card";
            this.flow_card.Size = new System.Drawing.Size(553, 28);
            this.flow_card.TabIndex = 0;
            // 
            // checkBox_loop
            // 
            this.checkBox_loop.AutoSize = true;
            this.checkBox_loop.Location = new System.Drawing.Point(3, 3);
            this.checkBox_loop.Name = "checkBox_loop";
            this.checkBox_loop.Size = new System.Drawing.Size(106, 23);
            this.checkBox_loop.TabIndex = 0;
            this.checkBox_loop.Text = "循环播放列表";
            this.checkBox_loop.UseVisualStyleBackColor = true;
            this.checkBox_loop.CheckedChanged += new System.EventHandler(this.checkBox_loop_CheckedChanged);
            // 
            // fontDialog
            // 
            this.fontDialog.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button_save
            // 
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Location = new System.Drawing.Point(6, 270);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(218, 30);
            this.button_save.TabIndex = 9;
            this.button_save.Text = "关闭（所有修改自动保存）";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 306);
            this.ControlBox = false;
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox_lyric);
            this.Controls.Add(this.groupBox_card);
            this.Controls.Add(this.groupBox_live);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Configuration";
            this.Text = "基础配置";
            this.Shown += new System.EventHandler(this.Configuration_Shown);
            this.flow_live.ResumeLayout(false);
            this.flow_live.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cmdDelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_maxQueue)).EndInit();
            this.groupBox_live.ResumeLayout(false);
            this.groupBox_lyric.ResumeLayout(false);
            this.flow_lyric.ResumeLayout(false);
            this.flow_lyric.PerformLayout();
            this.groupBox_card.ResumeLayout(false);
            this.flow_card.ResumeLayout(false);
            this.flow_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_live;
        private System.Windows.Forms.Label label_roomid;
        private System.Windows.Forms.TextBox textBox_roomid;
        private System.Windows.Forms.Label label_cmdDelta;
        private System.Windows.Forms.NumericUpDown numeric_cmdDelta;
        private System.Windows.Forms.Label label_prefix;
        private System.Windows.Forms.TextBox textBox_prefix;
        private System.Windows.Forms.Label label_maxQueue;
        private System.Windows.Forms.NumericUpDown numeric_maxQueue;
        private System.Windows.Forms.Button button_testConnection;
        private System.Windows.Forms.GroupBox groupBox_live;
        private System.Windows.Forms.GroupBox groupBox_lyric;
        private System.Windows.Forms.FlowLayoutPanel flow_lyric;
        private System.Windows.Forms.GroupBox groupBox_card;
        private System.Windows.Forms.FlowLayoutPanel flow_card;
        private System.Windows.Forms.CheckBox checkBox_loop;
        private System.Windows.Forms.Label label_font;
        private System.Windows.Forms.TextBox textBox_font;
        private System.Windows.Forms.Button button_chooseFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Button button_chooseColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button button_save;
    }
}