namespace Videl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsubscribe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribeToNewsLetter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribeToNewsLetter");
        }
    }
}
