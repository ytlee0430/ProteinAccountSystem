namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhuraseDetailEntities", "OrderCreateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.PhuraseDetailEntities", "Manager", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhuraseDetailEntities", "Manager");
            DropColumn("dbo.PhuraseDetailEntities", "OrderCreateTime");
        }
    }
}
