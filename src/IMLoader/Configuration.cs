using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace IMLoader
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            this.textBox_roomid.Text = Controller.SystemConfigurationLoader.systemSettings.live.room_id;
            this.numeric_cmdDelta.Value = Controller.SystemConfigurationLoader.systemSettings.live.time_delta;
            this.textBox_prefix.Text = Controller.SystemConfigurationLoader.systemSettings.live.cmd_keyword;
            this.numeric_maxQueue.Value = Controller.SystemConfigurationLoader.systemSettings.live.max_order;
            
            //this.colorDialog.Color = Controller.SystemConfigurationLoader.systemSettings.lyric.background_color;
            this.checkBox_loop.Checked = Controller.SystemConfigurationLoader.systemSettings.card.loop;
        }

        private void textBox_roomid_TextChanged(object sender, EventArgs e)
        {
            if (textBox_roomid.Text != "")
            {
                Controller.SystemConfigurationLoader.systemSettings.live.room_id = textBox_roomid.Text;
            }
        }

        private void numeric_cmdDelta_ValueChanged(object sender, EventArgs e)
        {
            Controller.SystemConfigurationLoader.systemSettings.live.time_delta = (long)numeric_cmdDelta.Value;
        }

        private void textBox_prefix_TextChanged(object sender, EventArgs e)
        {
            if (textBox_prefix.Text != "")
            {
                Controller.SystemConfigurationLoader.systemSettings.live.cmd_keyword = textBox_prefix.Text;
            }
        }

        private void numeric_maxQueue_ValueChanged(object sender, EventArgs e)
        {
            Controller.SystemConfigurationLoader.systemSettings.live.max_order = (int)numeric_maxQueue.Value;
        }

        private void checkBox_loop_CheckedChanged(object sender, EventArgs e)
        {
            Controller.SystemConfigurationLoader.systemSettings.card.loop = checkBox_loop.Checked;
        }

        private void textBox_font_TextChanged(object sender, EventArgs e)
        {
            //BugFix-3.0
        }

        private void button_chooseFont_Click(object sender, EventArgs e)
        {
            //BugFix-3.0
        }

        private void button_chooseColor_Click(object sender, EventArgs e)
        {
            //BugFix-3.0
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_testConnection_Click(object sender, EventArgs e)
        {
            if(Controller.NetController.GetHttpContent(

                "https://api.live.bilibili.com/xlive/web-room/v1/dM/gethistory?roomid="
                + Controller.SystemConfigurationLoader.systemSettings.live.room_id)!=""
                )
            {
                MessageBox.Show("网络连接正常，只要确保roomid正确填写啦~", "测试通过", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("网络连接失败！检查一下网络哦~", "测试失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Configuration_Shown(object sender, EventArgs e)
        {
            this.panel_color.BackColor = Controller.SystemConfigurationLoader.systemSettings.lyric.background_color;
        }
    }
}
