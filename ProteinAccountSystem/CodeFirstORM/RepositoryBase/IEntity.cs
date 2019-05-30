using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM.RepositoryBase
{
    public interface IEntity
    {
        int Key { get; set; }
    }
}
