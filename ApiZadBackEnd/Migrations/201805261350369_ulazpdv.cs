namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ulazpdv : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.PoPdvTab2ID);
            
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
                "dbo.PoPdvTab5",
                c => new
                    {
                        PoPdvTab5ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        Desc = c.String(nullable: false, maxLength: 100),
                        Iznos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab5ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PoPdvTab5");
            DropTable("dbo.PoPdvTab4");
            DropTable("dbo.PoPdvTab3A");
            DropTable("dbo.PoPdvTab3");
            DropTable("dbo.PoPdvTab2");
        }
    }
}
