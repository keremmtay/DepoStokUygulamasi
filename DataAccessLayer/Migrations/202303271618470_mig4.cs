namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StockOperationDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StockOperationId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                        Fiyat = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.StockOperations", t => t.StockOperationId, cascadeDelete: true)
                .Index(t => t.StockOperationId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.StockOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        IslemTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirmaAdi = c.String(nullable: false, maxLength: 25),
                        FirmaTuru = c.String(nullable: false, maxLength: 15),
                        Adres = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 15),
                        Email = c.String(maxLength: 30),
                        YetkiliKisi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 100),
                        VergiNo = c.String(maxLength: 15),
                        HesapNo = c.String(maxLength: 16),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockOperationDetails", "StockOperationId", "dbo.StockOperations");
            DropForeignKey("dbo.StockOperations", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.StockOperationDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.StockOperations", new[] { "CompanyId" });
            DropIndex("dbo.StockOperationDetails", new[] { "ProductId" });
            DropIndex("dbo.StockOperationDetails", new[] { "StockOperationId" });
            DropTable("dbo.Companies");
            DropTable("dbo.StockOperations");
            DropTable("dbo.StockOperationDetails");
        }
    }
}
