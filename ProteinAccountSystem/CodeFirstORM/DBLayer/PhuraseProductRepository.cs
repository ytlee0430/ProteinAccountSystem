using ProteinSystem.Repository.Entity;
using ProteinSystem.Repository.RepositoryBase;

namespace ProteinSystem.Repository.DBLayer
{
    public class PhuraseProductRepository : RepositoryBase<PhuraseProductEntity>
    {
        public PhuraseProductRepository() : base(new ProteinDB())
        {
        }
    }
}