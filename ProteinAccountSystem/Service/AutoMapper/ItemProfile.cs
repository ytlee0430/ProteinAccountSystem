using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;

namespace Service.AutoMapper
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemEntity>();
        }
    }
}