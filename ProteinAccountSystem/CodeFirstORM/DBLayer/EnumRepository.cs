using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;

namespace CodeFirstORM.DBLayer
{
    public class EnumRepository : RepositoryBase<EnumEntity>
    {
        public EnumRepository(): base(new ProteinDB())
        {
        }
    }
}
