namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
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
                        ParentDesc = c.String(nullable: false, maxLength: 200),
                        Desc = c.String(nullable: false, maxLength: 200),
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
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab11ID);
            
            DropTable("dbo.PoPdvTab1");
            DropTable("dbo.PoPdvTab2");
            DropTable("dbo.PoPdvTab3");
            DropTable("dbo.PoPdvTab3A");
            DropTable("dbo.PoPdvTab4");
            DropTable("dbo.PoPdvTab5");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PoPdvTab5",
                c => new
                    {
                        PoPdvTab5ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(),
                        Desc = c.String(),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab5ID);
            
            CreateTable(
                "dbo.PoPdvTab4",
                c => new
                    {
                        PoPdvTab4ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 100),
                        Desc = c.String(nullable: false, maxLength: 100),
                        Osnovica = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab4ID);
            
            CreateTable(
                "dbo.PoPdvTab3A",
                c => new
                    {
                        PoPdvTab3AID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        Desc = c.String(nullable: false, maxLength: 100),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab3AID);
            
            CreateTable(
                "dbo.PoPdvTab3",
                c => new
                    {
                        PoPdvTab3ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        Desc = c.String(nullable: false, maxLength: 100),
                        OS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_osnov = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PS_pdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab3ID);
            
            CreateTable(
                "dbo.PoPdvTab2",
                c => new
                    {
                        PoPdvTab2ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        Desc = c.String(nullable: false, maxLength: 100),
                        Naknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                        Vazno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab2ID);
            
            CreateTable(
                "dbo.PoPdvTab1",
                c => new
                    {
                        PoPdvTab1ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        Desc = c.String(nullable: false, maxLength: 100),
                        Naknada = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab1ID);
            
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
