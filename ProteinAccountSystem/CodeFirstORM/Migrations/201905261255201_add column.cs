namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhuraseProductEntities", "ItemCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhuraseProductEntities", "ItemCode");
        }
    }
}
