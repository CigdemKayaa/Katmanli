namespace Katmanli.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acıklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelId = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        IlceId = c.Int(nullable: false),
                        EgitimId = c.Int(nullable: false),
                        UnvanId = c.Int(nullable: false),
                        KanGrupId = c.Int(nullable: false),
                        YoneticiId = c.Int(nullable: false),
                        DogumTarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelId)
                .ForeignKey("dbo.Egitim", t => t.EgitimId, cascadeDelete: true)
                .ForeignKey("dbo.Ilce", t => t.IlceId, cascadeDelete: true)
                .ForeignKey("dbo.KanGrup", t => t.KanGrupId, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.YoneticiId)
                .ForeignKey("dbo.Unvan", t => t.UnvanId, cascadeDelete: true)
                .Index(t => t.IlceId)
                .Index(t => t.EgitimId)
                .Index(t => t.UnvanId)
                .Index(t => t.KanGrupId)
                .Index(t => t.YoneticiId);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IlId = c.Int(nullable: false),
                        Acıklama = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Il", t => t.IlId, cascadeDelete: true)
                .Index(t => t.IlId);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acıklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KanGrup",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acıklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Unvan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Acıklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personel", "UnvanId", "dbo.Unvan");
            DropForeignKey("dbo.Personel", "YoneticiId", "dbo.Personel");
            DropForeignKey("dbo.Personel", "KanGrupId", "dbo.KanGrup");
            DropForeignKey("dbo.Personel", "IlceId", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlId", "dbo.Il");
            DropForeignKey("dbo.Personel", "EgitimId", "dbo.Egitim");
            DropIndex("dbo.Ilce", new[] { "IlId" });
            DropIndex("dbo.Personel", new[] { "YoneticiId" });
            DropIndex("dbo.Personel", new[] { "KanGrupId" });
            DropIndex("dbo.Personel", new[] { "UnvanId" });
            DropIndex("dbo.Personel", new[] { "EgitimId" });
            DropIndex("dbo.Personel", new[] { "IlceId" });
            DropTable("dbo.Unvan");
            DropTable("dbo.KanGrup");
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Personel");
            DropTable("dbo.Egitim");
        }
    }
}
