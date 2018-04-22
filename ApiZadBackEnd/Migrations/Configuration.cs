namespace ApiZadBackEnd.Migrations
{
    using ApiZadBackEnd.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiZadBackEnd.Models.ZadrugaEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApiZadBackEnd.Models.ZadrugaEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.sfDrzave.AddOrUpdate(x => x.DrzaveID,
                new sfDrzave() { DrzaveID=1,Naziv = "SRBIJA", KodDrzave = "SRB", NameUser = "System", Opis = "prvi da vidim ide li", EuClan = false, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 2,Naziv = "BOSNA I HERCEGOVINA", KodDrzave = "BIH", NameUser = "saska@saska.com", EuClan = false, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 3, Naziv = "RUMUNIJA", KodDrzave = "ROM", NameUser = "radivoje@deretic.net", EuClan = true, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 4, KodDrzave = "MNG", Naziv = "Crna Gora", Opis = "Provera", NameUser = "saska@saska.com", created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 5, KodDrzave = "SLK", Naziv = "Slovaèka", Opis = "Provera opet", NameUser = "radivoje@deretic.net", EuClan = true, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 6, KodDrzave = "JEM", Naziv = "JEMEN", NameUser = "radivoje@deretic.net", EuClan = false, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 7, KodDrzave = "BEL", Naziv = "Belgija", Opis = "Opis kod insert sloga", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 8, KodDrzave = "POL", Naziv = "Poljska", Opis = "prvi put update, drugi put update", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                new sfDrzave() { DrzaveID = 9, KodDrzave = "LTU", Naziv = "Litvanija", NameUser = "saska@saska.com", EuClan=true, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 10, KodDrzave ="KNA",Naziv="Sent Kits i Nevis", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 11, KodDrzave ="SWE",Naziv="Švedska",EuClan=true,NameUser="saska@saska.com", created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 12, KodDrzave ="ESH",Naziv="Zapadna sahara", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 13, KodDrzave ="JOR",Naziv="Jordan", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 14, KodDrzave ="ZAF",Naziv="Južnoafrièka republika", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 15, KodDrzave ="HMD",Naziv="Herd i MekDonald ostrva", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 16, KodDrzave ="SYR",Naziv="Sirija", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 17, KodDrzave ="SXM",Naziv="Sent Martin", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 18, KodDrzave ="PCN",Naziv="Pitkern", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 19, KodDrzave ="LIE",Naziv="Lihtenštajn", EuClan = true, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 20, KodDrzave ="COM",Naziv="Komorska ostrva", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 21,KodDrzave ="BRB",Naziv="Barbados", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 22,KodDrzave ="HTI",Naziv="Haiti", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 23,KodDrzave ="ALB",Naziv="Albanija", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 24,KodDrzave ="COD",Naziv="Kongo", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 25,KodDrzave ="MTQ",Naziv="Matinik", EuClan = false, created_at = DateTime.Now },
                new sfDrzave(){ DrzaveID = 26,KodDrzave ="CYP",Naziv="Kipar",EuClan = true,NameUser="saska@saska.com", created_at = DateTime.Now }
            );


            context.sfOpstine.AddOrUpdate(x => x.OpstineID,
                new sfOpstine() { OpstineID = 1, DrzaveID = 1, RegOzn="BAN", Naziv = "Panèevo", NameUser = "System", created_at = DateTime.Now },
                new sfOpstine() { OpstineID = 2, DrzaveID = 1, RegOzn = "BAN", Naziv = "Vršac", NameUser = "System", created_at = DateTime.Now },
                new sfOpstine() { OpstineID = 3, DrzaveID = 1, RegOzn = "BAN", Naziv = "Kovin", NameUser = "System", created_at = DateTime.Now },
                new sfOpstine() { OpstineID = 4, DrzaveID = 1, RegOzn = "BAN", Naziv = "Alibunar", NameUser = "System", created_at = DateTime.Now },
                new sfOpstine() { OpstineID = 5, DrzaveID = 1, RegOzn = "BAN", Naziv = "Plandište", NameUser = "System", created_at = DateTime.Now },
                new sfOpstine() { OpstineID = 6, DrzaveID = 1, RegOzn = "BAN", Naziv = "Kovaèica", NameUser = "System", created_at = DateTime.Now },
                new sfOpstine() { OpstineID = 7, DrzaveID = 1, RegOzn = "BAN", Naziv = "Zrenjanin", NameUser = "System", created_at = DateTime.Now }

             );

            context.sfMesta.AddOrUpdate(x => x.MestaID,
              new sfMesta() { MestaID = 1,  OpstineID = 1,  Naziv = "Panèevo", Ptt="26000", NameUser = "System", created_at = DateTime.Now },
              new sfMesta() { MestaID = 2,  OpstineID = 1,  Naziv = "Jabuka", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
              new sfMesta() { MestaID = 3,  OpstineID = 1,  Naziv = "Dolovo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
              new sfMesta() { MestaID = 4,  OpstineID = 1,  Naziv = "Starèevo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
              new sfMesta() { MestaID = 5,  OpstineID = 1,  Naziv = "Omoljica", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
              new sfMesta() { MestaID = 6,  OpstineID = 1,  Naziv = "Ivanovo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
              new sfMesta() { MestaID = 7,  OpstineID = 1,  Naziv = "Banatski Brestovac", Ptt = "26000", NameUser = "System", created_at = DateTime.Now }

           );

            context.sfBanke.AddOrUpdate(x => x.BankeID,
             new sfBanke() { BankeID = 1,  Naziv = "Banka Inteza", Racun = "160-959-6999", NameUser = "System", created_at = DateTime.Now },
             new sfBanke() { BankeID = 2,  Naziv = "Aik Banka", Racun = "150-985-9699", NameUser = "System", created_at = DateTime.Now },
             new sfBanke() { BankeID = 3,  Naziv = "Aik Banka1", Racun = "150-6985-9699", NameUser = "System", created_at = DateTime.Now }
            

          );


        }
    }
}
