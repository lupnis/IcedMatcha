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
    public partial class Card : Form
    {
        private Point mPoint;

        public Card()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void button_settings_Click(object sender, EventArgs e)
        {
            CustomizeDashBoard customize = new CustomizeDashBoard(this.Width, this.Height, 300, 800, 60, 100);
            customize.ShowDialog();
            this.Size = new Size(customize.p_width, customize.p_height);
            Controller.SystemConfigurationLoader.systemSettings.card.width = this.Width;
            Controller.SystemConfigurationLoader.systemSettings.card.height = this.Height;
        }
    }
}
