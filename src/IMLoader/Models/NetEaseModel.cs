using System.Collections.Generic;


namespace IMLoader.Models
{
    class MusicResultModel
    {
        public List<MusicDetailModel> songs { get; set; }//搜索歌曲返回列表
        public int songCount { get; set; }//歌曲计数
    }
    class MusicDetailModel
    {
        public string name { get; set; }//歌曲名
        public long id { get; set; }//歌曲id
    }
    class NetEaseModel
    {
        public MusicResultModel result { get; set; }//返回结果
        public long code { get; set; }//状态码（判断是否查询成功）
    }
}
