namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class additemdetia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemEntities", "ProductionDetailType", c => c.Int(nullable: false));
            AddColumn("dbo.PhuraseDetailEntities", "Remark", c => c.String());
            AddColumn("dbo.PhuraseDetailEntities", "ReceiptNumber", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.PhuraseDetailEntities", "ReceiptNumber");
            DropColumn("dbo.PhuraseDetailEntities", "Remark");
            DropColumn("dbo.ItemEntities", "ProductionDetailType");
        }
    }
}