namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addexpireddate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemEntities", "ExpiredDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ItemEntities", "ItemCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemEntities", "ItemCode", c => c.Int(nullable: false));
            DropColumn("dbo.ItemEntities", "ExpiredDate");
        }
    }
}
