using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProteinSystem.Repository.RepositoryBase;

namespace ProteinSystem.Repository.Entity
{
    public class EnumClassEntity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Key { get; set; }

        [Required]
        public string EnumClassDescription { get; set; }

        public virtual ICollection<EnumEntity> Enums { get; set; }
    }
}