namespace VinylShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Carts", "CustomerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carts", "CustomerID", c => c.Int(nullable: false));
        }
    }
}
