namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class addenum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnumClassEntities",
                c => new
                {
                    Key = c.Int(nullable: false, identity: true),
                    EnumClassDescription = c.String(),
                })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.EnumEntities", t => t.Key)
                .Index(t => t.Key);

            CreateTable(
                "dbo.EnumEntities",
                c => new
                {
                    Key = c.Int(nullable: false, identity: true),
                    EnumValue = c.Int(nullable: false),
                    Description = c.String(),
                    KeyWord = c.String(),
                })
                .PrimaryKey(t => t.Key);
        }

        public override void Down()
        {
            DropForeignKey("dbo.EnumClassEntities", "Key", "dbo.EnumEntities");
            DropIndex("dbo.EnumClassEntities", new[] { "Key" });
            DropTable("dbo.EnumEntities");
            DropTable("dbo.EnumClassEntities");
        }
    }
}