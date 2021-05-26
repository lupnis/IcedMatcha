using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Runtime.InteropServices;

using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace IMLoader.Controller
{
    class MusicController
    {
        public static List<KeyValuePair<string, string>> songList = new List<KeyValuePair<string, string>>();
        public static List<KeyValuePair<string, string>> songFinishedList = new List<KeyValuePair<string, string>>();

        public static MediaFoundationReader media;
        public static WaveOutEvent waveOut;

        [DllImport("Winmm.dll")]
        private static extern int waveOutSetVolume(int hwo, uint pdwVolume);

        public static void AddSong(KeyValuePair<string, string> song)//添加歌曲
        {
            if (songList.Count + songFinishedList.Count < SystemConfigurationLoader.systemSettings.live.max_order)
            {
                if (!songList.Contains(song)&&song.Key!="") songList.Add(song);
            }
            else if (songList.Count >= SystemConfigurationLoader.systemSettings.live.max_order) { }
            else
            {
                if(song.Key!="")songFinishedList[0] = song;
            }
            GC.Collect();
        }
        public static double GetPos()//获取歌曲当前播放位置
        {
            if(media is null||waveOut is null||waveOut.PlaybackState==PlaybackState.Stopped)
            {
                return 0d;
            }
            return (double)waveOut.GetPosition()/3d/60d/1000d;
        }
        public static void EndSong()//结束当前歌曲播放
        {
            if (!(media is null)&&!(waveOut is null))
            {
                waveOut.Stop();
                waveOut.Dispose();
                media.Dispose();
                if (songList.Count > 0)
                {
                    if (SystemConfigurationLoader.systemSettings.card.loop)
                    {
                        songFinishedList.Add(songList[0]);
                    }
                    songList.RemoveAt(0);
                }
            }
                waveOut = null;
                media = null;
            GC.Collect();
        }
        public static void DelSong(int i)//删除指定歌曲
        {
            try
            {
                if (i == 0)
                {
                    if (!(media is null))
                    {
                        waveOut.Stop();
                        waveOut.Dispose();
                        media.Dispose();
                    }
                    else
                    {
                        songList.RemoveAt(0);
                    }
                }
                else
                {
                    songList.RemoveAt(i);
                }
                waveOut = null;
                media = null;
            }
            catch{}
            finally
            {
                GC.Collect();
            }
        }
        public static void ContinueSong()//继续播放（没有播放就开始默认播放）
        {
            if (!(waveOut is null)&& waveOut.PlaybackState == PlaybackState.Paused)
            {
                waveOut.Play();
            }
            else
            {
                StartSong();
            }
        }
        public static void PauseSong()//暂停播放歌曲
        {
            if (!(waveOut is null)&&waveOut.PlaybackState==PlaybackState.Playing)
            {
                waveOut.Pause();
            }
        }
        public static void NextSong()//下一曲
        {
            EndSong();
            ContinueSong();
        }
        public static void StartSong()//多状态歌曲播放维持
        {
            if((media is null)||(waveOut is null))//未初始化点歌部分
            {
                try
                {
                    if (songList.Count > 0)
                    {
                        Card.musicResponse = JsonSerializer.Deserialize<Models.NetEaseModel>(
                       NetController.GetHttpContent("http://music.163.com/api/search/pc/?s=" +songList[0].Key + "&limit=1&type=1")
                       );
                        LyricController.LoadLyric();
                        media = new MediaFoundationReader(NetController.GetRedirectContent("https://music.163.com/song/media/outer/url?id=" + songList[0].Key));
                        waveOut = new WaveOutEvent();
                        waveOut.Init(media);
                        waveOut.Play();
                    }
                    else if ( SystemConfigurationLoader.systemSettings.card.loop&&songFinishedList.Count > 0 )
                    {
                        songList.Add(songFinishedList[0]);
                        songFinishedList.RemoveAt(0);
                    }
                    else
                    {
                        Card.musicResponse = new Models.NetEaseModel();
                        LyricController.lyric = new Models.LyricModel();
                        LyricController.lyricDic = new Dictionary<double, string>();
                    }
                }
                catch{EndSong();}
            }
            else//已初始化
            {
                if (waveOut.PlaybackState == PlaybackState.Playing) { }//正在播放，不执行操作
                else if (waveOut.PlaybackState == PlaybackState.Stopped) //播放结束了
                {
                    EndSong();
                }
            }
        }
       
        public static void SetVolume(int v)
        {
            System.UInt32 Value = (System.UInt32)((double)0xffff * (double)v / (double)100);
            System.UInt32 v_c = (System.UInt32)Value;
            waveOutSetVolume(0, v_c << 16 | v_c);
        }
    }
}
