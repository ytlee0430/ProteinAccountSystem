﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseProductRepository : RepositoryBase<PhuraseProductEntity>
    {
        public PhuraseProductRepository(): base(new ProteinDB())
        {
        }
    }
}
