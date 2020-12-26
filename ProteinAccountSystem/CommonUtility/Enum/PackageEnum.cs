using System.ComponentModel;

namespace ProteinSystem.Enum
{
    public enum PackageEnum
    {
        [Description("全部")]
        All = 0,

        [Description("1kg")]
        OneKg = 01,

        [Description("2.5kg")]
        TwoHalfKg = 02,

        [Description("5kg")]
        FiveKg = 03,

        [Description("400ml")]
        FourHundredMili = 04,

        [Description("600ml")]
        SixHundredMili = 05,

        [Description("無分包裝")]
        NoPackage = 06,

        [Description("試用包")]
        Sample = 07,

        [Description("XS")]
        XS = 08,

        [Description("S")]
        S = 09,

        [Description("M")]
        M = 10,

        [Description("L")]
        L = 11,

        [Description("XL")]
        XL = 12,
    }
}