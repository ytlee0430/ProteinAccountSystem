using AutoMapper;

namespace CodeFirstORM.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ItemProfile>();
                x.AddProfile<PhuraseDetailEntityProfile>();
            });

        }
    }
}
