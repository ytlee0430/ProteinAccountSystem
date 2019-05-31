using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.RepositoryBase;

namespace CodeFirstORM.Entity
{
    public class EnumClassEntity : IEntity
    {
        [Key]
        public int Key { get; set; }

        public string EnumClassDescription { get; set; }

        public ICollection<EnumEntity> Enums{ get; set; }
    }
}
