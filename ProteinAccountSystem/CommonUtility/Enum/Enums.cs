using Common.Entity;
using System.Collections.Generic;

namespace Common.Enum
{
    public class Enums
    {
        public static Dictionary<int, EnumModel> BrandEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> FlavorEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> PackageEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> PlatEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> ProductionDetailEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> ProductionEnum { get; set; } = new Dictionary<int, EnumModel>();
        public static Dictionary<int, EnumModel> ClassEnum { get; set; } = new Dictionary<int, EnumModel>();
    }
}