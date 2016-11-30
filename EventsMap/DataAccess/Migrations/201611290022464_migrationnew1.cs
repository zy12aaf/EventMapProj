namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationnew1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "Latitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Locations", "Longtitude", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "Longtitude", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Locations", "Latitude", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
