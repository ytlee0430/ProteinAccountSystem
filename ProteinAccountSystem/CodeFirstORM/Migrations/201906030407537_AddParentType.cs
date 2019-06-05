namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddParentType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EnumEntities", "ParentType", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.EnumEntities", "ParentType");
        }
    }
}