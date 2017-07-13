namespace SampleMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "Rating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
            DropColumn("dbo.Movies", "Price");
        }
    }
}
