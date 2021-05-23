using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private static extern int waveOutSetVolume(int hwo, System.UInt32 pdwVolume);

        public static void AddSong(KeyValuePair<string, string> song)
        {
            if (songList.Count + songFinishedList.Count < Controller.SystemConfigurationLoader.systemSettings.live.max_order)
            {
                if (!songList.Contains(song)) songList.Add(song);
            }
            else if (songList.Count >= Controller.SystemConfigurationLoader.systemSettings.live.max_order) { }
            else
            {
                songFinishedList[0] = song;
            }
        }
        public static double GetPos()
        {
            if(media is null)
            {
                return 0d;
            }
            return (double)waveOut.GetPosition()/3d/60d/1000d;
        }

        public static void EndSong()
        {
            if (!(media is null))
            {
                waveOut.Stop();
                if (songList.Count > 0)
                {
                    if (SystemConfigurationLoader.systemSettings.card.loop&&songList.Count>0)
                    {
                        songFinishedList.Add(songList[0]);
                    }
                    if(songList.Count > 0)songList.RemoveAt(0);
                }
            }
        }
        public static void StartSong()
        {
            if (!(media is null))//开始播放：如果已有歌曲加入列表
            {
                if (waveOut.PlaybackState == PlaybackState.Playing) { }//如果歌还在播放：不执行操作
                else if (waveOut.PlaybackState == PlaybackState.Stopped)//如果歌播放完成：下一首
                {
                    EndSong();
                    try
                    {
                        if (songList.Count > 0)//有预约歌单
                        {
                            media = new MediaFoundationReader(NetController.GetRedirectContent("https://music.163.com/song/media/outer/url?id=" + songList[0].Key));
                            waveOut = new WaveOutEvent();
                            waveOut.Init(media);
                            waveOut.Play();
                        }
                        else if (SystemConfigurationLoader.systemSettings.card.loop && songFinishedList.Count > 0)//开启循环且循环歌单有内容
                        {
                            songList.Add(songFinishedList[0]);
                            songFinishedList.RemoveAt(0);
                            if (songList.Count > 0)//有预约歌单
                            {
                                media = new MediaFoundationReader(NetController.GetRedirectContent("https://music.163.com/song/media/outer/url?id=" + songList[0].Key));
                                waveOut = new WaveOutEvent();
                                waveOut.Init(media);
                                waveOut.Play();
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        if (songList.Count > 0)
                        {
                            Console.WriteLine("play failed:" + ex.Message);
                            waveOut.Stop();
                            songList.RemoveAt(0);
                        }
                    }
                }
            }
            else//还未播放过：未实例化
            {
                try
                {
                    if (songList.Count > 0)
                    {
                        media = new MediaFoundationReader(NetController.GetRedirectContent("https://music.163.com/song/media/outer/url?id=" + songList[0].Key));
                        waveOut = new WaveOutEvent();
                        waveOut.Init(media);
                        waveOut.Play();
                    }
                    else if (songFinishedList.Count > 0 && SystemConfigurationLoader.systemSettings.card.loop)
                    {
                        songList.Add(songFinishedList[0]);
                        songFinishedList.RemoveAt(0);
                    }
                }
                catch(Exception ex)
                {
                    waveOut.Dispose();
                    media.Dispose();
                    Console.WriteLine("err occurred:"+ex.Message);
                }
            }
        }
        public static void ContinueSong()
        {
            if (!(media is null) && waveOut.PlaybackState == PlaybackState.Paused && songList.Count > 0)
            {
                waveOut.Play();
            }
        }
        public static void PauseSong()
        {
            if (!(media is null))
            {
                waveOut.Pause();
            }
        }
        public static void NextSong()
        {
            if(!(media is null)) { waveOut.Stop(); }
            StartSong();
        }
        public static void SetVolume(int v)
        {
            System.UInt32 Value = (System.UInt32)((double)0xffff * (double)v / (double)100);
            System.UInt32 v_c = (System.UInt32)Value;
            waveOutSetVolume(0, v_c << 16 | v_c);
        }
    }
}
