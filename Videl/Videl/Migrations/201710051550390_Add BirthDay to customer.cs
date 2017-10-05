namespace Videl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDaytocustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDay", c => c.DateTime());
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MemberShipTypes", "Name", c => c.String());
            DropColumn("dbo.Customers", "BirthDay");
        }
    }
}
