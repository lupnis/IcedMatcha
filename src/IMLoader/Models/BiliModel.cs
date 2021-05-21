using System.Collections.Generic;

namespace IMLoader.Models
{
    class DamDataModel
    {
        public List<DamSpecModel> admin { get; set; }//管理员（主播和房管）弹幕
        public List<DamSpecModel> room { get; set; }//普通用户弹幕
    }
    class DamSpecModel
    {
        public string text { get; set; }//弹幕内容
        public long uid { get; set; }//发出者uid
        public string nickname { get; set; }//发出者昵称
        public string timeline { get; set; }//发出时间
    }
    class BiliModel
    {
        public int code { get; set; }//请求错误判断
        public DamDataModel data { get; set; }//弹幕列表
        public string message { get; set; }//错误信息内容（如果有）
    }
}
