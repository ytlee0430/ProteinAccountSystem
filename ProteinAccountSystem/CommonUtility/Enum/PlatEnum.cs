using System.ComponentModel;

namespace Common.Enum
{
    public enum PlatEnum
    {
        [Description("全部")]
        All = 0,

        /// <summary>
        /// 蝦皮
        /// </summary>
        [Description("蝦皮拍賣")]
        ShopeeSales = 1,

        /// <summary>
        /// 樂天
        /// </summary>
        [Description("樂天")]
        Rakuten = 2,

        /// <summary>
        /// 蝦皮商城
        /// </summary>
        [Description("蝦皮商城")]
        ShopeeShop = 3,

        /// <summary>
        /// 店面零售
        /// </summary>
        [Description("店面零售")]
        FrontDoorSale = 4,

        /// <summary>
        /// 批發
        /// </summary>
        [Description("批發")]
        Wholesale = 5,
    }
}