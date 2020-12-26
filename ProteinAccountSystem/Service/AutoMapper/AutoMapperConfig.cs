using AutoMapper;

namespace ProteinSystem.Service.AutoMapper
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
                x.AddProfile<ItemViewProfile>();
                x.AddProfile<ItemViewStringProfile>();
                x.AddProfile<EnumProfile>();
                x.AddProfile<PhuraseViewModelProfile>();
            });
        }

        public static TR Map<T, TR>(T entity)
        {
            return Mapper.Map<TR>(entity);
        }
    }
}