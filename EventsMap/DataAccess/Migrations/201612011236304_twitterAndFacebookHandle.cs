namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class twitterAndFacebookHandle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "TwitterHandle", c => c.String());
            AddColumn("dbo.Companies", "FacebookWebsite", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "FacebookWebsite");
            DropColumn("dbo.Companies", "TwitterHandle");
        }
    }
}
