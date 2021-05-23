using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IMLoader.Controller
{
    class LyricController
    {
        public static Models.LyricModel lyric = new Models.LyricModel();
        public static Dictionary<double, string> lyricDic = new Dictionary<double, string>();

        public static void LoadLyric()
        {
            lyricDic.Clear();
            if (MusicController.songList.Count > 0)
            {
                lyric = JsonSerializer.Deserialize<Models.LyricModel>(
                    NetController.GetHttpContent("http://music.163.com/api/song/media?id=" + MusicController.songList[0].Key));
                if (lyric.code == 200)
                {
                    if (lyric.lyric is null)
                    {
                       
                    }
                    else
                    {
                        string[] lines = lyric.lyric.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                        foreach (string line in lines)
                        {
                            if (line.StartsWith("[ti:") || line.StartsWith("[ar:") || line.StartsWith("[al:") || line.StartsWith("[by:") || line.StartsWith("[offset:"))
                            {
                                continue;
                            }
                            try
                            {
                                Regex regex = new Regex(@".*\](.*)");
                                Match mcw = regex.Match(line);
                                string word = mcw.Groups[1].Value;
                                if (word.Replace(" ", "") == "")
                                {
                                    continue;
                                }
                                Regex regextime = new Regex(@"\[([0-9.:]*)\]", RegexOptions.Compiled);
                                MatchCollection mct = regextime.Matches(line);
                                foreach (Match item in mct)
                                {
                                    double time = TimeSpan.Parse("00:" + item.Groups[1].Value).TotalSeconds;
                                    lyricDic.Add(time, word);
                                }
                            }
                            catch
                            {
                                continue;
                            }
                        }
                        lyricDic = lyricDic.OrderBy(t => t.Key).ToDictionary(t => t.Key, p => p.Value);
                    }
                }
            }
        }
        public static KeyValuePair<string,string> GetCurrentLyric()
        {
            double seconds = MusicController.GetPos();
            if (lyricDic.Count < 1)
            {
                return new KeyValuePair<string, string>("歌曲无歌词或为纯音乐", "");
            }
            var list = lyricDic.ToList();
            if (seconds < list[0].Key)
            {
                return new KeyValuePair<string, string>("--------", list[0].Value);
            }
            else
            {
                for (int i = 1; i < lyricDic.Count; i++)
                {
                    if (seconds < list[i].Key)
                    {
                        return new KeyValuePair<string, string>(list[i - 1].Value, (list.Count > i)? list[i].Value:"");
                    }
                }
                return new KeyValuePair<string, string>("--------","--------");
            }
        }
    }

}
