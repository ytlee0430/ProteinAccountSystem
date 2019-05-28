using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonUtility.Enum
{
    public enum BrandEnum
    {
        Null = 00,
        [Description("Myprotein")]
        Myprotein = 01,
        [Description("EatMe")]
        EatMe = 02,
        [Description("RDX")]
        RDX = 02,
    }
}
