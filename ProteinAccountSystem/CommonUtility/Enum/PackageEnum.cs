using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    public enum PackageEnum
    {
        Null = 0,
        [Description("1 kg")]
        OneKg = 01,
        [Description("2.5 kg")]
        TwoHalfKg = 02,
        [Description("5 kg")]
        FiveKg = 03,
        [Description("400 ml")]
        FourHundredMili = 04,
        [Description("600 ml")]
        SixHundredMili = 05,
        [Description("無分包裝")]
        NoPackage =06,
        [Description("試用包")]
        Sample =07,
    }
}
