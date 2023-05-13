namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "KategoriAdi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Categories", "Aciklama", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Employees", "Adi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Soyadi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Gorevi", c => c.String(maxLength: 20));
            AlterColumn("dbo.Employees", "KullaniciAdi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Sifre", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Products", "UrunAdi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Products", "BarkodKodu", c => c.String(maxLength: 13));
            AlterColumn("dbo.Products", "RafNo", c => c.String(maxLength: 5));
            AlterColumn("dbo.Units", "BirimAdi", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Units", "Aciklama", c => c.String(maxLength: 100));
            AlterColumn("dbo.Warehouses", "DepoAdi", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Warehouses", "Aciklama", c => c.String(maxLength: 100));
            AlterColumn("dbo.Warehouses", "DepoYetkilisi", c => c.String(maxLength: 30));
            AlterColumn("dbo.Warehouses", "Telefon", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Warehouses", "Telefon", c => c.String());
            AlterColumn("dbo.Warehouses", "DepoYetkilisi", c => c.String());
            AlterColumn("dbo.Warehouses", "Aciklama", c => c.String());
            AlterColumn("dbo.Warehouses", "DepoAdi", c => c.String());
            AlterColumn("dbo.Units", "Aciklama", c => c.String());
            AlterColumn("dbo.Units", "BirimAdi", c => c.String());
            AlterColumn("dbo.Products", "RafNo", c => c.String());
            AlterColumn("dbo.Products", "BarkodKodu", c => c.String());
            AlterColumn("dbo.Products", "UrunAdi", c => c.String());
            AlterColumn("dbo.Employees", "Sifre", c => c.String());
            AlterColumn("dbo.Employees", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Employees", "Gorevi", c => c.String());
            AlterColumn("dbo.Employees", "Soyadi", c => c.String());
            AlterColumn("dbo.Employees", "Adi", c => c.String());
            AlterColumn("dbo.Categories", "Aciklama", c => c.String());
            AlterColumn("dbo.Categories", "KategoriAdi", c => c.String());
        }
    }
}
