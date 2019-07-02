namespace VinylShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noIdea : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vinyls", "Cart_ID", "dbo.Carts");
            DropIndex("dbo.Vinyls", new[] { "Cart_ID" });
            DropColumn("dbo.Vinyls", "Cart_ID");
            DropTable("dbo.Carts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Vinyls", "Cart_ID", c => c.Int());
            CreateIndex("dbo.Vinyls", "Cart_ID");
            AddForeignKey("dbo.Vinyls", "Cart_ID", "dbo.Carts", "ID");
        }
    }
}
