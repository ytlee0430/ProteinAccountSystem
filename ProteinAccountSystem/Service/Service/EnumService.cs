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


        public static void EnumInitialize()
        {
            var repo = new EnumRepository();
            var enumEntitis = repo.GetAll();
            foreach (var enumEntity in enumEntitis)
            {
                switch (enumEntity.EnumClass.EnumClassDescription)
                {
                    case "Brand":
                        BrandEnum.Add(enumEntity.EnumValue, new EnumModel { Description = enumEntity.Description, EnumValue = enumEntity.EnumValue, KeyWord = enumEntity.KeyWord });
                        break;
                    case "Flavor":
                        FlavorEnum.Add(enumEntity.EnumValue, new EnumModel { Description = enumEntity.Description, EnumValue = enumEntity.EnumValue, KeyWord = enumEntity.KeyWord });
                        break;
                    case "Package":
                        PackageEnum.Add(enumEntity.EnumValue, new EnumModel { Description = enumEntity.Description, EnumValue = enumEntity.EnumValue, KeyWord = enumEntity.KeyWord });
                        break;
                    case "Plat":
                        PlatEnum.Add(enumEntity.EnumValue, new EnumModel { Description = enumEntity.Description, EnumValue = enumEntity.EnumValue, KeyWord = enumEntity.KeyWord });
                        break;
                    case "ProductionDetail":
                        ProductionDetailEnum.Add(enumEntity.EnumValue, new EnumModel { Description = enumEntity.Description, EnumValue = enumEntity.EnumValue, KeyWord = enumEntity.KeyWord });
                        break;
                    case "Production":
                        ProductionEnum.Add(enumEntity.EnumValue, new EnumModel { Description = enumEntity.Description, EnumValue = enumEntity.EnumValue, KeyWord = enumEntity.KeyWord });
                        break;
                    default:
                        break;
                }
            }
        }

        public static void UpdateDatabase()
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
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Plat" ,Enums = platEnums});

            var productionDetailEnums = new List<EnumEntity>();
            foreach (ProductionDetail brand in Enum.GetValues(typeof(ProductionDetail)))
            {
                var dis = brand.GetDescriptionText();
                productionDetailEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "ProductionDetail", Enums = productionDetailEnums});

            var productionEnums = new List<EnumEntity>();
            foreach (ProductionType brand in Enum.GetValues(typeof(ProductionType)))
            {
                var dis = brand.GetDescriptionText();
                productionEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Production" , Enums = productionEnums });

            repoClass.Add(enumClasses);
        }
    }
}
