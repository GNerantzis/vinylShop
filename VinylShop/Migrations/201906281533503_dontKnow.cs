namespace VinylShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dontKnow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Vinyls", "Cart_ID", c => c.Int());
            CreateIndex("dbo.Vinyls", "Cart_ID");
            AddForeignKey("dbo.Vinyls", "Cart_ID", "dbo.Carts", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vinyls", "Cart_ID", "dbo.Carts");
            DropIndex("dbo.Vinyls", new[] { "Cart_ID" });
            DropColumn("dbo.Vinyls", "Cart_ID");
            DropTable("dbo.Customers");
            DropTable("dbo.Carts");
        }
    }
}
