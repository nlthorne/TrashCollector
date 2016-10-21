namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class geesus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pickup_Times", "VacationStart", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pickup_Times", "VacationEnd", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pickup_Times", "VacationEnd");
            DropColumn("dbo.Pickup_Times", "VacationStart");
        }
    }
}
