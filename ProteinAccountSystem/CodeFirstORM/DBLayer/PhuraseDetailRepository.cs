using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CodeFirstORM.Entity;
using Common.Entity;
using Common.Enum;
using Newtonsoft.Json;

namespace CodeFirstORM.DBLayer
{
    public class PhuraseDetailRepository : RepositoryBase<PhuraseDetailEntity>
    {
        public PhuraseDetailRepository():base(new ProteinDB())
        {
        }
    }
}
