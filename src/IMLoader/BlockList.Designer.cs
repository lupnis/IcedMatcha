
namespace IMLoader
{
    partial class BlockList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_del = new System.Windows.Forms.Button();
            this.textBox_song = new System.Windows.Forms.TextBox();
            this.label_intr = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Label();
            this.listBox_songList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_del);
            this.panel1.Controls.Add(this.textBox_song);
            this.panel1.Controls.Add(this.label_intr);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(422, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 433);
            this.panel1.TabIndex = 0;
            // 
            // button_del
            // 
            this.button_del.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_del.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_del.Location = new System.Drawing.Point(96, 75);
            this.button_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(79, 37);
            this.button_del.TabIndex = 16;
            this.button_del.Text = "删除";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // textBox_song
            // 
            this.textBox_song.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_song.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_song.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_song.ForeColor = System.Drawing.Color.White;
            this.textBox_song.Location = new System.Drawing.Point(11, 44);
            this.textBox_song.Name = "textBox_song";
            this.textBox_song.Size = new System.Drawing.Size(164, 24);
            this.textBox_song.TabIndex = 13;
            // 
            // label_intr
            // 
            this.label_intr.AutoSize = true;
            this.label_intr.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_intr.Location = new System.Drawing.Point(7, 22);
            this.label_intr.Name = "label_intr";
            this.label_intr.Size = new System.Drawing.Size(54, 19);
            this.label_intr.TabIndex = 15;
            this.label_intr.Text = "用户uid";
            // 
            // button_add
            // 
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(11, 75);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(79, 37);
            this.button_add.TabIndex = 14;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(164, 0);
            this.button_exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(21, 18);
            this.button_exit.TabIndex = 3;
            this.button_exit.Tag = "退出点歌机";
            this.button_exit.Text = "r";
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // listBox_songList
            // 
            this.listBox_songList.BackColor = System.Drawing.Color.Black;
            this.listBox_songList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_songList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_songList.ForeColor = System.Drawing.Color.White;
            this.listBox_songList.FormattingEnabled = true;
            this.listBox_songList.ItemHeight = 19;
            this.listBox_songList.Location = new System.Drawing.Point(0, 0);
            this.listBox_songList.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_songList.Name = "listBox_songList";
            this.listBox_songList.Size = new System.Drawing.Size(422, 433);
            this.listBox_songList.TabIndex = 1;
            // 
            // BlockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(607, 433);
            this.ControlBox = false;
            this.Controls.Add(this.listBox_songList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BlockList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "屏蔽列表";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_songList;
        private System.Windows.Forms.Label button_exit;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.TextBox textBox_song;
        private System.Windows.Forms.Label label_intr;
        private System.Windows.Forms.Button button_add;
    }
}