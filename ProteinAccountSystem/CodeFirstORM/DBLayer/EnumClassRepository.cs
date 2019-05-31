﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.Entity;
using Newtonsoft.Json;

namespace CodeFirstORM.DBLayer
{
    public class EnumClassRepository : RepositoryBase<EnumClassEntity>
    {
        public EnumClassRepository(): base(new ProteinDB())
        {
        }
    }
}
