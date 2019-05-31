using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUtility.Entity;

namespace CommonUtility.Enum
{
    public class Enums
    {
        public static Dictionary<int, EnumModel> BrandEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> FlavorEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> PackageEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> PlatEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> ProductionDetailEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> ProductionEnum { get; set; } = new Dictionary<int, EnumModel>();


    }
}
