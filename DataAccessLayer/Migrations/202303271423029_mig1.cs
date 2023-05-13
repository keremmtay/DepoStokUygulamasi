namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Gorevi = c.String(),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(),
                        CategoryId = c.Int(nullable: false),
                        BarkodKodu = c.String(),
                        StokMiktari = c.Int(nullable: false),
                        BirimFiyat = c.Double(nullable: false),
                        UnitId = c.Int(nullable: false),
                        RafNo = c.String(),
                        WarehouseId = c.Int(nullable: false),
                        MinStok = c.Int(nullable: false),
                        MaxStok = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BirimAdi = c.String(),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoAdi = c.String(),
                        Aciklama = c.String(),
                        DepoYetkilisi = c.String(),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Warehouses");
            DropTable("dbo.Units");
            DropTable("dbo.Products");
            DropTable("dbo.Employees");
            DropTable("dbo.Categories");
        }
    }
}
