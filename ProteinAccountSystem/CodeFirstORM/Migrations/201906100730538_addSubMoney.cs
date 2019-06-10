namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubMoney : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhuraseDetailEntities", "SubMoney", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhuraseDetailEntities", "SubMoney");
        }
    }
}
