using System;
using System.Collections.Generic;
using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Enum;
using ProteinSystem.Repository.DBLayer;
using ProteinSystem.Repository.Entity;
using ProteinSystem.Utils;

namespace ProteinSystem.Service
{
    public class DataBaseInitializer
    {
        public static void InitailizeEnumDatabase()
        {
            var repoClass = new EnumClassRepository();
            List<EnumClassEntity> enumClasses = new List<EnumClassEntity>();
            var brandEnums = new List<EnumEntity>();
            foreach (BrandEnum brand in System.Enum.GetValues(typeof(BrandEnum)))
            {
                var dis = brand.GetDescriptionText();
                brandEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Brand", Enums = brandEnums });

            var flavorEnums = new List<EnumEntity>();
            foreach (FlavorEnum brand in System.Enum.GetValues(typeof(FlavorEnum)))
            {
                var dis = brand.GetDescriptionText();
                flavorEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Flavor", Enums = flavorEnums });

            var packageEnums = new List<EnumEntity>();
            foreach (PackageEnum brand in System.Enum.GetValues(typeof(PackageEnum)))
            {
                var dis = brand.GetDescriptionText();
                packageEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Package", Enums = packageEnums });

            var platEnums = new List<EnumEntity>();
            foreach (PlatEnum brand in System.Enum.GetValues(typeof(PlatEnum)))
            {
                var dis = brand.GetDescriptionText();
                platEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Plat", Enums = platEnums });

            var productionDetailEnums = new List<EnumEntity>();
            foreach (ProductionDetail brand in System.Enum.GetValues(typeof(ProductionDetail)))
            {
                var dis = brand.GetDescriptionText();
                productionDetailEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "ProductionDetail", Enums = productionDetailEnums });

            var productionEnums = new List<EnumEntity>();
            foreach (ProductionType brand in System.Enum.GetValues(typeof(ProductionType)))
            {
                var dis = brand.GetDescriptionText();
                productionEnums.Add(new EnumEntity { Description = dis, EnumValue = (int)brand, KeyWord = dis });
            }
            enumClasses.Add(new EnumClassEntity { EnumClassDescription = "Production", Enums = productionEnums });

            repoClass.Add(enumClasses);
        }

        public static void InitializeItemsDataBase()
        {
            var repo = new ItemRepository();
            var insertLsit = new List<ItemEntity>();
            var item = new ItemEntity
            {
                Brand = (int)BrandEnum.EatMe,
                Flavor = (int)FlavorEnum.Chocalate,
                ExpiredDate = new DateTime(2020, 4, 30),
                Cost = 550,
                NetPrice = 750,
                Package = (int)PackageEnum.OneKg,
                ProductionType = (int)ProductionType.WheyProtein,
                ProductionDetailType = (int)ProductionDetail.WheyProtein,
                Storage = 10,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
            insertLsit.Add(item);

            item = new ItemEntity
            {
                Brand = (int)BrandEnum.EatMe,
                Flavor = (int)FlavorEnum.Banana,
                ExpiredDate = new DateTime(2020, 4, 30),
                Cost = 550,
                NetPrice = 750,
                Package = (int)PackageEnum.OneKg,
                ProductionType = (int)ProductionType.WheyProtein,
                ProductionDetailType = (int)ProductionDetail.WheyProtein,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
            insertLsit.Add(item);

            item = new ItemEntity
            {
                Brand = (int)BrandEnum.EatMe,
                Flavor = (int)FlavorEnum.Vanilla,
                ExpiredDate = new DateTime(2020, 4, 30),
                Cost = 550,
                NetPrice = 750,
                Package = (int)PackageEnum.OneKg,
                ProductionType = (int)ProductionType.WheyProtein,
                ProductionDetailType = (int)ProductionDetail.WheyProtein,
                Storage = 10,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
            insertLsit.Add(item);

            item = new ItemEntity
            {
                Brand = (int)BrandEnum.EatMe,
                Flavor = (int)FlavorEnum.Coffee,
                ExpiredDate = new DateTime(2020, 4, 30),
                Cost = 550,
                NetPrice = 750,
                Package = (int)PackageEnum.OneKg,
                ProductionType = (int)ProductionType.WheyProtein,
                ProductionDetailType = (int)ProductionDetail.WheyProtein,
                Storage = 10,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
            insertLsit.Add(item);

            item = new ItemEntity
            {
                Brand = (int)BrandEnum.EatMe,
                Flavor = (int)FlavorEnum.UnFlavor,
                ExpiredDate = new DateTime(2020, 4, 30),
                Cost = 550,
                NetPrice = 750,
                Package = (int)PackageEnum.OneKg,
                ProductionType = (int)ProductionType.WheyProtein,
                ProductionDetailType = (int)ProductionDetail.WheyProtein,
                Storage = 10,
            };
            item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
            insertLsit.Add(item);

            foreach (FlavorEnum flavor in System.Enum.GetValues(typeof(FlavorEnum)))
            {
                if (flavor == FlavorEnum.Chocalate)
                    continue;
                item = new ItemEntity
                {
                    Brand = (int)BrandEnum.Myprotein,
                    Flavor = (int)flavor,
                    ExpiredDate = new DateTime(2020, 4, 30),
                    Cost = 450,
                    NetPrice = 750,
                    Package = (int)PackageEnum.OneKg,
                    ProductionType = (int)ProductionType.WheyProtein,
                    ProductionDetailType = (int)ProductionDetail.WheyProtein,
                    Storage = 10,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
                insertLsit.Add(item);
            }

            foreach (FlavorEnum flavor in System.Enum.GetValues(typeof(FlavorEnum)))
            {
                if (flavor == FlavorEnum.Chocalate)
                    continue;
                item = new ItemEntity
                {
                    Brand = (int)BrandEnum.Myprotein,
                    Flavor = (int)flavor,
                    ExpiredDate = new DateTime(2020, 4, 30),
                    Cost = 950,
                    NetPrice = 1450,
                    Package = (int)PackageEnum.TwoHalfKg,
                    ProductionType = (int)ProductionType.WheyProtein,
                    ProductionDetailType = (int)ProductionDetail.WheyProtein,
                    Storage = 10,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
                insertLsit.Add(item);
            }

            foreach (FlavorEnum flavor in System.Enum.GetValues(typeof(FlavorEnum)))
            {
                if (flavor == FlavorEnum.Chocalate)
                    continue;
                item = new ItemEntity
                {
                    Brand = (int)BrandEnum.Myprotein,
                    Flavor = (int)flavor,
                    ExpiredDate = new DateTime(2020, 4, 30),
                    Cost = 1900,
                    NetPrice = 2550,
                    Package = (int)PackageEnum.FiveKg,
                    ProductionType = (int)ProductionType.WheyProtein,
                    ProductionDetailType = (int)ProductionDetail.WheyProtein,
                    Storage = 10,
                };
                item.ItemCode = ProductUtilities.GetItemCodes(Mapper.Map<Item>(item));
                insertLsit.Add(item);
            }

            repo.Add(insertLsit);
        }
    }
}