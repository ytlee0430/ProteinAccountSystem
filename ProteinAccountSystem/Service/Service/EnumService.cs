using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM;
using CommonUtility.Entity;

namespace Service.Service
{
    public class EnumService
    {
        public static Dictionary<int, EnumModel> BrandEnum { get; set; }
        public static Dictionary<int, EnumModel> FlavorEnum { get; set; }
        public static Dictionary<int, EnumModel> PackageEnum { get; set; }
        public static Dictionary<int, EnumModel> PlatEnum { get; set; }
        public static Dictionary<int, EnumModel> ProductionDetailEnum { get; set; }
        public static Dictionary<int, EnumModel> ProductionEnum { get; set; }


        public void EnumInitialize()
        {
            var context = new ProteinDB();
        }
    }
}
