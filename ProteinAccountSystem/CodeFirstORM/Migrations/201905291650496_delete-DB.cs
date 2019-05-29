namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteDB : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.PhuraseProductEntities");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PhuraseProductEntities",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        ItemCode = c.Int(nullable: false),
                        ProductName = c.String(),
                        Count = c.Int(nullable: false),
                        ProductMoney = c.Int(nullable: false),
                        ProductMoneyWithoutTax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Key);
            
        }
    }
}
