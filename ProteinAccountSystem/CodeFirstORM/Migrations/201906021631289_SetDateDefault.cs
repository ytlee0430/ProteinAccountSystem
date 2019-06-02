namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDateDefault : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ItemEntities", "ExpiredDate", c => c.DateTime(nullable: false, defaultValueSql: "GETUTCDATE()"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ItemEntities", "ExpiredDate", c => c.DateTime(nullable: false));
        }
    }
}
