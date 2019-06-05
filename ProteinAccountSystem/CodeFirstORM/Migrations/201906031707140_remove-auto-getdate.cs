namespace CodeFirstORM.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class removeautogetdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhuraseDetailEntities", "OrderCreateTime", c => c.DateTime(nullable: false, defaultValueSql: ""));
        }

        public override void Down()
        {
            AlterColumn("dbo.PhuraseDetailEntities", "OrderCreateTime", c => c.DateTime(nullable: false));
        }
    }
}