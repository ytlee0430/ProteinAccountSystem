namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class time : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhuraseDetailEntities", "WriteOffMoneyTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhuraseDetailEntities", "WriteOffMoneyTime");
        }
    }
}
