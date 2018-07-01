namespace ApiZadBackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LabelPoPdv", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "UlazPdv", c => c.Short(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "IzlazPdv", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "NaslovPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "BoldPozic", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "ObrPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "UnosPolje", c => c.Short(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "NaslovPolje", c => c.Short(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "BoldPozic", c => c.Short(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "ObrPolje", c => c.Short(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "UnosPolje", c => c.Short(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "NaslovPolje", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.PoPdvTabGreska", "NaslovPolje", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "UnosPolje", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "ObrPolje", c => c.Boolean(nullable: false));
            //AlterColumn("dbo.PoPdvTabGreska", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab11", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab10", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab09", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab08", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab07", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab06", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab05", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab04", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03A", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab03", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab02", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "ObrPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PoPdvTab01", "BoldPozic", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "IzlazPdv", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "UlazPdv", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "NaslovPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "UnosPolje", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LabelPoPdv", "ObrPolje", c => c.Boolean(nullable: false));
        }
    }
}
