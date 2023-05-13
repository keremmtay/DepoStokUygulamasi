namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Products", "CategoryId");
            CreateIndex("dbo.Products", "UnitId");
            CreateIndex("dbo.Products", "WarehouseId");
            AddForeignKey("dbo.Products", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "UnitId", "dbo.Units", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Products", "WarehouseId", "dbo.Warehouses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "WarehouseId", "dbo.Warehouses");
            DropForeignKey("dbo.Products", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "WarehouseId" });
            DropIndex("dbo.Products", new[] { "UnitId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
        }
    }
}
