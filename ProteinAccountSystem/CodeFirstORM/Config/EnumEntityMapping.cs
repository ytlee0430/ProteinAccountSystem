using System.Data.Entity.ModelConfiguration;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Repository.Config
{
    public class EnumEntityMapping : EntityTypeConfiguration<EnumEntity>
    {
        public EnumEntityMapping()
        {
            ToTable("EnumEntities");
            HasOptional(x => x.EnumClass).WithMany(s => s.Enums)
                .HasForeignKey(x => x.ForeignKey).WillCascadeOnDelete(true);

        }
    }
}