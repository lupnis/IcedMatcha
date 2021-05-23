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
    public partial class AddSong : Form
    {
        private Point mPoint;
        public AddSong()
        {
            InitializeComponent();
        }

        private void AddSong_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mPoint = new Point(e.X, e.Y);
        }

        private void AddSong_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Controller.MusicController.AddSong(Controller.NetEaseController.TransformSong(textBox_song.Text));
            MessageBox.Show("点歌成功！嗷嗷~", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_song.Text = "";
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
