﻿using System;
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

        public static void EnumParentTypeInitail()
        {
            var repo = new EnumClassRepository();
            var enumEntitis = repo.GetAll();
            foreach (var enumEntity in enumEntitis)
            {
                switch (enumEntity.EnumClassDescription)
                {
                    case "Brand":
                        break;
                    case "Flavor":
                        foreach (var item in enumEntity.Enums)
                        {
                            switch ((FlavorEnum)item.EnumValue)
                            {
                                case FlavorEnum.BlueCheeseCake:
                                case FlavorEnum.StrawberryButter:
                                case FlavorEnum.CaramelSalt:
                                case FlavorEnum.NaturalChocolate:
                                case FlavorEnum.ChocolateBrownie:
                                case FlavorEnum.NaturalStrawberry:
                                case FlavorEnum.MintChocolate:
                                case FlavorEnum.SmoothChocolate:
                                case FlavorEnum.MilkTea:
                                case FlavorEnum.ChocolatePeanutButter:
                                case FlavorEnum.UnFlavor:
                                case FlavorEnum.ChocolateNut:
                                case FlavorEnum.Latte:
                                case FlavorEnum.Banana:
                                case FlavorEnum.Vanilla:
                                case FlavorEnum.NaturalVanilla:
                                case FlavorEnum.Mocha:
                                case FlavorEnum.Matcha:
                                case FlavorEnum.CaramelChocolate:
                                case FlavorEnum.ChocolateBanana:
                                case FlavorEnum.HokkaidoMiik:
                                case FlavorEnum.Strawberry:
                                case FlavorEnum.Coffee:
                                case FlavorEnum.Chocalate:
                                    item.ParentType = 1;
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "Package":
                        foreach (var item in enumEntity.Enums)
                        {
                            switch ((PackageEnum)item.EnumValue)
                            {
                                case PackageEnum.OneKg:
                                case PackageEnum.TwoHalfKg:
                                case PackageEnum.FiveKg:
                                case PackageEnum.Sample:
                                    item.ParentType = 1;
                                    break;
                                case PackageEnum.FourHundredMili:
                                case PackageEnum.SixHundredMili:
                                case PackageEnum.NoPackage:
                                    item.ParentType = 3;
                                    break;
                                case PackageEnum.XS:
                                case PackageEnum.S:
                                case PackageEnum.M:
                                case PackageEnum.L:
                                case PackageEnum.XL:
                                    item.ParentType = 2;
                                    break;
                            }
                        }
                        break;
                    case "Plat":
                        break;
                    case "ProductionDetail":
                        foreach (var item in enumEntity.Enums)
                        {
                            switch ((ProductionDetail)item.EnumValue)
                            {
                                case ProductionDetail.WheyProtein:
                                case ProductionDetail.IsolateWheyProtein:
                                case ProductionDetail.IsolateSoyProtein:
                                    item.ParentType = 1;
                                    break;

                                case ProductionDetail.Belt:
                                case ProductionDetail.PowerliftingBelt:
                                case ProductionDetail.LowClassGloves:
                                case ProductionDetail.MiddleClassGloves:
                                case ProductionDetail.HighClassGloves:
                                case ProductionDetail.GymReverseHookStrap:
                                case ProductionDetail.GymStrapGel:
                                case ProductionDetail.GymProHook:
                                case ProductionDetail.GymWristWrap:
                                case ProductionDetail.Grip:
                                    item.ParentType = 2;
                                    break;
                                case ProductionDetail.ProteinOatBar:
                                case ProductionDetail.ChocalateBrownie:
                                case ProductionDetail.PeanutButter:
                                case ProductionDetail.AlmondButter:
                                case ProductionDetail.MyBarZero:
                                case ProductionDetail.Sharker:
                                case ProductionDetail.SteelSharker:
                                case ProductionDetail.BCAA:
                                case ProductionDetail.Cookie:
                                    item.ParentType = 3;
                                    break;
                                default:
                                    item.ParentType = 3;
                                    break;
                            }
                        }
                        break;
                    case "Production":
                        break;
                    default:
                        break;
                }
            }
            repo.Update(enumEntitis);
        }


    }
}
