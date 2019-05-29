using AutoMapper;
using CodeFirstORM;
using CommonUtility.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {

        }
    }

    public class ModelToEntityProfile : Profile
    {
        public override string ProfileName => "ModelToEntityProfile";


        public static void Configure()
        {
            Mapper.Initialize(x => x.CreateMap<Item, ItemEntity>());
        } 
    }
}
