using CodeFirstORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CodeFirstORM.DBLayer
{
    public class EnumClassRepository : RepositoryBase<EnumClassEntity>
    {
        private readonly object _lock = new object();

        public EnumClassRepository() : base(new ProteinDB())
        {
        }
    }
}