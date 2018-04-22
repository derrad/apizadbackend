namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Banke1UpdatePolje : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.sfBanke", "Aktivan", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.sfBanke", "Aktivan");
        }
    }
}
