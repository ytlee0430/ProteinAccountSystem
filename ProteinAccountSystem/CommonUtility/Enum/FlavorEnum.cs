using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    public enum FlavorEnum
    {
        /// <summary>
        /// 無口味分類
        /// </summary>
         [Description("無口味")]
        Null = 00,

        /// <summary>
        ///  藍莓起司蛋糕
        /// </summary>
        [Description("藍莓起司蛋糕")]
        BlueCheeseCake = 01,

        /// <summary>
        /// 草莓奶油
        /// </summary>
        [Description("草莓奶油")]
        StrawberryButter = 02,

        /// <summary>
        ///焦糖海鹽 
        /// </summary>
        [Description("焦糖海鹽")]
        CaramelSalt = 03,

        /// <summary>
        /// 天然巧克力
        /// </summary>
        [Description("天然巧克力")]
        NaturalChocolate = 04,

        /// <summary>
        /// 巧克力布朗尼
        /// </summary>
        [Description("巧克力布朗尼")]
        ChocolateBrownie = 05,

        /// <summary>
        /// 天然草莓
        /// </summary>
        [Description("天然草莓")]
        NaturalStrawberry = 06,

        /// <summary>
        /// 薄荷巧克力
        /// </summary>
        [Description("薄荷巧克力")]
        MintChocolate = 07,

        /// <summary>
        /// 柔滑巧克力
        /// </summary>
        [Description("柔滑巧克力")]
        SmoothChocolate = 08,

        /// <summary>
        /// 英式奶茶
        /// </summary>
        [Description("英式奶茶")]
        MilkTea = 09,

        /// <summary>
        /// 巧克力花生醬	
        /// </summary>
        [Description("巧克力花生醬")]
        ChocolatePeanutButter = 10,

        /// <summary>
        /// 原味	
        /// </summary>
        [Description("原味")]
        UnFlavor = 11,

        /// <summary>
        /// 巧克力堅果
        /// </summary>
        [Description("巧克力堅果")]
        ChocolateNut = 12,

        /// <summary>
        /// 拿鐵
        /// </summary>
        [Description("拿鐵")]
        Latte = 13,

        /// <summary>
        /// 香蕉
        /// </summary>
        [Description("香蕉")]
        Banana = 14,

        /// <summary>
        /// 香草
        /// </summary>
        [Description("香草")]
        Vanilla = 15,

        /// <summary>
        /// 天然香草
        /// </summary>
        [Description("天然香草")]
        NaturalVanilla = 16,

        /// <summary>
        /// 摩卡
        /// </summary>
        [Description("摩卡")]
        Mocha = 18,

        /// <summary>
        /// 抹茶
        /// </summary>
        [Description("抹茶")]
        Matcha = 19,

        /// <summary>
        /// 焦糖巧克力
        /// </summary>
        [Description("焦糖巧克力")]
        CaramelChocolate = 20,

        /// <summary>
        /// 巧克力香蕉
        /// </summary>
        [Description("巧克力香蕉")]
        ChocolateBanana = 21,

        /// <summary>
        /// 北海道牛奶
        /// </summary>
        [Description("北海道牛奶")]
        HokkaidoMiik = 22,

        /// <summary>
        /// 草莓
        /// </summary>
        [Description("草莓")]
        Strawberry = 23,

        /// <summary>
        /// 咖啡
        /// </summary>
        [Description("咖啡")]
        Coffee = 24
    }
}
