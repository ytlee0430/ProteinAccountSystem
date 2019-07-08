namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhuraseDetailEntities", "RecipientName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhuraseDetailEntities", "RecipientName");
        }
    }
}