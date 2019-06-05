using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;

namespace Service.AutoMapper
{
    public class EnumProfile : Profile
    {
        public EnumProfile()
        {
            CreateMap<EnumModel, EnumEntity>();
        }
    }
}