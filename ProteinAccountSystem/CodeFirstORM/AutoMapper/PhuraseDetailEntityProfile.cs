using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;
using Newtonsoft.Json;

namespace CodeFirstORM.AutoMapper
{
    public class PhuraseDetailEntityProfile : Profile
    {
        public PhuraseDetailEntityProfile()
        {
           var map =  CreateMap<PhuraseDetailModel, PhuraseDetailEntity>();
            map.ForMember(x => x.Products, y => y.MapFrom(p => JsonConvert.SerializeObject(p.Products)));
        }
    }
}