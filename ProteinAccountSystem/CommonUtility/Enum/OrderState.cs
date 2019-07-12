using System.ComponentModel;

namespace Common.Enum
{
    public enum OrderState
    {
        [Description("待出貨")]
        待出貨 = 0,

        [Description("運送中")]
        運送中 = 01,

        [Description("完成")]
        完成 = 02,

        [Description("已取消")]
        已取消 = 03,

        [Description("尚未付款")]
        尚未付款 = 04,
    }
}