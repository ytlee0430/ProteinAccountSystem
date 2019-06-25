namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class expireadate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemEntities", "ExpiredDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemEntities", "ExpiredDate", c => c.DateTime(nullable: false));
        }
    }
}
