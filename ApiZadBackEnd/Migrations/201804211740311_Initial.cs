namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
