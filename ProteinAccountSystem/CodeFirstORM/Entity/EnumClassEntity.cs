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

        [Required]
        public string EnumClassDescription { get; set; }

        public virtual ICollection<EnumEntity> Enums { get; set; }
    }
}