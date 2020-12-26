using System.ComponentModel;

namespace ProteinSystem.Enum
{
    public enum BrandEnum
    {
        [Description("全部")]
        All = 0,

        [Description("EatMe")]
        EatMe = 01,

        [Description("Myprotein")]
        Myprotein = 02,

        [Description("RDX")]
        RDX = 03,
    }
}