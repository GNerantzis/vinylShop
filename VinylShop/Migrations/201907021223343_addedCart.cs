namespace VinylShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Vinyls",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Artist = c.String(),
                        Title = c.String(),
                        ReleaseYear = c.Int(nullable: false),
                        Label = c.String(),
                        Genre = c.String(),
                        Price = c.Int(nullable: false),
                        image = c.String(),
                        audioclip = c.String(),
                        Customer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.Customer_ID)
                .Index(t => t.Customer_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vinyls", "Customer_ID", "dbo.Customers");
            DropIndex("dbo.Vinyls", new[] { "Customer_ID" });
            DropTable("dbo.Vinyls");
            DropTable("dbo.Customers");
        }
    }
}
