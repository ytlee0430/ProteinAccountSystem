using System.ComponentModel.DataAnnotations;
using ProteinSystem.Repository.RepositoryBase;

namespace ProteinSystem.Repository.Entity
{
    public class EnumEntity : IEntity
    {
        [Key]
        public int Key { get; set; }

        public virtual EnumClassEntity EnumClass { get; set; }

        public int EnumValue { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string KeyWord { get; set; }

        public int? ForeignKey { get; set; }

        [Required]
        public int ParentType { get; set; }
    }
}