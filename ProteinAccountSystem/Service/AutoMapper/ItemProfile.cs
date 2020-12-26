using AutoMapper;
using ProteinSystem.Entity;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Service.AutoMapper
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemEntity>();
        }
    }
}