using ProteinSystem.Repository.Entity;
using ProteinSystem.Repository.RepositoryBase;

namespace ProteinSystem.Repository.DBLayer
{
    public class EnumRepository : RepositoryBase<EnumEntity>
    {
        public EnumRepository() : base(new ProteinDB())
        {
        }
    }
}