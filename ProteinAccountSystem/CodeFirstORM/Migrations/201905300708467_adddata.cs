namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItemEntities", "ProductName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItemEntities", "ProductName");
        }
    }
}
