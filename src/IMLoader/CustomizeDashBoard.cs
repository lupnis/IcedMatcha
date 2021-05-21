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
    public partial class CustomizeDashBoard : Form
    {
        public int p_width,p_height;
        private int prim_width, prim_height;
        public CustomizeDashBoard(int width,int height,int w_l,int w_h,int h_l,int h_h)
        {
            InitializeComponent();
            this.prim_width = width;
            this.prim_height = height;
            p_width = prim_width;
            p_height = prim_height;
            trackBar1.Value = width;
            trackBar1.Minimum = w_l;
            trackBar1.Maximum = w_h;
            trackBar2.Value = height;
            trackBar2.Minimum = h_l;
            trackBar2.Maximum = h_h;
            
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            p_height = prim_height;
            p_width = prim_width;
            this.Close();
        }

        private void CustomizeDashBoard_Load(object sender, EventArgs e)
        {
            label1.Text = "宽度 " + trackBar1.Value;
            label2.Text = "高度 " + trackBar2.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "宽度 " + trackBar1.Value;
            p_width = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = "高度 " + trackBar2.Value;
            p_height = trackBar2.Value;
        }
    }
}
