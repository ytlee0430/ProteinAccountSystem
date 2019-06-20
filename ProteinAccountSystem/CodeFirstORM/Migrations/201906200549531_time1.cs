namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class time1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhuraseDetailEntities", "WriteOffMoneyTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhuraseDetailEntities", "WriteOffMoneyTime", c => c.DateTime(nullable: false));
        }
    }
}
