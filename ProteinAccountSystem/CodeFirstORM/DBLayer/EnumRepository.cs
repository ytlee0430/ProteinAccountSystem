using CodeFirstORM.Entity;

namespace CodeFirstORM.DBLayer
{
    public class EnumRepository : RepositoryBase<EnumEntity>
    {
        public EnumRepository() : base(new ProteinDB())
        {
        }
    }
}