namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemEntities", "Package", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.ItemEntities", "Package");
        }
    }
}