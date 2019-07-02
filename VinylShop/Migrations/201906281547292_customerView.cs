namespace VinylShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customerView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vinyls", "Customer_ID", c => c.Int());
            CreateIndex("dbo.Vinyls", "Customer_ID");
            AddForeignKey("dbo.Vinyls", "Customer_ID", "dbo.Customers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vinyls", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Vinyls", new[] { "Customer_ID" });
            DropColumn("dbo.Vinyls", "Customer_ID");
        }
    }
}
