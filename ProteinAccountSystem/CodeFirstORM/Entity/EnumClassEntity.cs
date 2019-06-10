using CodeFirstORM.RepositoryBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstORM.Entity
{
    public class EnumClassEntity : IEntity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Key { get; set; }

        public string EnumClassDescription { get; set; }

        public ICollection<EnumEntity> Enums { get; set; }
    }
}