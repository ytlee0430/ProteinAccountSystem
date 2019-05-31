namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enumclassmapping : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EnumClassEntities", "Key", "dbo.EnumEntities");
            DropIndex("dbo.EnumClassEntities", new[] { "Key" });
            DropPrimaryKey("dbo.EnumClassEntities");
            AddColumn("dbo.EnumEntities", "ForeignKey", c => c.Int(nullable: false));
            AlterColumn("dbo.EnumClassEntities", "Key", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EnumClassEntities", "Key");
            CreateIndex("dbo.EnumEntities", "ForeignKey");
            AddForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities", "Key", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities");
            DropIndex("dbo.EnumEntities", new[] { "ForeignKey" });
            DropPrimaryKey("dbo.EnumClassEntities");
            AlterColumn("dbo.EnumClassEntities", "Key", c => c.Int(nullable: false));
            DropColumn("dbo.EnumEntities", "ForeignKey");
            AddPrimaryKey("dbo.EnumClassEntities", "Key");
            CreateIndex("dbo.EnumClassEntities", "Key");
            AddForeignKey("dbo.EnumClassEntities", "Key", "dbo.EnumEntities", "Key");
        }
    }
}
