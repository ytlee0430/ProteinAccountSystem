using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;

namespace CodeFirstORM.AutoMapper
{
    public class PhuraseDetailEntityProfile : Profile
    {
        public PhuraseDetailEntityProfile()
        {
           CreateMap<PhuraseDetailModel, PhuraseDetailEntity>();
        }
    }
}