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

        public static void InitailizeDatabase()
        {
            var repoClass = new EnumClassRepository();
            List<EnumClassEntity> enumClasses = new List<EnumClassEntity>();
            var brandEnums = new List<EnumEntity>();
            foreach (BrandEnum brand in Enum.GetValues(typeof(BrandEnum)))
            {
                var dis = brand.GetDescriptionText();
                brandEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Brand", Enums = brandEnums });

            var flavorEnums = new List<EnumEntity>();
            foreach (FlavorEnum brand in Enum.GetValues(typeof(FlavorEnum)))
            {
                var dis = brand.GetDescriptionText();
                flavorEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Flavor", Enums = flavorEnums });

            var packageEnums = new List<EnumEntity>();
            foreach (PackageEnum brand in Enum.GetValues(typeof(PackageEnum)))
            {
                var dis = brand.GetDescriptionText();
                packageEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Package", Enums = packageEnums });

            var platEnums = new List<EnumEntity>();
            foreach (PlatEnum brand in Enum.GetValues(typeof(PlatEnum)))
            {
                var dis = brand.GetDescriptionText();
                platEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Plat", Enums = platEnums });

            var productionDetailEnums = new List<EnumEntity>();
            foreach (ProductionDetail brand in Enum.GetValues(typeof(ProductionDetail)))
            {
                var dis = brand.GetDescriptionText();
                productionDetailEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "ProductionDetail", Enums = productionDetailEnums });

            var productionEnums = new List<EnumEntity>();
            foreach (ProductionType brand in Enum.GetValues(typeof(ProductionType)))
            {
                var dis = brand.GetDescriptionText();
                productionEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Production", Enums = productionEnums });

            repoClass.Add(enumClasses);
        }
    }
}
