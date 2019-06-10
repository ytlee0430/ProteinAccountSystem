namespace CodeFirstORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeynullable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PhuraseProducts", new[] { "PhuraseDetailEntityKey" });
            AlterColumn("dbo.PhuraseProducts", "PhuraseDetailEntityKey", c => c.Int());
            CreateIndex("dbo.PhuraseProducts", "PhuraseDetailEntityKey");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PhuraseProducts", new[] { "PhuraseDetailEntityKey" });
            AlterColumn("dbo.PhuraseProducts", "PhuraseDetailEntityKey", c => c.Int(nullable: false));
            CreateIndex("dbo.PhuraseProducts", "PhuraseDetailEntityKey");
        }
    }
}
