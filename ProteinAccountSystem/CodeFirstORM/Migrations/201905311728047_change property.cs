namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeproperty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities");
            DropPrimaryKey("dbo.EnumClassEntities");
            AlterColumn("dbo.EnumClassEntities", "Key", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.EnumClassEntities", "Key");
            AddForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities", "Key", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities");
            DropPrimaryKey("dbo.EnumClassEntities");
            AlterColumn("dbo.EnumClassEntities", "Key", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EnumClassEntities", "Key");
            AddForeignKey("dbo.EnumEntities", "ForeignKey", "dbo.EnumClassEntities", "Key", cascadeDelete: true);
        }
    }
}
