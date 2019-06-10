namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities");
            DropForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities");
            DropIndex("dbo.EnumEntities", new[] { "ForeignKey" });
            DropIndex("dbo.PhuraseProducts", new[] { "PhuraseDetailEntityKey" });
            DropPrimaryKey("dbo.EnumClassEntities");
            DropPrimaryKey("dbo.PhuraseDetailEntities");
            AlterColumn("dbo.EnumClassEntities", "Key", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EnumEntities", "ForeignKey", c => c.Int());
            AlterColumn("dbo.PhuraseDetailEntities", "Key", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.PhuraseProducts", "PhuraseDetailEntityKey", c => c.Int());
            AddPrimaryKey("dbo.EnumClassEntities", "Key");
            AddPrimaryKey("dbo.PhuraseDetailEntities", "Key");
            CreateIndex("dbo.EnumEntities", "ForeignKey");
            CreateIndex("dbo.PhuraseProducts", "PhuraseDetailEntityKey");
            AddForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities", "Key", cascadeDelete: true);
            AddForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities", "Key", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities");
            DropForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities");
            DropIndex("dbo.PhuraseProducts", new[] { "PhuraseDetailEntityKey" });
            DropIndex("dbo.EnumEntities", new[] { "ForeignKey" });
            DropPrimaryKey("dbo.PhuraseDetailEntities");
            DropPrimaryKey("dbo.EnumClassEntities");
            AlterColumn("dbo.PhuraseProducts", "PhuraseDetailEntityKey", c => c.Int(nullable: false));
            AlterColumn("dbo.PhuraseDetailEntities", "Key", c => c.Int(nullable: false));
            AlterColumn("dbo.EnumEntities", "ForeignKey", c => c.Int(nullable: false));
            AlterColumn("dbo.EnumClassEntities", "Key", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.PhuraseDetailEntities", "Key");
            AddPrimaryKey("dbo.EnumClassEntities", "Key");
            CreateIndex("dbo.PhuraseProducts", "PhuraseDetailEntityKey");
            CreateIndex("dbo.EnumEntities", "ForeignKey");
            AddForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities", "Key", cascadeDelete: true);
            AddForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities", "Key", cascadeDelete: true);
        }
    }
}
