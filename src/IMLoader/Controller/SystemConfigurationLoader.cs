using System.Collections.Generic;
using System.Text.Json;
using System.Drawing;
using System.IO;
using IMLoader.Models;

namespace IMLoader.Controller
{
    class SystemConfigurationLoader
    {
        public static SystemSettingsModel systemSettings = new SystemSettingsModel();
        public static void LoadConfig()
        {
            if (File.Exists("system.json"))
            {
                systemSettings = JsonSerializer.Deserialize<SystemSettingsModel>(File.ReadAllText("system.json"));
            }
            else
            {
                RestoreConfig();
            }
        }
        public static void RestoreConfig()
        {
            systemSettings.version = "2.0.0";
            LiveSettingsModel live = new LiveSettingsModel();
            live.room_id = "8253461";
            live.time_delta = 10;
            live.cmd_keyword = "点歌";
            live.max_order = 100;
            live.default_songlist =new List<KeyValuePair<string, string>>();
            live.dashboard_pos = new KeyValuePair<int,int>(0, 0);
            live.width = 400;
            live.height = 300;
            live.background_color = Color.Black;
            live.transparency = .8f;
            systemSettings.live = live;

            CardSettingsModel card = new CardSettingsModel();
            card.card_pos = new KeyValuePair<int, int>(0, 0);
            card.width =400;
            card.height =80;
            card.background_color = Color.Black;
            card.transparency = .8f;
            card.loop = false;
            card.volume = 100;
            systemSettings.card = card;

            LyricSettingsModel lyric = new LyricSettingsModel();
            lyric.lyric_pos= new KeyValuePair<int, int>(0, 0);
            lyric.width =800;
            lyric.height =150;
            lyric.background_color = Color.Black;
            lyric.transparency = .8f;
            lyric.lyric_color = Color.White;
            systemSettings.lyric = lyric;

            SaveConfig();
            LoadConfig();
        }
        public static void SaveConfig()
        {
            File.WriteAllText("system.json",JsonSerializer.Serialize(systemSettings));
        }
    }
}
