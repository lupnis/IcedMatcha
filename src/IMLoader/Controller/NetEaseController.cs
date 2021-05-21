using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IMLoader.Controller
{
    class NetEaseController
    {
        public static KeyValuePair<string, string> TransformSong(string song)
        {
            try
            {
                Models.NetEaseModel musicResponse = new Models.NetEaseModel();
                musicResponse = JsonSerializer.Deserialize<Models.NetEaseModel>(
                    NetController.GetHttpContent("http://music.163.com/api/search/pc/?s=" + song + "&limit=1&type=1")
                    );
                if (musicResponse.code == 200)
                {
                    return new KeyValuePair<string, string>(musicResponse.result.songs[0].id.ToString(), musicResponse.result.songs[0].name);
                }
                else return new KeyValuePair<string, string>("", "");
            }
            catch
            {
                return new KeyValuePair<string, string>("", "");
            }
        }
    }
}
