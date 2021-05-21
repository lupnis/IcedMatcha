using System.Collections.Generic;
using System.Drawing;

namespace IMLoader.Models
{
    class SystemSettingsModel//系统参数
    {
        public string version { get; set; }//系统版本
        
        public LiveSettingsModel live { get; set; }//直播间参数
        public CardSettingsModel card { get; set; }//播放和播放卡片参数
        public LyricSettingsModel lyric { get; set; }//歌词窗口参数
        public bool showCard { get; set; }//卡片打开状态
        public bool showLyric { get; set; }//歌词打开状态

    }
    class LiveSettingsModel//直播间参数
    {
        public string room_id { get; set; }//直播间房间号
        public long time_delta { get; set; }//点歌间隔差值（建议不修改）
        public string cmd_keyword { get; set; }//点歌关键词
        public int max_order { get; set; }//最多点歌队列数
        public List<KeyValuePair<string,string>> default_songlist { get; set; }//缺省歌单

        public KeyValuePair<int, int> dashboard_pos { get; set; }//控制台启动板卡位置
        public int width { get; set; }//启动板卡宽度
        public int height { get; set; }//启动板卡高度
        public Color background_color { get; set; }//启动板卡背景颜色
        public float transparency { get; set; }//启动板卡透明度
    }
    class CardSettingsModel
    {
        public KeyValuePair<int, int> card_pos { get; set; }//播放卡片位置
        public int width { get; set; }//播放卡片宽度
        public int height { get; set; }//播放卡片高度
        public Color background_color { get; set; }//播放卡片背景颜色
        public float transparency { get; set; }//播放卡片透明度

        public bool loop { get; set; }//循环开关（打开后将会循环点歌列表）
        public int volume { get; set; }//音量控制
        //public bool store_list { get; set; }//歌单存储-3.0
        //public bool overwrite_list{get;set;}//用每天的点歌歌单替换缺省歌单-3.0
    }
    class LyricSettingsModel
    {
        public KeyValuePair<int, int> lyric_pos { get; set; }//歌词卡片位置
        public int width { get; set; }//歌词卡片宽度
        public int height { get; set; }//歌词卡片高度
        public Color background_color { get; set; }//歌词卡片背景颜色
        public float transparency { get; set; }//歌词卡片透明度
        //public Font lyric_font { get; set; }//歌词字体-由于System.Text.Json的不完全支持，无法对此参数进行读取-3.0
        public Color lyric_color { get; set; }//歌词颜色
    }
}
