namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LabelPoPdv",
                c => new
                    {
                        LabelPoPdvID = c.Int(nullable: false, identity: true),
                        TableID = c.Int(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        ParentDesc = c.String(nullable: false, maxLength: 250),
                        Desc = c.String(nullable: false, maxLength: 250),
                        Prikaz = c.String(),
                        ImeTab = c.String(),
                        UlazPdv = c.Short(nullable: false),
                        IzlazPdv = c.Short(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LabelPoPdvID);
            
            CreateTable(
                "dbo.POPDV1",
                c => new
                    {
                        POPDV1_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_14 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_15 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_16 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_17 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV1_ID);
            
            CreateTable(
                "dbo.POPDV10",
                c => new
                    {
                        POPDV10_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_10 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV10_ID);
            
            CreateTable(
                "dbo.POPDV11",
                c => new
                    {
                        POPDV11_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_111 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_112 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_113 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV11_ID);
            
            CreateTable(
                "dbo.POPDV2",
                c => new
                    {
                        POPDV2_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_22 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_23 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_24 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_25 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_26 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_27 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV2_ID);
            
            CreateTable(
                "dbo.POPDV3",
                c => new
                    {
                        POPDV3_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_311 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_312 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_313 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_314 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_321 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_322 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_323 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_324 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_331 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_333 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_341 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_343 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_351 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_352 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_353 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_354 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_361 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_362 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_363 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_364 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_371 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_372 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_373 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_374 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_381 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_382 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_383 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_384 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_391 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_392 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_393 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_394 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3102 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3104 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV3_ID);
            
            CreateTable(
                "dbo.POPDV3a",
                c => new
                    {
                        POPDV3a_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_3a11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a22 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a31 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a32 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a41 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a42 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a51 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a52 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a61 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a62 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a71 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a72 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a81 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a82 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a91 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_3a92 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV3a_ID);
            
            CreateTable(
                "dbo.POPDV4",
                c => new
                    {
                        POPDV4_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_4111 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4121 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4131 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4142 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4211 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4212 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4221 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4222 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4231 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4232 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4243 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_4244 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV4_ID);
            
            CreateTable(
                "dbo.POPDV5",
                c => new
                    {
                        POPDV5_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_51 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_52 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_53 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_54 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_55 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_56 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_57 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV5_ID);
            
            CreateTable(
                "dbo.POPDV6",
                c => new
                    {
                        POPDV6_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_61 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_6211 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_6212 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_6221 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_6222 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_6231 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_6232 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_63 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_64 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV6_ID);
            
            CreateTable(
                "dbo.POPDV7",
                c => new
                    {
                        POPDV7_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_711 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_721 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_732 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_742 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV7_ID);
            
            CreateTable(
                "dbo.POPDV8",
                c => new
                    {
                        POPDV8_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_8a11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a13 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a14 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a22 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a23 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a24 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a31 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a32 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a33 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a34 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a41 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a42 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a43 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a44 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a51 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a52 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a53 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a54 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a61 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a63 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a71 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a72 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a73 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a74 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a82 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8a84 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b22 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b31 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b32 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b41 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b42 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b51 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b52 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b61 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b62 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b71 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8b72 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8v1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8v2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8v3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8v4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g11 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g12 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g22 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g31 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g32 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g41 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g42 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g51 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g52 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g61 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8g62 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8d1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8d2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8d3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8dj = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8e1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8e2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8e3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8e4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8e5 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_8e6 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV8_ID);
            
            CreateTable(
                "dbo.POPDV9",
                c => new
                    {
                        POPDV9_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_9 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV9_ID);
            
            CreateTable(
                "dbo.POPDV9a",
                c => new
                    {
                        POPDV9a_ID = c.Int(nullable: false, identity: true),
                        prPPPDV_ID = c.Int(nullable: false),
                        Iznos_9a1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_9a2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_9a3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Iznos_9a4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POPDV9a_ID);
            
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
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
                        BoldPozic = c.Short(nullable: false),
                        ObrPolje = c.Short(nullable: false),
                        UnosPolje = c.Short(nullable: false),
                        NaslovPolje = c.Short(nullable: false),
                        Napomena = c.String(),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab11ID);
            
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
            DropTable("dbo.POPDV9a");
            DropTable("dbo.POPDV9");
            DropTable("dbo.POPDV8");
            DropTable("dbo.POPDV7");
            DropTable("dbo.POPDV6");
            DropTable("dbo.POPDV5");
            DropTable("dbo.POPDV4");
            DropTable("dbo.POPDV3a");
            DropTable("dbo.POPDV3");
            DropTable("dbo.POPDV2");
            DropTable("dbo.POPDV11");
            DropTable("dbo.POPDV10");
            DropTable("dbo.POPDV1");
            DropTable("dbo.LabelPoPdv");
        }
    }
}
