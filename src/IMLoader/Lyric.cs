using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMLoader
{
    public partial class Lyric : Form
    {
        private Point mPoint;
        public Lyric()
        {
            InitializeComponent();
        }

        private void Lyric_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard.lyricShowed = false;
        }

        private void Lyric_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mPoint = new Point(e.X, e.Y);
        }

        private void Lyric_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
                Controller.SystemConfigurationLoader.systemSettings.lyric.lyric_pos = new KeyValuePair<int, int>(this.Location.X, this.Location.Y);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            timer_refreshLyric.Stop();
            this.Close(); 
        }

        private void Lyric_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Controller.SystemConfigurationLoader.systemSettings.lyric.lyric_pos.Key, 
                Controller.SystemConfigurationLoader.systemSettings.lyric.lyric_pos.Value);
            this.Width = Controller.SystemConfigurationLoader.systemSettings.lyric.width;
            this.Height = Controller.SystemConfigurationLoader.systemSettings.lyric.height;
            label_curr.Height = label_come.Height = (this.Height-12) / 2;
            label_curr.Font = label_come.Font = new Font("Microsoft YaHei UI", 0.55f*(this.Height - 4) / 2,FontStyle.Bold);
            timer_refreshLyric.Start();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            CustomizeDashBoard customize = new CustomizeDashBoard(this.Width, this.Height, 600, 2000, 100, 1000);
            customize.ShowDialog();
            this.Size = new Size(customize.p_width, customize.p_height);
            Controller.SystemConfigurationLoader.systemSettings.lyric.width = this.Width;
            Controller.SystemConfigurationLoader.systemSettings.lyric.height = this.Height;
            label_curr.Height = label_come.Height = (this.Height - 12) / 2;
            label_curr.Font = label_come.Font = new Font("Microsoft YaHei UI", 0.55f * (this.Height - 4) / 2,FontStyle.Bold);
        }

        private void timer_refreshLyric_Tick(object sender, EventArgs e)
        {
            KeyValuePair<string,string> cur=Controller.LyricController.GetCurrentLyric();
            label_curr.Text = cur.Key;
            label_come.Text = cur.Value;
        }
    }
}
