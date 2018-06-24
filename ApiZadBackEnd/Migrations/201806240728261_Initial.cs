namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PoPdvTab01",
                c => new
                    {
                        PoPdvTab01ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Naknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab01ID);
            
            CreateTable(
                "dbo.PoPdvTab02",
                c => new
                    {
                        PoPdvTab02ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Naknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                        Vazno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab02ID);
            
            CreateTable(
                "dbo.PoPdvTab03",
                c => new
                    {
                        PoPdvTab03ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab03ID);
            
            CreateTable(
                "dbo.PoPdvTab03A",
                c => new
                    {
                        PoPdvTab03AID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab03AID);
            
            CreateTable(
                "dbo.PoPdvTab04",
                c => new
                    {
                        PoPdvTab04ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Osnovica = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab04ID);
            
            CreateTable(
                "dbo.PoPdvTab05",
                c => new
                    {
                        PoPdvTab05ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab05ID);
            
            CreateTable(
                "dbo.PoPdvTab06",
                c => new
                    {
                        PoPdvTab06ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Osnovica = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab06ID);
            
            CreateTable(
                "dbo.PoPdvTab07",
                c => new
                    {
                        PoPdvTab07ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Vrednost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PdvNadoknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab07ID);
            
            CreateTable(
                "dbo.PoPdvTab08",
                c => new
                    {
                        PoPdvTab08ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 250),
                        Desc = c.String(nullable: false, maxLength: 250),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Naknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab08ID);
            
            CreateTable(
                "dbo.PoPdvTab09",
                c => new
                    {
                        PoPdvTab09ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab09ID);
            
            CreateTable(
                "dbo.PoPdvTab10",
                c => new
                    {
                        PoPdvTab10ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab10ID);
            
            CreateTable(
                "dbo.PoPdvTab11",
                c => new
                    {
                        PoPdvTab11ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab11ID);
            
            CreateTable(
                "dbo.PoPdvTabGreska",
                c => new
                    {
                        PoPdvTabGreskaID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 250),
                        Desc = c.String(nullable: false, maxLength: 250),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Naknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        ObrPolje = c.Boolean(nullable: false),
                        UnosPolje = c.Boolean(nullable: false),
                        NaslovPolje = c.Boolean(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTabGreskaID);
            
            CreateTable(
                "dbo.sfBanke",
                c => new
                    {
                        Racun = c.String(nullable: false, maxLength: 100),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        Aktivan = c.Boolean(nullable: false),
                        Opis = c.String(),
                        BankeID = c.Int(nullable: false, identity: true),
                        created_at = c.DateTime(),
                        NameUser = c.String(),
                        updatedAt = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.BankeID);
            
            CreateTable(
                "dbo.sfDrzave",
                c => new
                    {
                        KodDrzave = c.String(nullable: false, maxLength: 3),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        EuClan = c.Boolean(nullable: false),
                        Opis = c.String(),
                        DrzaveID = c.Int(nullable: false, identity: true),
                        created_at = c.DateTime(),
                        NameUser = c.String(),
                        updatedAt = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.DrzaveID);
            
            CreateTable(
                "dbo.sfMesta",
                c => new
                    {
                        OpstineID = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        Ptt = c.String(nullable: false, maxLength: 50),
                        Opis = c.String(),
                        MestaID = c.Int(nullable: false, identity: true),
                        created_at = c.DateTime(),
                        NameUser = c.String(),
                        updatedAt = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.MestaID)
                .ForeignKey("dbo.sfOpstine", t => t.OpstineID, cascadeDelete: true)
                .Index(t => t.OpstineID);
            
            CreateTable(
                "dbo.sfOpstine",
                c => new
                    {
                        DrzaveID = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        RegOzn = c.String(nullable: false, maxLength: 3),
                        SifPorez = c.String(maxLength: 50),
                        KontBr = c.String(maxLength: 50),
                        PozivNaBr = c.String(maxLength: 50),
                        Opis = c.String(),
                        OpstineID = c.Int(nullable: false, identity: true),
                        created_at = c.DateTime(),
                        NameUser = c.String(),
                        updatedAt = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.OpstineID)
                .ForeignKey("dbo.sfDrzave", t => t.DrzaveID, cascadeDelete: true)
                .Index(t => t.DrzaveID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sfMesta", "OpstineID", "dbo.sfOpstine");
            DropForeignKey("dbo.sfOpstine", "DrzaveID", "dbo.sfDrzave");
            DropIndex("dbo.sfOpstine", new[] { "DrzaveID" });
            DropIndex("dbo.sfMesta", new[] { "OpstineID" });
            DropTable("dbo.sfOpstine");
            DropTable("dbo.sfMesta");
            DropTable("dbo.sfDrzave");
            DropTable("dbo.sfBanke");
            DropTable("dbo.PoPdvTabGreska");
            DropTable("dbo.PoPdvTab11");
            DropTable("dbo.PoPdvTab10");
            DropTable("dbo.PoPdvTab09");
            DropTable("dbo.PoPdvTab08");
            DropTable("dbo.PoPdvTab07");
            DropTable("dbo.PoPdvTab06");
            DropTable("dbo.PoPdvTab05");
            DropTable("dbo.PoPdvTab04");
            DropTable("dbo.PoPdvTab03A");
            DropTable("dbo.PoPdvTab03");
            DropTable("dbo.PoPdvTab02");
            DropTable("dbo.PoPdvTab01");
        }
    }
}
