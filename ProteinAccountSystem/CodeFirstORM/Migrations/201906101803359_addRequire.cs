namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRequire : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EnumClassEntities", "EnumClassDescription", c => c.String(nullable: false));
            AlterColumn("dbo.EnumEntities", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.EnumEntities", "KeyWord", c => c.String(nullable: false));
            AlterColumn("dbo.PhuraseProducts", "ItemCode", c => c.String(nullable: false));
            AlterColumn("dbo.PhuraseProducts", "ProductName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhuraseProducts", "ProductName", c => c.String());
            AlterColumn("dbo.PhuraseProducts", "ItemCode", c => c.String());
            AlterColumn("dbo.EnumEntities", "KeyWord", c => c.String());
            AlterColumn("dbo.EnumEntities", "Description", c => c.String());
            AlterColumn("dbo.EnumClassEntities", "EnumClassDescription", c => c.String());
        }
    }
}
