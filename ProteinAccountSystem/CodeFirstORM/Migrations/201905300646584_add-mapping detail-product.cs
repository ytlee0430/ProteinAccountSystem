namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmappingdetailproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhuraseProducts",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(),
                        ProductName = c.String(),
                        Count = c.Int(nullable: false),
                        ProductMoney = c.Int(nullable: false),
                        ProductMoneyWithoutTax = c.Int(nullable: false),
                        PhuraseDetailEntityKey = c.Int(nullable: false),
                        Flavor = c.Int(nullable: false),
                        Brand = c.Int(nullable: false),
                        ProductionType = c.Int(nullable: false),
                        Package = c.Int(nullable: false),
                        ProductionDetailType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Key)
                .ForeignKey("dbo.PhuraseDetailEntities", t => t.PhuraseDetailEntityKey, cascadeDelete: true)
                .Index(t => t.PhuraseDetailEntityKey);
            
            DropColumn("dbo.PhuraseDetailEntities", "Products");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PhuraseDetailEntities", "Products", c => c.String());
            DropForeignKey("dbo.PhuraseProducts", "PhuraseDetailEntityKey", "dbo.PhuraseDetailEntities");
            DropIndex("dbo.PhuraseProducts", new[] { "PhuraseDetailEntityKey" });
            DropTable("dbo.PhuraseProducts");
        }
    }
}
