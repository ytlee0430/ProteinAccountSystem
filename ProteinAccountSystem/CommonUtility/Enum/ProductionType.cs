using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    public enum ProductionType
    {
        [Description("無")]
        Null = 0,
        [Description("乳清")]
        WheyProtein = 01,
        [Description("健身配件")]
        ProtectiveGear = 02,
        [Description("其他")]
        Other = 03,
    }
}
