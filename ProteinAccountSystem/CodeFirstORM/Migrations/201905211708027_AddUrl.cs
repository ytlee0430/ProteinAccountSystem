namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Items");
        }
    }
}
