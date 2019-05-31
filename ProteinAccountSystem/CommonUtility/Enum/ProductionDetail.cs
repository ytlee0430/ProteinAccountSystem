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
        [Description("全部")]
        All = 0,
        [Description("濃縮")]
        WheyProtein = 1,
        [Description("分離")]
        IsolateWheyProtein = 2,
        [Description("分離式大豆蛋白")]
        IsolateSoyProtein = 3,
        [Description("餅乾")]
        Cookie = 4,
        [Description("一般腰帶")]
        Belt = 5,
        [Description("快扣腰帶")]
        PowerliftingBelt = 6,
        [Description("低階手套")]
        LowClassGloves = 7,
        [Description("中階手套")]
        MiddleClassGloves = 8,
        [Description("高階手套")]
        HighClassGloves = 9,
        [Description("健身拉力勾")]
        GymReverseHookStrap = 10,
        [Description("健身拉力帶")]
        GymStrapGel = 11,
        [Description("健身倍力帶")]
        GymProHook = 12,
        [Description("健身護腕")]
        GymWristWrap = 13,
        [Description("高蛋白燕麥棒")]
        ProteinOatBar = 14,
        [Description("巧克力布朗尼")]
        ChocalateBrownie = 15,
        [Description("花生醬")]
        PeanutButter = 16,
        [Description("杏仁醬")]
        AlmondButter = 17,
        [Description("零卡高纖蛋白棒")]
        MyBarZero = 18,
        [Description("遙遙杯")]
        Sharker = 19,
        [Description("鋼材遙遙杯")]
        SteelSharker = 20,
        [Description("握力器")]
        Grip = 21,
        [Description("BCAA")]
        BCAA =22
    }
}
