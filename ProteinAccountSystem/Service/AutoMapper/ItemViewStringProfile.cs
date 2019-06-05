using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;
using CommonUtility.Enum;
using System.Linq;

namespace Service.AutoMapper
{
    public class ItemViewStringProfile : Profile
    {
        public ItemViewStringProfile()
        {
            CreateMap<ItemViewModel, ItemEntity>()
                .ForMember(i => i.Brand, o => o.MapFrom(y => Enums.BrandEnum.First(b => b.Value.Description == y.Brand).Key))
                .ForMember(i => i.Flavor, o => o.MapFrom(y => Enums.FlavorEnum.First(b => b.Value.Description == y.Flavor).Key))
                .ForMember(i => i.ProductionType, o => o.MapFrom(y => Enums.ProductionEnum.First(b => b.Value.Description == y.ProductionType).Key))
                .ForMember(i => i.ProductionDetailType, o => o.MapFrom(y => Enums.ProductionDetailEnum.First(b => b.Value.Description == y.ProductionDetailType).Key))
                .ForMember(i => i.Package, o => o.MapFrom(y => Enums.PackageEnum.First(b => b.Value.Description == y.Package).Key));
        }
    }
}