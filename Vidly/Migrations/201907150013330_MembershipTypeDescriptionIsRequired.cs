namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MembershipTypeDescriptionIsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Description", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Description", c => c.String(maxLength: 100));
        }
    }
}
