using CodeFirstORM.Entity;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseProductRepository : RepositoryBase<PhuraseProductEntity>
    {
        public PhuraseProductRepository() : base(new ProteinDB())
        {
        }
    }
}