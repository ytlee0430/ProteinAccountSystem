using CodeFirstORM.RepositoryBase;
using System.ComponentModel.DataAnnotations;

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

        public int? ForeignKey { get; set; }

        [Required]
        public int ParentType { get; set; }
    }
}