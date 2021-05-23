using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace IMLoader.Controller
{
    class DamOperationController
    {
        public static Models.BiliModel damList = new Models.BiliModel();
        public static void RefreshData()
        {
            try
            {

                damList = JsonSerializer.Deserialize<Models.BiliModel>(NetController.GetHttpContent(

                    "https://api.live.bilibili.com/xlive/web-room/v1/dM/gethistory?roomid="
                    + SystemConfigurationLoader.systemSettings.live.room_id)

                    );
                if (damList.code == 0)
                {
                    foreach (var item in damList.data.room.ToArray())
                    {
                        if (
                            Math.Abs(
                                BaseController.GetTimeSpec(item.timeline) - BaseController.GetTimeSpec(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                                ) > SystemConfigurationLoader.systemSettings.live.time_delta
                           )
                        {
                            damList.data.room.Remove(item);
                        }
                        else
                        {
                            if (item.text.Split(' ')[0].Equals(SystemConfigurationLoader.systemSettings.live.cmd_keyword))
                            {
                                try
                                {
                                    string rep = item.text.Split(' ')[0] + " ";
                                    KeyValuePair<string, string> songSpec = NetEaseController.TransformSong(item.text.Replace(rep, ""));
                                    if (songSpec.Key == "") { }
                                    else if (MusicController.songList.Contains(songSpec)) { }
                                    else if (MusicController.songFinishedList.Contains(songSpec))
                                    {
                                        MusicController.songFinishedList.Remove(songSpec);
                                        MusicController.songList.Add(songSpec);
                                    }
                                    else
                                    {
                                        MusicController.songList.Add(songSpec);
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                    foreach (var item in damList.data.admin.ToArray())
                    {
                        if (
                           Math.Abs(
                               BaseController.GetTimeSpec(item.timeline) - BaseController.GetTimeSpec(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                               ) > SystemConfigurationLoader.systemSettings.live.time_delta
                          )
                        {
                            damList.data.admin.Remove(item);
                        }
                        else
                        {
                            if (item.text.Split(' ')[0].Equals(SystemConfigurationLoader.systemSettings.live.cmd_keyword))
                            {
                                try
                                {
                                    string rep = item.text.Split(' ')[0] + " ";
                                    KeyValuePair<string, string> songSpec = NetEaseController.TransformSong(item.text.Replace(rep, ""));
                                    if (songSpec.Key == "") { }
                                    else if (MusicController.songList.Contains(songSpec)) { }
                                    else if (MusicController.songFinishedList.Contains(songSpec))
                                    {
                                        MusicController.songFinishedList.Remove(songSpec);
                                        MusicController.songList.Add(songSpec);
                                    }
                                    else
                                    {
                                        MusicController.songList.Add(songSpec);
                                    }
                                }
                                catch { }
                            }
                        }

                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("refresh failed:" + ex.Message);
            }
        }
    }
}
