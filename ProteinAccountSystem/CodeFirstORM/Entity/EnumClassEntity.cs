using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.RepositoryBase;

namespace CodeFirstORM.Entity
{
    public class EnumClassEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Key { get; set; }

        public string EnumClassDescription { get; set; }

        public ICollection<EnumEntity> Enums{ get; set; }
    }
}
