namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockForMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Stock", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Stock");
        }
    }
}
