using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtility.Enum
{
    public enum PlatEnum
    {
        /// <summary>
        /// 蝦皮
        /// </summary>
        [Description("蝦皮拍賣")]
        ShopeeSales = 0,
        
        /// <summary>
        /// 樂天
        /// </summary>
        [Description("樂天")]
        Rakuten = 1,
        
        /// <summary>
        /// 蝦皮商城
        /// </summary>
        [Description("蝦皮商城")]
        ShopeeShop=2,
        
        /// <summary>
        /// 店面零售
        /// </summary>
        [Description("店面零售")]
        FrontDoorSale=3,
        
        /// <summary>
        /// 批發
        /// </summary>
        [Description("批發")]
        Wholesale =4,
    }
}
