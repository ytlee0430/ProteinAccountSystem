using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtility.Enum
{
    public enum PackageEnum
    {
        Null = 0,
        [Description("1公斤")]
        OneKg = 01,
        [Description("2.5公斤")]
        TwoHalfKg = 02,
        [Description("五公斤")]
        FiveKg = 03,
        [Description("400ml")]
        FourHundredMili = 04,
        [Description("600ml")]
        SixHundredMili = 05,
        [Description("無分包裝")]
        NoPackage =06,
        [Description("試用包")]
        Sample =07,
    }
}
