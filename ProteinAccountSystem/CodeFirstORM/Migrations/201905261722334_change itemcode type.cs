namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeitemcodetype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhuraseProductEntities", "ItemCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhuraseProductEntities", "ItemCode", c => c.String());
        }
    }
}
