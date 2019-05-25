namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemEntities",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Storage = c.Int(nullable: false),
                        ItemCode = c.Int(nullable: false),
                        Flavor = c.Int(nullable: false),
                        Brand = c.Int(nullable: false),
                        ProductionType = c.Int(nullable: false),
                        NetPrice = c.Int(nullable: false),
                        Discount = c.Double(nullable: false),
                        Cost = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.PhuraseDetailEntities",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        OrderNumber = c.String(),
                        Account = c.String(),
                        DeliveryNumber = c.String(),
                        TransferMoney = c.Int(nullable: false),
                        Products = c.String(),
                        TransferMoneyWithoutTax = c.Int(nullable: false),
                        TotalTax = c.Int(nullable: false),
                        TotalMoney = c.Int(nullable: false),
                        Plat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.PhuraseProductEntities",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Count = c.Int(nullable: false),
                        ProductMoney = c.Int(nullable: false),
                        ProductMoneyWithoutTax = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhuraseProductEntities");
            DropTable("dbo.PhuraseDetailEntities");
            DropTable("dbo.ItemEntities");
        }
    }
}
