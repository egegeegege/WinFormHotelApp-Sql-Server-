namespace WindowsFormsApp2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Otellers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OtelAdı = c.String(nullable: false),
                        YıldızSayısı = c.String(nullable: false),
                        GünlükFiyatı = c.Double(nullable: false),
                        OdaSayısı = c.Int(nullable: false),
                        Havuz = c.String(nullable: false),
                        SporSalonu = c.String(nullable: false),
                        Adres = c.String(nullable: false),
                        ImageUrl = c.String(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OdaID = c.Int(nullable: false),
                        YoneticiID = c.Int(nullable: false),
                        RezerveTarihi = c.DateTime(nullable: false),
                        OdaTeslimTarihi = c.DateTime(nullable: false),
                        KullanımSuresi = c.Int(),
                        FaturaTutari = c.Double(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                        Oteller_ID = c.Int(),
                        Yoneticiler_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Otellers", t => t.Oteller_ID)
                .ForeignKey("dbo.Yoneticilers", t => t.Yoneticiler_ID)
                .Index(t => t.Oteller_ID)
                .Index(t => t.Yoneticiler_ID);
            
            CreateTable(
                "dbo.Yoneticilers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Email = c.String(),
                        TelefonNo = c.String(),
                        Sifre = c.String(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "Yoneticiler_ID", "dbo.Yoneticilers");
            DropForeignKey("dbo.Rezervasyons", "Oteller_ID", "dbo.Otellers");
            DropIndex("dbo.Rezervasyons", new[] { "Yoneticiler_ID" });
            DropIndex("dbo.Rezervasyons", new[] { "Oteller_ID" });
            DropTable("dbo.Yoneticilers");
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.Otellers");
        }
    }
}
