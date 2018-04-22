namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banke : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sfBanke",
                c => new
                    {
                        Racun = c.String(nullable: false, maxLength: 100),
                        Naziv = c.String(nullable: false, maxLength: 100),
                        Opis = c.String(),
                        BankeID = c.Int(nullable: false, identity: true),
                        created_at = c.DateTime(),
                        NameUser = c.String(),
                        updatedAt = c.DateTime(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.BankeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sfBanke");
        }
    }
}
