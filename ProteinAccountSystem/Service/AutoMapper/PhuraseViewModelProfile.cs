using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Enum;

namespace ProteinSystem.Service.AutoMapper
{
    public class PhuraseViewModelProfile : Profile
    {
        public PhuraseViewModelProfile()
        {
            CreateMap<PhuraseProductModel, PhuraseProductViewModel>()
                .ForMember(i => i.Brand, o => o.MapFrom(y => Enums.BrandEnum[y.Brand].Description))
                .ForMember(i => i.Flavor, o => o.MapFrom(y => Enums.FlavorEnum[y.Flavor].Description))
                .ForMember(i => i.ProductionType, o => o.MapFrom(y => Enums.ProductionEnum[y.ProductionType].Description))
                .ForMember(i => i.ProductionDetailType, o => o.MapFrom(y => Enums.ProductionDetailEnum[y.ProductionDetailType].Description))
                .ForMember(i => i.Package, o => o.MapFrom(y => Enums.PackageEnum[y.Package].Description));
        }
    }
}