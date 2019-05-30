using AutoMapper;

namespace Service.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ItemProfile>();
                x.AddProfile<PhuraseDetailEntityProfile>();
                x.AddProfile<PhuraseModelEntityProfile>();
            });

        }
    }
}
