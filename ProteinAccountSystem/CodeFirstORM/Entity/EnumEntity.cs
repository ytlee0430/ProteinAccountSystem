using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstORM.RepositoryBase;

namespace CodeFirstORM.Entity
{
    public class EnumEntity : IEntity
    {
        [Key]
        public int Key { get; set; }

        public EnumClassEntity EnumClass { get; set; }

        public int EnumValue { get; set; }

        public string Description { get; set; }

        public string KeyWord { get; set; }

        public int ForeignKey { get; set; }

        [Required]
        public int ParentType { get; set; }
    }
}
