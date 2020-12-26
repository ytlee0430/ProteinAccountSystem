using System.Data.Entity.ModelConfiguration;
using ProteinSystem.Repository.Entity;

namespace ProteinSystem.Repository.Config
{
    public class PhuraseProductEntityMapping : EntityTypeConfiguration<PhuraseProductEntity>
    {
        public PhuraseProductEntityMapping()
        {
            ToTable("PhuraseProducts");
            HasOptional(x => x.PhuraseDetail).WithMany(s => s.Products)
                .HasForeignKey(x => x.PhuraseDetailEntityKey).WillCascadeOnDelete(true);
        }
    }
}