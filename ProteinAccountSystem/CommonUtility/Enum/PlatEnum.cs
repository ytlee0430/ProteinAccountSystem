using System.ComponentModel;

namespace Common.Enum
{
    public enum PlatEnum
    {
        [Description("全部")]
        全部 = 0,

        /// <summary>
        /// 蝦皮
        /// </summary>
        [Description("蝦皮拍賣")]
        蝦皮拍賣 = 1,

        /// <summary>
        /// 樂天
        /// </summary>
        [Description("樂天")]
        樂天 = 2,

        /// <summary>
        /// 蝦皮商城
        /// </summary>
        [Description("蝦皮商城")]
        蝦皮商城 = 3,

        /// <summary>
        /// 店面零售
        /// </summary>
        [Description("店面零售")]
        店面零售 = 4,

        /// <summary>
        /// 批發
        /// </summary>
        [Description("批發")]
        批發 = 5,
    }
}