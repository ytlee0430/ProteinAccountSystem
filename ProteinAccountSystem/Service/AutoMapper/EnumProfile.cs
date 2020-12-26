using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Service.AutoMapper
{
    public class EnumProfile : Profile
    {
        public EnumProfile()
        {
            CreateMap<EnumModel, EnumEntity>();
        }
    }
}