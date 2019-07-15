namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;

	public partial class PopulateGenres : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO dbo.Genres(Description) VALUES ('Comedy')");
			Sql("INSERT INTO dbo.Genres(Description) VALUES ('Action')");
			Sql("INSERT INTO dbo.Genres(Description) VALUES ('Family')");
			Sql("INSERT INTO dbo.Genres(Description) VALUES ('Horror')");
			Sql("INSERT INTO dbo.Genres(Description) VALUES ('Romance')");
			Sql("INSERT INTO dbo.Genres(Description) VALUES ('Fantasy')");
		}

		public override void Down()
		{
		}
	}
}
