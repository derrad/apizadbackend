namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PoPdvTab1",
                c => new
                    {
                        PoPdvTab1ID = c.Int(nullable: false, identity: true),
                        Oznaka = c.String(nullable: false, maxLength: 10),
                        Desc = c.String(nullable: false, maxLength: 100),
                        Naknada = c.Decimal(nullable: false, precision: 16, scale: 2),
                        RedPrikaza = c.Int(nullable: false),
                        BoldPozic = c.Boolean(nullable: false),
                        created_at = c.DateTime(),
                        KORISNIK_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoPdvTab1ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PoPdvTab1");
        }
    }
}
