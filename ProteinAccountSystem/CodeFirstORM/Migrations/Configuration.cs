using System.Data.Entity.Migrations;

namespace ProteinSystem.Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProteinDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProteinDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}