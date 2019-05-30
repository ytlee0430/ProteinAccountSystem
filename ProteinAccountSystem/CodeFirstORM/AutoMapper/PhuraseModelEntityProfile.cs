using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;

namespace CodeFirstORM.AutoMapper
{
    public class PhuraseModelEntityProfile : Profile
    {
        public PhuraseModelEntityProfile()
        {
            CreateMap<PhuraseProductModel, PhuraseProductEntity>();
        }
    }
}