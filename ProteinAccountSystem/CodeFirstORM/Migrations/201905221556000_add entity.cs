namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addentity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Items", newName: "ItemEntities");
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
            RenameTable(name: "dbo.ItemEntities", newName: "Items");
        }
    }
}
