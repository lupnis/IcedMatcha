using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace IMLoader
{
    public partial class Card : Form
    {
        private Point mPoint;

        public Card()
        {
            InitializeComponent();
            toolTip.SetToolTip(button_settings, button_settings.Tag.ToString());
            toolTip.SetToolTip(button_exit, button_exit.Tag.ToString());
        }

        private void Card_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard.songCardShowed = false;
        }

        private void Card_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Controller.SystemConfigurationLoader.systemSettings.card.card_pos.Key,
                Controller.SystemConfigurationLoader.systemSettings.card.card_pos.Value);
            this.Width = Controller.SystemConfigurationLoader.systemSettings.card.width;
            this.Height = Controller.SystemConfigurationLoader.systemSettings.card.height;
            this.pictureBox_album.Width = this.Height;
            this.timer_refresh.Start();
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mPoint = new Point(e.X, e.Y);
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
                Controller.SystemConfigurationLoader.systemSettings.card.card_pos = new KeyValuePair<int, int>(this.Location.X, this.Location.Y);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.timer_refresh.Stop();
            this.Close();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            CustomizeDashBoard customize = new CustomizeDashBoard(this.Width, this.Height, 300, 800, 60, 100);
            customize.ShowDialog();
            this.Size = new Size(customize.p_width, customize.p_height);
            Controller.SystemConfigurationLoader.systemSettings.card.width = this.Width;
            Controller.SystemConfigurationLoader.systemSettings.card.height = this.Height;
            this.pictureBox_album.Width = this.Height;
            panel_mainContainer.Refresh();
            if (this.Height < 80)
            {
                label_nextSong.Visible = false;
            }
            else
            {
                label_nextSong.Visible = true;
            }
        }

        private void panel_mainContainer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush lgb = new LinearGradientBrush(new Point(0, 0), new Point(this.panel_mainContainer.Width, 0), Color.FromArgb(0, 0, 0), Color.FromArgb(0, 60, 0));
            g.FillRectangle(lgb, panel_mainContainer.ClientRectangle);
            lgb.Dispose();
        }

        private void button_exit_MouseEnter(object sender, EventArgs e)
        {
            button_exit.BackColor = Color.DimGray;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            button_exit.BackColor = Color.Transparent;
        }

        private void button_settings_MouseEnter(object sender, EventArgs e)
        {
            button_settings.BackColor = Color.DarkGreen;
        }

        private void button_settings_MouseLeave(object sender, EventArgs e)
        {
            button_settings.BackColor = Color.Transparent;
        }

        private void Card_Resize(object sender, EventArgs e)
        {
            if (this.Height < 80)
            {
                label_nextSong.Visible = false;
            }
            else
            {
                label_nextSong.Visible = true;
            }
        }

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            if (Controller.MusicController.songList.Count > 0)
            {
                label_songName.Text = Controller.MusicController.songList[0].Value;
                try
                {
                    Models.NetEaseModel musicResponse = new Models.NetEaseModel();
                    musicResponse = JsonSerializer.Deserialize<Models.NetEaseModel>(
                        Controller.NetController.GetHttpContent("http://music.163.com/api/search/pc/?s=" + 
                        Controller.MusicController.songList[0].Key+ "&limit=1&type=1")
                        );
                    if (musicResponse.code == 200)
                    {
                        this.label_artist.Text= musicResponse.result.songs[0].artists[0].name;
                        this.pictureBox_album.ImageLocation = musicResponse.result.songs[0].album.picUrl;
                    }
                    
                }
                catch
                {
                    
                }
            }
            else
            {
                label_songName.Text = "无歌曲信息";
                label_artist.Text = "无作者信息";
                pictureBox_album.ImageLocation = "";
            }
            if (Controller.MusicController.songList.Count > 1)
            {
                this.label_nextSong.Text = "下一首: " + Controller.MusicController.songList[1].Value;
            }
            else if(Controller.MusicController.songFinishedList.Count > 0&&Controller.SystemConfigurationLoader.systemSettings.card.loop)
            {
                this.label_nextSong.Text = "下一首: " + Controller.MusicController.songFinishedList[0].Value;
            }
            else
            {
                this.label_nextSong.Text = "无下一首";
            }


        }
    }
}
