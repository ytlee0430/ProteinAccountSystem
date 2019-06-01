using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM;
using CodeFirstORM.DBLayer;
using CodeFirstORM.Entity;
using Common.Enum;
using Common.Utils;
using CommonUtility.Entity;
using CommonUtility.Enum;

namespace Service.Service
{
    public class EnumService
    {
       
        public static void EnumInitialize()
        {
            var repo = new EnumClassRepository();
            var enumEntitis = repo.GetAll();
            foreach (var enumEntity in enumEntitis)
            {
                Dictionary<int, EnumModel> dic = null;
                switch (enumEntity.EnumClassDescription)
                {
                    case "Brand":
                        dic = Enums.BrandEnum;
                        break;
                    case "Flavor":
                        dic = Enums.FlavorEnum;
                        break;
                    case "Package":
                        dic = Enums.PackageEnum;
                        break;
                    case "Plat":
                        dic = Enums.PlatEnum;
                        break;
                    case "ProductionDetail":
                        dic = Enums.ProductionDetailEnum;
                        break;
                    case "Production":
                        dic = Enums.ProductionEnum;
                        break;
                    default:
                        break;
                }
                foreach (var e in enumEntity.Enums)
                    dic.Add(e.EnumValue, new EnumModel { Description = e.Description, EnumValue = e.EnumValue, KeyWord = e.KeyWord });
            }
        }

      
    }
}
