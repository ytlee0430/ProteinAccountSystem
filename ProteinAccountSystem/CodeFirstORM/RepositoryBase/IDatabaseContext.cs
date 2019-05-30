﻿using CodeFirstORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstORM.RepositoryBase
{
    public interface IDatabaseContext
    {
        IDbSet<ItemEntity> Items { get; set; }
        IDbSet<PhuraseDetailEntity> PhuraseDetails { get; set; }
        IDbSet<PhuraseProductEntity> PhuraseProducts { get; set; }

        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        int SaveChanges();
    }
}
