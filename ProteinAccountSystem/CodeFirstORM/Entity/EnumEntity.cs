using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.RepositoryBase;
using Common.Enum;

namespace CodeFirstORM.Entity
{
    public class EnumEntity : IEntity
    {
        [Key]
        public int Key { get; set; }

        public int EnumClass { get; set; }

        public int EnumValue { get; set; }

        public string Description { get; set; }

        public string KeyWord { get; set; }

    }
}
