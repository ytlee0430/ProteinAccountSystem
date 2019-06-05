using System.ComponentModel;

namespace Common.Enum
{
    public enum ProductionType
    {
        [Description("全部")]
        All = 0,

        [Description("乳清")]
        WheyProtein = 01,

        [Description("健身配件")]
        ProtectiveGear = 02,

        [Description("其他")]
        Other = 03,
    }
}