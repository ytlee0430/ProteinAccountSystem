using CodeFirstORM.Entity;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirstORM.Config
{
    public class PhuraseProductEntityMapping : EntityTypeConfiguration<PhuraseProductEntity>
    {
        public PhuraseProductEntityMapping()
        {
            ToTable("PhuraseProducts");
            HasRequired(x => x.PhuraseDetail).WithMany(s => s.Products).HasForeignKey(x => x.PhuraseDetailEntityKey).WillCascadeOnDelete(true);
        }
    }
}