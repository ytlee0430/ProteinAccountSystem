namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Addcompanydata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhuraseDetailEntities", "CompanyName", c => c.String());
            AddColumn("dbo.PhuraseDetailEntities", "CompanyInvoiceNumber", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.PhuraseDetailEntities", "CompanyInvoiceNumber");
            DropColumn("dbo.PhuraseDetailEntities", "CompanyName");
        }
    }
}