using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;

namespace Service.AutoMapper
{
    public class PhuraseDetailEntityProfile : Profile
    {
        public PhuraseDetailEntityProfile()
        {
            CreateMap<PhuraseDetailModel, PhuraseDetailEntity>();
        }
    }
}