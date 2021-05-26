using System.Collections.Generic;


namespace IMLoader.Models
{
    public class MusicResultModel
    {
        public List<MusicDetailModel> songs { get; set; }//搜索歌曲返回列表
        public int songCount { get; set; }//歌曲计数
    }
    public class MusicDetailModel
    {
        public string name { get; set; }//歌曲名
        public long id { get; set; }//歌曲id
        public AlbumModel album { get; set; }//专辑数据
        public List<ArtistModel> artists { get; set; }//作曲者数据
    }
    public class NetEaseModel
    {
        public MusicResultModel result { get; set; }//返回结果
        public long code { get; set; }//状态码（判断是否查询成功）
    }
    public class AlbumModel
    {
        public string name { get; set; }//专辑名称
        public string picUrl { get; set; }//专辑封面
    }
    public class ArtistModel
    {
        public string name { get; set; }//作曲家名
    }
}
