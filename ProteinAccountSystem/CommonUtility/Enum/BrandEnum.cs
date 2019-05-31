using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    public enum BrandEnum
    {
        Null = 00,
        [Description("EatMe")]
        EatMe = 01,
        [Description("Myprotein")]
        Myprotein = 02,
        [Description("RDX")]
        RDX = 02,
    }
}
