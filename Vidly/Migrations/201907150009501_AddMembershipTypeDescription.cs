namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class AddMembershipTypeDescription : DbMigration
	{
		public override void Up()
		{
			AddColumn("dbo.MembershipTypes", "Description", c => c.String(maxLength: 100));
			Sql("UPDATE dbo.MembershipTypes SET Description='Pay as you go' WHERE ID=1");
			Sql("UPDATE dbo.MembershipTypes SET Description='Monthly' WHERE ID=2");
			Sql("UPDATE dbo.MembershipTypes SET Description='Cuarterly' WHERE ID=3");
			Sql("UPDATE dbo.MembershipTypes SET Description='Yearly' WHERE ID=4");
		}

		public override void Down()
		{
			DropColumn("dbo.MembershipTypes", "Description");
		}
	}
}
