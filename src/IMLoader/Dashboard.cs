using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace IMLoader
{
    public partial class Dashboard : Form
    {
        /*variables*/
        public static bool lyricShowed = false,
            songCardShowed = false,
            loop = false,
            firstRun=true;
        private Point mPoint;



      

        public Dashboard()
        {
            InitializeComponent();
            toolTip_tips.SetToolTip(button_exit, button_exit.Tag.ToString());
            toolTip_tips.SetToolTip(button_showCard, button_showCard.Tag.ToString());
            toolTip_tips.SetToolTip(button_settings, button_settings.Tag.ToString());
            toolTip_tips.SetToolTip(button_showLyric, button_showLyric.Tag.ToString());
            toolTip_tips.SetToolTip(label_apperance, label_apperance.Tag.ToString());
            toolTip_tips.SetToolTip(label_loop, label_loop.Tag.ToString());
            toolTip_tips.SetToolTip(label_pause, label_pause.Tag.ToString());
            toolTip_tips.SetToolTip(label_continue, label_continue.Tag.ToString());
            toolTip_tips.SetToolTip(label_nextSong, label_nextSong.Tag.ToString());
            toolTip_tips.SetToolTip(label_emptySongList, label_emptySongList.Tag.ToString());
            toolTip_tips.SetToolTip(label_emptyFinishedList, label_emptyFinishedList.Tag.ToString());
            toolTip_tips.SetToolTip(label_addSingleSong, label_addSingleSong.Tag.ToString());
            toolTip_tips.SetToolTip(label_addFromWeb, label_addFromWeb.Tag.ToString());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Controller.SystemConfigurationLoader.LoadConfig();
            this.Location = new Point(Controller.SystemConfigurationLoader.systemSettings.live.dashboard_pos.Key, Controller.SystemConfigurationLoader.systemSettings.live.dashboard_pos.Value);
            this.Width = Controller.SystemConfigurationLoader.systemSettings.live.width;
            this.Height = Controller.SystemConfigurationLoader.systemSettings.live.height;
            this.trackBar_volume.Value = Controller.SystemConfigurationLoader.systemSettings.card.volume;
            Controller.MusicController.SetVolume(this.trackBar_volume.Value);
            loop = Controller.SystemConfigurationLoader.systemSettings.card.loop;
            label_loop.BackColor = loop ? Color.DarkBlue : Color.Black;
            Controller.MusicController.songList.AddRange(Controller.SystemConfigurationLoader.systemSettings.live.default_songlist);
            label_title.Text = "点歌列表 - " + Controller.SystemConfigurationLoader.systemSettings.live.room_id;
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mPoint = new Point(e.X, e.Y);
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
                Controller.SystemConfigurationLoader.systemSettings.live.dashboard_pos = new KeyValuePair<int, int>(this.Location.X, this.Location.Y);
            }
        }

        #region Effects

        private void label_addFromWeb_MouseEnter(object sender, EventArgs e)
        {
            label_addFromWeb.BackColor = Color.DarkGray;
        }

        private void label_addFromWeb_MouseLeave(object sender, EventArgs e)
        {
            label_addFromWeb.BackColor = Color.Black;
        }
        private void label_addSingleSong_MouseEnter(object sender, EventArgs e)
        {
            label_addSingleSong.BackColor = Color.DarkGray;
        }

        private void label_addSingleSong_MouseLeave(object sender, EventArgs e)
        {
            label_addSingleSong.BackColor = Color.Black;
        }
        private void label_emptySongList_MouseEnter(object sender, EventArgs e)
        {
            label_emptySongList.BackColor = Color.DarkRed;
        }

        private void label_emptyFinishedList_MouseEnter(object sender, EventArgs e)
        {
            label_emptyFinishedList.BackColor = Color.DarkRed;
        }

        private void label_emptySongList_MouseLeave(object sender, EventArgs e)
        {
            label_emptySongList.BackColor = Color.Black;
        }

        private void label_emptyFinishedList_MouseLeave(object sender, EventArgs e)
        {
            label_emptyFinishedList.BackColor = Color.Black;
        }

        private void button_exit_MouseEnter(object sender, EventArgs e)
        {
            button_exit.BackColor = Color.DarkGray;
        }

        private void button_exit_MouseLeave(object sender, EventArgs e)
        {
            button_exit.BackColor = Color.Black;
        }

        private void button_showCard_MouseEnter(object sender, EventArgs e)
        {
            button_showCard.BackColor = Color.DarkGray;
        }

        private void button_showCard_MouseLeave(object sender, EventArgs e)
        {
            button_showCard.BackColor = Color.Black;
        }

        private void button_settings_MouseEnter(object sender, EventArgs e)
        {
            button_settings.BackColor = Color.DarkGray;
        }

        private void button_settings_MouseLeave(object sender, EventArgs e)
        {
            button_settings.BackColor = Color.Black;
        }

        private void button_showLyric_MouseEnter(object sender, EventArgs e)
        {
            button_showLyric.BackColor = Color.DarkGray;
        }

        private void button_showLyric_MouseLeave(object sender, EventArgs e)
        {
            button_showLyric.BackColor = Color.Black;
        }

        private void label_apperance_MouseEnter(object sender, EventArgs e)
        {
            label_apperance.BackColor = Color.DarkGray;
        }

        private void label_apperance_MouseLeave(object sender, EventArgs e)
        {
            label_apperance.BackColor = Color.Black;
        }

        private void label_nextSong_MouseEnter(object sender, EventArgs e)
        {
            label_nextSong.BackColor = Color.DarkGray;
        }

        private void label_continue_MouseEnter(object sender, EventArgs e)
        {
            label_continue.BackColor = Color.DarkGray;
        }

        private void label_pause_MouseEnter(object sender, EventArgs e)
        {
            label_pause.BackColor = Color.DarkGray;
        }

        private void label_loop_MouseEnter(object sender, EventArgs e)
        {
            if (!loop) label_loop.BackColor = Color.DarkGray;
        }

        private void label_nextSong_MouseLeave(object sender, EventArgs e)
        {
            label_nextSong.BackColor = Color.Black;
        }

        private void label_continue_MouseLeave(object sender, EventArgs e)
        {
            label_continue.BackColor = Color.Black;
        }

        private void label_pause_MouseLeave(object sender, EventArgs e)
        {
            label_pause.BackColor = Color.Black;
        }

        private void label_loop_MouseLeave(object sender, EventArgs e)
        {
            if (!loop) label_loop.BackColor = Color.Black;
        }
        private void listBox_songList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == 0)
            {
                Graphics g = e.Graphics;
                Rectangle bound = e.Bounds;
                string text = listBox_songList.Items[0].ToString();
                Brush brush = Brushes.DarkGreen;
                g.FillRectangle(brush, bound);

                TextRenderer.DrawText(g, text, this.listBox_songList.Font, bound, Color.White,
                                      TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else if (e.Index > 0)
            {
                Graphics g = e.Graphics;
                Rectangle bound = e.Bounds;
                string text = listBox_songList.Items[e.Index].ToString();
                Brush brush = Brushes.Black;
                g.FillRectangle(brush, bound);

                TextRenderer.DrawText(g, text, this.listBox_songList.Font, bound, Color.White,
                                      TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }

        private void listBox_songFinishedList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == 0)
            {
                Graphics g = e.Graphics;
                Rectangle bound = e.Bounds;
                string text = listBox_songFinishedList.Items[0].ToString();
                Brush brush = Brushes.DarkBlue;
                g.FillRectangle(brush, bound);
                TextRenderer.DrawText(g, text, this.listBox_songFinishedList.Font, bound, Color.White,
                                      TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else if (e.Index > 0)
            {
                Graphics g = e.Graphics;
                Rectangle bound = e.Bounds;
                string text = listBox_songFinishedList.Items[e.Index].ToString();
                Brush brush = Brushes.Black;
                g.FillRectangle(brush, bound);
                TextRenderer.DrawText(g, text, this.listBox_songFinishedList.Font, bound, Color.White,
                                      TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }

        #endregion

        #region Tool Strip Buttons
        private void button_exit_Click(object sender, EventArgs e)
        {
            if(!(Controller.MusicController.media is null))
            {
                if (Controller.MusicController.waveOut.PlaybackState != PlaybackState.Stopped)
                {
                    Controller.MusicController.waveOut.Stop();
                    Controller.MusicController.waveOut.Dispose();
                    Controller.MusicController.media.Dispose();
                }
            }
            Controller.SystemConfigurationLoader.systemSettings.card.loop = loop;
            Controller.SystemConfigurationLoader.systemSettings.showCard = songCardShowed;
            Controller.SystemConfigurationLoader.systemSettings.showLyric = lyricShowed;
            Controller.SystemConfigurationLoader.systemSettings.live.default_songlist.Clear();
            Controller.SystemConfigurationLoader.systemSettings.live.default_songlist.AddRange(Controller.MusicController.songList);
            Controller.SystemConfigurationLoader.systemSettings.live.default_songlist.AddRange(Controller.MusicController.songFinishedList);
            Controller.SystemConfigurationLoader.SaveConfig();
            Application.Exit();
        }

        private void button_showCard_Click(object sender, EventArgs e)
        {
            if (!songCardShowed)
            {
                songCardShowed = true;
                Card cardFrm = new Card();
                cardFrm.Show();
            }
        }

        private void label_apperance_Click(object sender, EventArgs e)
        {
            CustomizeDashBoard customize = new CustomizeDashBoard(this.Width, this.Height, 400, 1000, 300, 2000);
            customize.ShowDialog();
            this.Size = new Size(customize.p_width, customize.p_height);
            Controller.SystemConfigurationLoader.systemSettings.live.height = this.Height;
            Controller.SystemConfigurationLoader.systemSettings.live.width = this.Width;
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            Configuration configurationFrm = new Configuration();
            configurationFrm.ShowDialog();
            loop = Controller.SystemConfigurationLoader.systemSettings.card.loop;
            label_loop.BackColor = loop ? Color.DarkBlue : Color.Black;
        }

        private void label_loop_Click(object sender, EventArgs e)
        {
            loop = !loop;
            if (loop) label_loop.BackColor = Color.DarkBlue;
            else label_loop.BackColor = Color.Black;
            Controller.SystemConfigurationLoader.systemSettings.card.loop = loop;

        }

        private void label_pause_Click(object sender, EventArgs e)
        {
            Controller.MusicController.PauseSong();
        }
        
        private void label_continue_Click(object sender, EventArgs e)
        {
            if (firstRun) {
               Controller.MusicController.StartSong(); firstRun = false; }
            else { Controller.MusicController.ContinueSong(); }
        }

        private void trackBar_volume_Scroll(object sender, EventArgs e)
        {
            Controller.SystemConfigurationLoader.systemSettings.card.volume = this.trackBar_volume.Value;
            Controller.MusicController.SetVolume(this.trackBar_volume.Value);
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            if (Controller.SystemConfigurationLoader.systemSettings.showCard)
            {
                songCardShowed = true;
                Card cardFrm = new Card();
                cardFrm.Show();
            }
            if (Controller.SystemConfigurationLoader.systemSettings.showLyric)
            {
                lyricShowed = true;
                Lyric lyricFrm = new Lyric();
                lyricFrm.Show();
            }
            timer_refreshList.Start();
            timer_refreshData.Start();
            timer_refreshSong.Start();
        }

        private void label_emptySongList_Click(object sender, EventArgs e)
        {
            Controller.MusicController.songList.Clear();
            Controller.MusicController.EndSong();
        }

        private void label_emptyFinishedList_Click(object sender, EventArgs e)
        {
            Thread thread_c = new Thread(new ThreadStart(Controller.MusicController.songFinishedList.Clear));
            thread_c.Start();
        }

        private void label_nextSong_Click(object sender, EventArgs e)
        {
            Controller.MusicController.NextSong();
        }

        private void button_showLyric_Click(object sender, EventArgs e)
        {
            if (!lyricShowed)
            {
                lyricShowed = true;
                Lyric lyricFrm = new Lyric();
                lyricFrm.Show();
            }
        }

       

        private void label_addFromWeb_Click(object sender, EventArgs e)
        {

        }

        private void label_addSingleSong_Click(object sender, EventArgs e)
        {
            AddSong addSingleSongFrm = new AddSong();
            addSingleSongFrm.Show();
        }



        #endregion

        #region Timers

        private void timer_refresh_Tick(object sender, EventArgs e)
        {
            listBox_songList.Items.Clear();
            listBox_songFinishedList.Items.Clear();
            int i = 1;
            foreach (var item in Controller.MusicController.songList)
            {
                listBox_songList.Items.Add(i + ": " + item.Key + " - " + item.Value);
                i++;
            }
            i = 1;
            foreach (var item in Controller.MusicController.songFinishedList)
            {
                listBox_songFinishedList.Items.Add(i + ": " + item.Key + " - " + item.Value);
                i++;
            }

        }

        private void timer_refreshData_Tick(object sender, EventArgs e)
        {
            label_title.Text = "点歌列表 - " + Controller.SystemConfigurationLoader.systemSettings.live.room_id;
            Controller.DamOperationController.RefreshData();
        }

        private void timer_refreshSong_Tick(object sender, EventArgs e)
        {
            if (!firstRun) 
            {
                Controller.MusicController.StartSong(); 
            }
        }
        #endregion

    }
}
