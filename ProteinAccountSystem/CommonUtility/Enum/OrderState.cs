using System.ComponentModel;

namespace Common.Enum
{
    public enum OrderState
    {
        [Description("待出貨")]
        WaitingForShipment = 0,

        [Description("運送中")]
        Shipping = 01,

        [Description("完成")]
        Done = 02,

        [Description("已取消")]
        Cancel = 03,
    }
}