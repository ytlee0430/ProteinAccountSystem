using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    public enum ProductionDetail
    {
        [Description("其他")]
        Null = 0,
        [Description("乳清")]
        WheyProtein = 2,
        [Description("分離式乳清")]
        IsolateWheyProtein = 3,
        [Description("分離式大豆蛋白")]
        IsolateSoyProtein = 4,
        [Description("餅乾")]
        Cookie = 5,
        [Description("一般腰帶")]
        Belt = 6,
        [Description("快扣腰帶")]
        PowerliftingBelt = 7,
        [Description("低階手套")]
        LowClassGloves = 8,
        [Description("中階手套")]
        MiddleClassGloves = 9,
        [Description("高階手套")]
        HighClassGloves = 10,
        [Description("健身拉力勾")]
        GymReverseHookStrap = 11,
        [Description("健身拉力帶")]
        GymStrapGel = 12,
        [Description("健身倍力帶")]
        GymProHook = 13,
        [Description("健身護腕")]
        GymWristWrap = 14,
        [Description("高蛋白燕麥棒")]
        ProteinOatBar = 15,
        [Description("巧克力布朗尼")]
        ChocalateBrownie = 16,
        [Description("巧克力花生醬")]
        PeanutButter = 17,
        [Description("杏仁醬")]
        AlmondButter = 18,
        [Description("零卡餅乾")]
        MyBarZero = 19,
        [Description("遙遙杯")]
        Sharker = 20,
        [Description("鑄鐵遙遙杯")]
        SteelSharker = 21,
        [Description("握力器")]
        Grip = 22,
        [Description("BCAA")]
        BCAA =23
    }
}
