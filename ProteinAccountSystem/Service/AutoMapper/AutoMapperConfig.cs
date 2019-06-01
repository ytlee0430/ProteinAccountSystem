using System.CodeDom;
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
                x.AddProfile<ItemViewProfile>();
                x.AddProfile<ItemViewStringProfile>();
            });

        }

        public static M Map<T, M>(T entity)
        {
            return Mapper.Map<M>(entity);
        }
    }
}
