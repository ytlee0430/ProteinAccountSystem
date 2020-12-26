using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Service.AutoMapper
{
    public class PhuraseModelEntityProfile : Profile
    {
        public PhuraseModelEntityProfile()
        {
            CreateMap<PhuraseProductModel, PhuraseProductEntity>();
        }
    }
}