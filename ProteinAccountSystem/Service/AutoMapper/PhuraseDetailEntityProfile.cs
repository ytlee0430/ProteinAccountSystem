using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Service.AutoMapper
{
    public class PhuraseDetailEntityProfile : Profile
    {
        public PhuraseDetailEntityProfile()
        {
            CreateMap<PhuraseDetailModel, PhuraseDetailEntity>();
        }
    }
}