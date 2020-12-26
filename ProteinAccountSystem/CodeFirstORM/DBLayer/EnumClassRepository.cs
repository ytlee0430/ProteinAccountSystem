using ProteinSystem.Repository.Entity;
using ProteinSystem.Repository.RepositoryBase;

namespace ProteinSystem.Repository.DBLayer
{
    public class EnumClassRepository : RepositoryBase<EnumClassEntity>
    {
        private readonly object _lock = new object();

        public EnumClassRepository() : base(new ProteinDB())
        {
        }
    }
}