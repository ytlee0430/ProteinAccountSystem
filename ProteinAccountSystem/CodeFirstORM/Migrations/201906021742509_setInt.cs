namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class setInt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities");
            DropPrimaryKey("dbo.PhuraseDetailEntities");
            AlterColumn("dbo.PhuraseDetailEntities", "Key", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PhuraseDetailEntities", "Key");
            AddForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities", "Key", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities");
            DropPrimaryKey("dbo.PhuraseDetailEntities");
            AlterColumn("dbo.PhuraseDetailEntities", "Key", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PhuraseDetailEntities", "Key");
            AddForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities", "Key", cascadeDelete: true);
        }
    }
}