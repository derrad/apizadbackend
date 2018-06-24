namespace ApiZadBackEnd.Migrations
{
    using ApiZadBackEnd.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiZadBackEnd.Models.ZadrugaEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApiZadBackEnd.Models.ZadrugaEntities context)
        {
            try
            {
                //  This method will be called after migrating to the latest version.

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                //  to avoid creating duplicate seed data.

                context.sfDrzave.AddOrUpdate(x => x.DrzaveID,
                    new sfDrzave() { DrzaveID = 1, Naziv = "SRBIJA", KodDrzave = "SRB", NameUser = "System", Opis = "prvi da vidim ide li", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 2, Naziv = "BOSNA I HERCEGOVINA", KodDrzave = "BIH", NameUser = "saska@saska.com", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 3, Naziv = "RUMUNIJA", KodDrzave = "ROM", NameUser = "radivoje@deretic.net", EuClan = true, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 4, KodDrzave = "MNG", Naziv = "Crna Gora", Opis = "Provera", NameUser = "saska@saska.com", created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 5, KodDrzave = "SLK", Naziv = "Slovačka", Opis = "Provera opet", NameUser = "radivoje@deretic.net", EuClan = true, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 6, KodDrzave = "JEM", Naziv = "JEMEN", NameUser = "radivoje@deretic.net", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 7, KodDrzave = "BEL", Naziv = "Belgija", Opis = "Opis kod insert sloga", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 8, KodDrzave = "POL", Naziv = "Poljska", Opis = "prvi put update, drugi put update", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 9, KodDrzave = "LTU", Naziv = "Litvanija", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 10, KodDrzave = "KNA", Naziv = "Sent Kits i Nevis", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 11, KodDrzave = "SWE", Naziv = "Švedska", EuClan = true, NameUser = "saska@saska.com", created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 12, KodDrzave = "ESH", Naziv = "Zapadna sahara", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 13, KodDrzave = "JOR", Naziv = "Jordan", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 14, KodDrzave = "ZAF", Naziv = "Južnoafrička republika", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 15, KodDrzave = "HMD", Naziv = "Herd i MekDonald ostrva", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 16, KodDrzave = "SYR", Naziv = "Sirija", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 17, KodDrzave = "SXM", Naziv = "Sent Martin", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 18, KodDrzave = "PCN", Naziv = "Pitkern", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 19, KodDrzave = "LIE", Naziv = "Lihtenštajn", EuClan = true, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 20, KodDrzave = "COM", Naziv = "Komorska ostrva", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 21, KodDrzave = "BRB", Naziv = "Barbados", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 22, KodDrzave = "HTI", Naziv = "Haiti", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 23, KodDrzave = "ALB", Naziv = "Albanija", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 24, KodDrzave = "COD", Naziv = "Kongo", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 25, KodDrzave = "MTQ", Naziv = "Matinik", EuClan = false, created_at = DateTime.Now },
                    new sfDrzave() { DrzaveID = 26, KodDrzave = "CYP", Naziv = "Kipar", EuClan = true, NameUser = "saska@saska.com", created_at = DateTime.Now }
                );


                context.sfOpstine.AddOrUpdate(x => x.OpstineID,
                    new sfOpstine() { OpstineID = 1, DrzaveID = 1, RegOzn = "BAN", Naziv = "Pančevo", NameUser = "System", created_at = DateTime.Now },
                    new sfOpstine() { OpstineID = 2, DrzaveID = 1, RegOzn = "BAN", Naziv = "Vršac", NameUser = "System", created_at = DateTime.Now },
                    new sfOpstine() { OpstineID = 3, DrzaveID = 1, RegOzn = "BAN", Naziv = "Kovin", NameUser = "System", created_at = DateTime.Now },
                    new sfOpstine() { OpstineID = 4, DrzaveID = 1, RegOzn = "BAN", Naziv = "Alibunar", NameUser = "System", created_at = DateTime.Now },
                    new sfOpstine() { OpstineID = 5, DrzaveID = 1, RegOzn = "BAN", Naziv = "Plandište", NameUser = "System", created_at = DateTime.Now },
                    new sfOpstine() { OpstineID = 6, DrzaveID = 1, RegOzn = "BAN", Naziv = "Kovačica", NameUser = "System", created_at = DateTime.Now },
                    new sfOpstine() { OpstineID = 7, DrzaveID = 1, RegOzn = "BAN", Naziv = "Zrenjanin", NameUser = "System", created_at = DateTime.Now }

                 );

                context.sfMesta.AddOrUpdate(x => x.MestaID,
                  new sfMesta() { MestaID = 1, OpstineID = 1, Naziv = "Pančevo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                  new sfMesta() { MestaID = 2, OpstineID = 1, Naziv = "Jabuka", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                  new sfMesta() { MestaID = 3, OpstineID = 1, Naziv = "Dolovo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                  new sfMesta() { MestaID = 4, OpstineID = 1, Naziv = "Starčevo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                  new sfMesta() { MestaID = 5, OpstineID = 1, Naziv = "Omoljica", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                  new sfMesta() { MestaID = 6, OpstineID = 1, Naziv = "Ivanovo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                  new sfMesta() { MestaID = 7, OpstineID = 1, Naziv = "Banatski Brestovac", Ptt = "26000", NameUser = "System", created_at = DateTime.Now }

                 );

                context.sfBanke.AddOrUpdate(x => x.BankeID,
                 new sfBanke() { BankeID = 1, Naziv = "Banka Inteza", Racun = "160-959-6999", NameUser = "System", created_at = DateTime.Now },
                 new sfBanke() { BankeID = 2, Naziv = "Aik Banka", Racun = "150-985-9699", NameUser = "System", created_at = DateTime.Now },
                 new sfBanke() { BankeID = 3, Naziv = "Aik Banka1", Racun = "150-6985-9699", NameUser = "System", created_at = DateTime.Now }


              );


                DataPoPdvTab01(context);
                DataPoPdvTab02(context);
                DataPoPdvTab03(context);

                DataPoPdvTab03A(context);
                DataPoPdvTab04(context);
                DataPoPdvTab05(context);

                DataPoPdvTab06(context);

                DataPoPdvTab07(context);

                DataPoPdvTab08(context);

                DataPoPdvTab09(context);

                DataPoPdvTab10(context);
                DataPoPdvTab11(context);
                DataPoPdvTabGreska(context);
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private static void DataPoPdvTab01(ZadrugaEntities context)
        {
            context.PoPdvTab01.AddOrUpdate(x => x.PoPdvTab01ID,
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 1,
                  Oznaka = "1.1",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Промет добара која се отпремају у иностранство, укључујући и повећање, односно смањење накнаде за тај промет",
                  RedPrikaza = 1,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = false,
                  Naknada = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 2,
                  Oznaka = "1.2",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Промет добара која се отпремaју на територију Аутономне покрајине Косово и Метохија, укључујући и повећање, односно смањење накнаде за тај промет ",
                  RedPrikaza = 2,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = false,
                  Naknada = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 3,
                  Oznaka = "1.3",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Промет добара која се уносе у слободну зону и промет добара и услуга у слободној зони, укључујући и повећање",
                  RedPrikaza = 3,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = false,
                  Naknada = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 4,
                  Oznaka = "1.4",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Промет добара и  услуга, осим из тач. 1.1 до 1.3, укључујући и повећање, односно смањење накнаде за тај промет",
                  RedPrikaza = 4,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = false,
                  Naknada = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 5,
                  Oznaka = "1.5",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Укупан промет (1.1+1.2+1.3+1.4)",
                  RedPrikaza = 5,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = true,
                  Naknada = 0,
                  ObrPolje = true,
                  NaslovPolje = false,
                  UnosPolje = false
              },
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 6,
                  Oznaka = "1.6",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Промет добара и услуга без накнаде",
                  RedPrikaza = 6,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = false,
                  Naknada = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab01()
              {
                  PoPdvTab01ID = 7,
                  Oznaka = "1.7",
                  ParentDesc = "1. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ СА ПРАВОМ НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                  Desc = @"Накнада или део накнаде наплаћен пре извршеног промета (аванс)",
                  RedPrikaza = 7,
                  KORISNIK_ID = 0,
                  created_at = DateTime.Now,
                  BoldPozic = false,
                  Naknada = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              }

         );
        }

        private static void DataPoPdvTab02(ZadrugaEntities context)
        {
            context.PoPdvTab02.AddOrUpdate(x => x.PoPdvTab02ID,
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 1,
                    Oznaka = "2.1",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Промет новца и капитала, укључујући и повећање, односно смањење накнаде за тај промет",
                    Naknada = 0,
                    RedPrikaza = 1,
                    BoldPozic = false,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 2,
                    Oznaka = "2.2",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Промет земљишта и давање у закуп земљишта, укључујући и повећање, односно смањење накнаде за тај промет",
                    Naknada = 0,
                    RedPrikaza = 2,
                    BoldPozic = false,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 3,
                    Oznaka = "2.3",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Промет објекaта, укључујући и повећање, односно смањење накнаде за тај промет",
                    Naknada = 0,
                    RedPrikaza = 3,
                    BoldPozic = false,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 4,
                    Oznaka = "2.4",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Промет добара и услуга, осим из тач. 2.1 до 2.3, укључујући и повећање, односно смањење накнаде за тај промет ",
                    Naknada = 0,
                    RedPrikaza = 4,
                    BoldPozic = false,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 5,
                    Oznaka = "2.5",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Укупан промет (2.1+2.2+2.3+2.4)",
                    Naknada = 0,
                    RedPrikaza = 5,
                    BoldPozic = true,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = true,
                    NaslovPolje = false,
                    UnosPolje = false
                },
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 6,
                    Oznaka = "2.6",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Промет добара и услуга без накнаде ",
                    Naknada = 0,
                    RedPrikaza = 6,
                    BoldPozic = false,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab02()
                {
                    PoPdvTab02ID = 7,
                    Oznaka = "2.7",
                    ParentDesc = "2. ПРОМЕТ ДОБАРА И УСЛУГА ЗА КОЈИ ЈЕ ПРОПИСАНО  ПОРЕСКО ОСЛОБОЂЕЊЕ БЕЗ ПРАВА НА ОДБИТАК ПРЕТХОДНОГ ПОРЕЗА",
                    Desc = @"Накнада или део накнаде наплаћен пре извршеног промета (аванс)",
                    Naknada = 0,
                    RedPrikaza = 7,
                    BoldPozic = false,
                    created_at = DateTime.Now,
                    KORISNIK_ID = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                }
              );
        }

        private static void DataPoPdvTab03(ZadrugaEntities context)
        {
            context.PoPdvTab03.AddOrUpdate(x => x.PoPdvTab03ID,
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 1,
                    Oznaka = "3.1",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Први пренос права располагања на новоизграђеним грађевинским објектима за који је порески дужник обвезник ПДВ који врши тај промет ",
                    RedPrikaza = 1,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },

                new PoPdvTab03()
                {
                    PoPdvTab03ID = 2,
                    Oznaka = "3.2",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Промет за који је порески дужник обвезник ПДВ који врши тај промет, осим из тачке 3.1",
                    RedPrikaza = 2,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 3,
                    Oznaka = "3.3",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Пренос права располагања на грађевинским објектима за који обвезник ПДВ који врши тај промет није порески дужник",
                    RedPrikaza = 3,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 4,
                    Oznaka = "3.4",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Промет за који обвезник ПДВ који врши тај промет није порески дужник, осим из тачке 3.3",
                    RedPrikaza = 4,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 5,
                    Oznaka = "3.5",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Повећање основице, односно ПДВ",
                    RedPrikaza = 5,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 6,
                    Oznaka = "3.6",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Смањење основице, односно ПДВ ",
                    RedPrikaza = 6,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 7,
                    Oznaka = "3.7",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Промет добара и услуга без накнаде ",
                    RedPrikaza = 7,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 8,
                    Oznaka = "3.8",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Укупна основица и обрачунати ПДВ за промет добара и услуга (3.1+3.2+3.3+3.4+3.5+3.6+3.7) ",
                    RedPrikaza = 8,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = true,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = true,
                    NaslovPolje = false,
                    UnosPolje = false
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 9,
                    Oznaka = "3.9",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Накнада или део накнаде који је наплаћен пре извршеног промета и ПДВ обрачунат по том основу (аванс)",
                    RedPrikaza = 9,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = false,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = false,
                    NaslovPolje = false,
                    UnosPolje = true
                },
                new PoPdvTab03()
                {
                    PoPdvTab03ID = 10,
                    Oznaka = "3.10",
                    ParentDesc = "3. ОПОРЕЗИВИ ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ ВРШИ ОБВЕЗНИК ПДВ И ОБРАЧУНАТИ ПДВ",
                    Desc = @"Укупно обрачунати ПДВ (3.8+3.9)",
                    RedPrikaza = 10,
                    KORISNIK_ID = 0,
                    created_at = DateTime.Now,
                    BoldPozic = true,
                    OS_osnov = 0,
                    OS_pdv = 0,
                    PS_osnov = 0,
                    PS_pdv = 0,
                    ObrPolje = true,
                    NaslovPolje = false,
                    UnosPolje = false
                }
             );
        }

        private static void DataPoPdvTab03A(ZadrugaEntities context)
        {
            context.PoPdvTab03A.AddOrUpdate(x => x.PoPdvTab03AID,
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 1,
                 Oznaka = "3a.1",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"ПДВ за пренос права располагања на грађевинским објектима за који је порески дужник обвезник ПДВ - прималац добара",
                 RedPrikaza = 1,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 2,
                 Oznaka = "3a.2",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"ПДВ за промет добара и услуга који у Републици врши страно лице које није обвезник ПДВ, за који је порески дужник обвезник ПДВ - прималац добара и услуга",
                 RedPrikaza = 2,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 3,
                 Oznaka = "3a.3",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"ПДВ за промет добара и услуга за који је порески дужник обвезник ПДВ - прималац добара и услуга, осим из тач. 3а.1 и 3а.2, укључујући и ПДВ обрачунат у складу са чланом 10. став 3. Закона",
                 RedPrikaza = 3,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 4,
                 Oznaka = "3a.4",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"Повећање обрачунатог ПДВ",
                 RedPrikaza = 4,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 5,
                 Oznaka = "3a.5",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"Смањење обрачунатог ПДВ",
                 RedPrikaza = 5,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 6,
                 Oznaka = "3a.6",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"ПДВ за промет добара и услуга без накнаде",
                 RedPrikaza = 6,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 7,
                 Oznaka = "3a.7",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"Укупно обрачунати ПДВ за промет добара и услуга (3а.1+3а.2+3а.3+3а.4+3а.5+3а.6)",
                 RedPrikaza = 7,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 8,
                 Oznaka = "3a.8",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"ПДВ пo основу накнаде или дела накнаде који је плаћен пре извршеног промета (аванс)",
                 RedPrikaza = 8,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = false,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = false,
                 NaslovPolje = false,
                 UnosPolje = true
             },
             new PoPdvTab03A()
             {
                 PoPdvTab03AID = 9,
                 Oznaka = "3a.9",
                 ParentDesc = "3а ОБРАЧУНАТИ ПДВ ЗА ПРОМЕТ ДРУГОГ ЛИЦА ",
                 Desc = @"Укупно обрачунати ПДВ (3а.7+3а.8)",
                 RedPrikaza = 9,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 OS_pdv = 0,
                 PS_pdv = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             }
          );
        }

        private static void DataPoPdvTab04(ZadrugaEntities context)
        {
            context.PoPdvTab04.AddOrUpdate(x => x.PoPdvTab04ID,
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 1,
                           Oznaka = "4.1.1",
                           ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                           Desc = @"Накнада коју плаћају путници, укључујући и повећање, односно смањење те накнаде ",
                           RedPrikaza = 1,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = false,
                           NaslovPolje = false,
                           UnosPolje = true
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 2,
                           Oznaka = "4.1.2",
                           ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                           Desc = @"Стварни трошкови за претходне туристичке услуге, укључујући и повећање, односно смањење тих трошкова ",
                           RedPrikaza = 2,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = false,
                           NaslovPolje = false,
                           UnosPolje = true
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 3,
                           Oznaka = "4.1.3",
                           ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                           Desc = @"Разлика (4.1.1 – 4.1.2) ",
                           RedPrikaza = 3,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = true,
                           NaslovPolje = false,
                           UnosPolje = false
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 4,
                           Oznaka = "4.1.4",
                           ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                           Desc = @"Обрачунати  ПДВ",
                           RedPrikaza = 4,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = false,
                           NaslovPolje = false,
                           UnosPolje = true
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 5,
                           Oznaka = "4.2.1",
                           ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                           Desc = @"Продајна цена добара, укључујући и повећање, односно смањење те цене ",
                           RedPrikaza = 5,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = false,
                           NaslovPolje = false,
                           UnosPolje = true
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 6,
                           Oznaka = "4.2.2",
                           ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                           Desc = @"Набавна цена добара, укључујући и повећање, односно смањење те цене ",
                           RedPrikaza = 6,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = false,
                           NaslovPolje = false,
                           UnosPolje = true
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 7,
                           Oznaka = "4.2.3",
                           ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                           Desc = @"Разлика (4.2.1 – 4.2.2)",
                           RedPrikaza = 6,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = true,
                           NaslovPolje = false,
                           UnosPolje = false
                       },
                       new PoPdvTab04()
                       {
                           PoPdvTab04ID = 8,
                           Oznaka = "4.2.4",
                           ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                           Desc = @"Обрачунати  ПДВ",
                           RedPrikaza = 8,
                           KORISNIK_ID = 0,
                           created_at = DateTime.Now,
                           BoldPozic = false,
                           Osnovica = 0,
                           Pdv = 0,
                           PS_osnov = 0,
                           OS_osnov = 0,
                           OS_pdv = 0,
                           PS_pdv = 0,
                           ObrPolje = false,
                           NaslovPolje = false,
                           UnosPolje = true
                       }

             );
        }

        private static void DataPoPdvTab05(ZadrugaEntities context)
        {
            context.PoPdvTab05.AddOrUpdate(x => x.PoPdvTab05ID,
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 1,
                 Oznaka = "5.1",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 Desc = @"Укупан опорезиви промет добара и услуга по општој стопи ПДВ (3.8+4.1.1+4.2.1) ",
                 RedPrikaza = 1,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 2,
                 Oznaka = "5.2",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 Desc = @"Укупно обрачунати ПДВ по општој стопи ПДВ (3.10+3а.9+4.1.4+4.2.4)",
                 RedPrikaza = 2,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 3,
                 Oznaka = "5.3",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 Desc = @"Укупно обрачунати ПДВ по општој стопи ПДВ увећан за износ за који се не може умањити претходни порез из тачке 8е.6 (5.2+(8е.6 у апсолутном износу))",
                 RedPrikaza = 3,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 4,
                 Oznaka = "5.4",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 Desc = @"Укупан опорезиви промет добара и услуга по посебној стопи ПДВ (3.8+4.2.1)",
                 RedPrikaza = 4,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 5,
                 Oznaka = "5.5",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 Desc = @"Укупно обрачунати ПДВ по посебној стопи ПДВ (3.10+3а.9+4.2.4)",
                 RedPrikaza = 5,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 6,
                 Oznaka = "5.6",
                 Desc = @"Укупан промет добара и услуга (1.5+2.5+5.1+5.4)",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 RedPrikaza = 6,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             },
             new PoPdvTab05()
             {
                 PoPdvTab05ID = 7,
                 Oznaka = "5.7",
                 ParentDesc = "5. УКУПАН ПРОМЕТ ДОБАРА И УСЛУГА И УКУПНО ОБРАЧУНАТИ ПДВ",
                 Desc = @"Укупно обрачунати ПДВ (5.3+5.5)",
                 RedPrikaza = 7,
                 KORISNIK_ID = 0,
                 created_at = DateTime.Now,
                 BoldPozic = true,
                 Iznos = 0,
                 ObrPolje = true,
                 NaslovPolje = false,
                 UnosPolje = false
             }
           );
        }

        private static void DataPoPdvTab06(ZadrugaEntities context)
        {
            context.PoPdvTab06.AddOrUpdate(x => x.PoPdvTab06ID,
          new PoPdvTab06()
          {
              PoPdvTab06ID = 1,
              Oznaka = "6.1",
              ParentDesc = "6.1 Вредност добара за чији је увоз прописано пореско ослобођење, укључујући и повећање, односно смањење вредности тих добара",
              Desc = @"-",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 1,
              BoldPozic = true,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = false,
              NaslovPolje = true,
              UnosPolje = false
          },
          new PoPdvTab06()
          {
              PoPdvTab06ID = 2,
              Oznaka = "6.2",
              ParentDesc = "6.2 Увоз добара на који се плаћа ПДВ",
              Desc = @"-",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 2,
              BoldPozic = true,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = false,
              NaslovPolje = true,
              UnosPolje = false
          },
          new PoPdvTab06()
          {
              PoPdvTab06ID = 3,
              Oznaka = "6.2.1",
              ParentDesc = "6.2 Увоз добара на који се плаћа ПДВ",
              Desc = @"Основица за увоз добара ",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 3,
              BoldPozic = false,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = false,
              NaslovPolje = false,
              UnosPolje = true
          },
          new PoPdvTab06()
          {
              PoPdvTab06ID = 4,
              Oznaka = "6.2.2",
              ParentDesc = "6.2 Увоз добара на који се плаћа ПДВ",
              Desc = @"Повећање основице за увоз добара ",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 4,
              BoldPozic = false,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = false,
              NaslovPolje = false,
              UnosPolje = true
          },
          new PoPdvTab06()
          {
              PoPdvTab06ID = 5,
              Oznaka = "6.2.3",
              ParentDesc = "6.2 Увоз добара на који се плаћа ПДВ",
              Desc = @"Смањење основице за увоз добара ",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 5,
              BoldPozic = false,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = false,
              NaslovPolje = false,
              UnosPolje = true
          },
          new PoPdvTab06()
          {
              PoPdvTab06ID = 6,
              Oznaka = "6.3",
              ParentDesc = "6.2 Увоз добара на који се плаћа ПДВ",
              Desc = @"Укупна вредност, односно основица за увоз добара (6.1+6.2.1+6.2.2+6.2.3) ",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 6,
              BoldPozic = true,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = true,
              NaslovPolje = false,
              UnosPolje = false
          },
          new PoPdvTab06()
          {
              PoPdvTab06ID = 7,
              Oznaka = "6.4",
              ParentDesc = "6.2 Увоз добара на који се плаћа ПДВ",
              Desc = @"Укупан ПДВ плаћен при увоз добара, а који се може одбити као претходни порез ",
              Osnovica = 0,
              OS_osnov = 0,
              PS_osnov = 0,
              RedPrikaza = 7,
              BoldPozic = true,
              created_at = DateTime.Now,
              KORISNIK_ID = 0,
              ObrPolje = false,
              NaslovPolje = false,
              UnosPolje = true
          }

        );
        }

        private static void DataPoPdvTab07(ZadrugaEntities context)
        {
            context.PoPdvTab07.AddOrUpdate(x => x.PoPdvTab07ID,
            new PoPdvTab07()
            {
                PoPdvTab07ID = 1,
                Oznaka = "7.1",
                ParentDesc = "7. НАБАВКА ДОБАРА И УСЛУГА ОД ПОЉОПРИВРЕДНИКА",
                Desc = @"Вредност примљених добара и услуга, укључујући и повећање, односно смањење те вредности ",
                Vrednost = 0,
                PdvNadoknada = 0,
                RedPrikaza = 1,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab07()
            {
                PoPdvTab07ID = 2,
                Oznaka = "7.2",
                ParentDesc = "7. НАБАВКА ДОБАРА И УСЛУГА ОД ПОЉОПРИВРЕДНИКА",
                Desc = @"Вредност плаћених добара и услуга ",
                Vrednost = 0,
                PdvNadoknada = 0,
                RedPrikaza = 2,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab07()
            {
                PoPdvTab07ID = 3,
                Oznaka = "7.3",
                ParentDesc = "7. НАБАВКА ДОБАРА И УСЛУГА ОД ПОЉОПРИВРЕДНИКА",
                Desc = @"Плаћена ПДВ надокнада ",
                Vrednost = 0,
                PdvNadoknada = 0,
                RedPrikaza = 3,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab07()
            {
                PoPdvTab07ID = 4,
                Oznaka = "7.4",
                ParentDesc = "7. НАБАВКА ДОБАРА И УСЛУГА ОД ПОЉОПРИВРЕДНИКА",
                Desc = @"Плаћена ПДВ надокнада која се може одбити као претходни порез ",
                Vrednost = 0,
                PdvNadoknada = 0,
                RedPrikaza = 4,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            }
            );
        }

        private static void DataPoPdvTab08(ZadrugaEntities context)
        {
            context.PoPdvTab08.AddOrUpdate(x => x.PoPdvTab08ID,
            new PoPdvTab08()
            {
                PoPdvTab08ID = 1,
                Oznaka = "8a",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 1,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 2,
                Oznaka = "8a.1",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Први пренос права располагања на новоизграђеним грађевинским објектима ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 2,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 3,
                Oznaka = "8a.2",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Добра и услуге, осим добара из тачке 8а.1 ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 3,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 4,
                Oznaka = "8a.3",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Добра и услуге без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 4,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 5,
                Oznaka = "8a.4",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Измена основице за набављена добра и услуге и исправка одбитка претходног пореза по основу измене основице - повећање",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 5,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 6,
                Oznaka = "8a.5",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Измена основице за набављена добра и услуге и исправка одбитка претходног пореза по основу измене основице - смањење",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 6,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 7,
                Oznaka = "8a.6",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Укупна основица за набављена добра и услуге (8а.1+8а.2+8а.3+8а.4+8а.5)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 7,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 8,
                Oznaka = "8a.7",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Накнада или део накнаде који је плаћен пре извршеног промета и ПДВ по том основу (аванс)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 8,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 9,
                Oznaka = "8a.8",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Укупно обрачунати ПДВ од стране обвезника ПДВ - претходног учесника у промету (8а.1+8а.2+8а.3+8а.4+8а.5+8а.7)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 9,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 10,
                Oznaka = "8б",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 10,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 11,
                Oznaka = "8б.1",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Пренос права располагања на грађевинским објектима ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 11,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 12,
                Oznaka = "8б.2",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Добра и услуге, осим добара из тачке 8б.1",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 12,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 13,
                Oznaka = "8б.3",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Добра и услуге без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 13,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 14,
                Oznaka = "8б.4",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Измена основице за набављена добра и услуге - повећање ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 14,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 15,
                Oznaka = "8б.5",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Измена основице за набављена добра и услуге - смањење ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 15,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 16,
                Oznaka = "8б.6",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Укупна основица за набављена добра и услуге (8б.1+8б.2+8б.3+8б.4+8б.5)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 16,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 17,
                Oznaka = "8б.7",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Накнада или део накнаде који је плаћен пре извршеног промета (аванс)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 17,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 18,
                Oznaka = "8г",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 18,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 19,
                Oznaka = "8г.1",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Добра и услуге ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 19,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 20,
                Oznaka = "8г.2",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Добра и услуге без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 20,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 21,
                Oznaka = "8г.3",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Измена основице - повећање",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 21,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 22,
                Oznaka = "8г.4",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Измена основице - смањење",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 22,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 23,
                Oznaka = "8г.5",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Укупна основица за набављена добра и услуге (8г.1+8г.2+8г.3+8г.4)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 23,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 24,
                Oznaka = "8г.6",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Накнада или део накнаде плаћен пре извршеног промета (аванс)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 24,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 25,
                Oznaka = "8д",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 25,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 26,
                Oznaka = "8д.1",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"Добра и услуге набављени у Републици од страних лица која нису обвезници ПДВ - промет за који не постоји обавеза обрачунавања ПДВ, као и повећање, односно смањење накнаде за та добра и услуге, укључујући и набавку без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 26,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 27,
                Oznaka = "8д.2",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"Добра и услуге набављени у Републици од лица са територије Републике која нису обвезници ПДВ, као и повећање, односно смањење накнаде за та добра и услуге, укључујући и набавку без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 27,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 27,
                Oznaka = "8д.3",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"Добра и услуге набављени ван Републике, као и повећање, односно смањење накнаде за та добра и услуге, укључујући и набавку без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 28,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 28,
                Oznaka = "8ђ",
                ParentDesc = "Укупна основица, накнада, односно вредност набављених добара и услуга (8а.6+8б.6+8в.4+8г.5+8д.1+8д.2+8д.3)",
                Desc = @"Укупна основица, накнада, односно вредност набављених добара и услуга (8а.6+8б.6+8в.4+8г.5+8д.1+8д.2+8д.3) ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 28,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 29,
                Oznaka = "8е",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 29,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 30,
                Oznaka = "8е.1",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет набављених добара и услуга за који је порески дужник обвезник ПДВ - испоручилац добара, односно пружалац услуга, а који се може одбити као претходни порез (8а.8 умањен за износ ПДВ који се не може одбити као претходни порез)".Substring(0, 249),
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 30,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 31,
                Oznaka = "8е.2",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет набављених добара и услуга за који је порески дужник обвезник ПДВ - прималац добара, односно услуга, а који се може одбити као претходни порез (3а.9 умањен за износ ПДВ који се не може одбити као претходни порез)".Substring(0, 249),
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 31,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 32,
                Oznaka = "8е.3",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Исправка одбитка - повећање претходног пореза, осим по основу измене основице за промет добара и услуга и по основу увоза добара",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 32,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 33,
                Oznaka = "8е.4",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Исправка одбитка - смањење претходног пореза, осим по основу измене основице за промет добара и услуга",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 33,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 34,
                Oznaka = "8е.5",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет добара и услуга који се може одбити као претходни порез (8е.1+8е.2+8е.3+8е.4)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 34,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab08()
            {
                PoPdvTab08ID = 35,
                Oznaka = "8е.6",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет добара и услуга који се може одбити као претходни порез увећан за износ за који се не може умањити обрачунати ПДВ (8е.5+(5.2+5.5 у апсолутном износу)) ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 35,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            }
             );
        }

        private static void DataPoPdvTab09(ZadrugaEntities context)
        {
            context.PoPdvTab09.AddOrUpdate(x => x.PoPdvTab09ID,
            new PoPdvTab09()
            {
                PoPdvTab09ID = 1,
                Oznaka = "9",
                ParentDesc = "9. УКУПНА ВРЕДНОСТ НАБАВЉЕНИХ ДОБАРА И УСЛУГА, УКЉУЧУЈУЋИ И УВОЗ ДОБАРА СТАВЉЕНИХ У СЛОБОДАН ПРОМЕТ (6.3+7.1+8ђ)",
                Desc = @"9. УКУПНА ВРЕДНОСТ НАБАВЉЕНИХ ДОБАРА И УСЛУГА, УКЉУЧУЈУЋИ И УВОЗ ДОБАРА СТАВЉЕНИХ У СЛОБОДАН ПРОМЕТ (6.3+7.1+8ђ)",
                Iznos = 0,
                RedPrikaza = 1,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTab09()
            {
                PoPdvTab09ID = 2,
                Oznaka = "9а.",
                ParentDesc = "9а ПДВ КОЈИ СЕ У ПОРЕСКОЈ ПРИЈАВИ ИСКАЗУЈЕ КАО ПРЕТХОДНИ ПОРЕЗ ",
                Desc = @"-",
                Iznos = 0,
                RedPrikaza = 2,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTab09()
            {
                PoPdvTab09ID = 3,
                Oznaka = "9а.1",
                ParentDesc = "9а ПДВ КОЈИ СЕ У ПОРЕСКОЈ ПРИЈАВИ ИСКАЗУЈЕ КАО ПРЕТХОДНИ ПОРЕЗ ",
                Desc = @"ПДВ плаћен при увозу добара ",
                Iznos = 0,
                RedPrikaza = 3,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab09()
            {
                PoPdvTab09ID = 4,
                Oznaka = "9а.2",
                ParentDesc = "9а ПДВ КОЈИ СЕ У ПОРЕСКОЈ ПРИЈАВИ ИСКАЗУЈЕ КАО ПРЕТХОДНИ ПОРЕЗ ",
                Desc = @"ПДВ надокнада плаћена пољопривреднику ",
                Iznos = 0,
                RedPrikaza = 4,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab09()
            {
                PoPdvTab09ID = 5,
                Oznaka = "9а.3",
                ParentDesc = "9а ПДВ КОЈИ СЕ У ПОРЕСКОЈ ПРИЈАВИ ИСКАЗУЈЕ КАО ПРЕТХОДНИ ПОРЕЗ ",
                Desc = @"ПДВ по основу набавки добара и услуга, осим из тач. 9а.1 и 9а.2 ",
                Iznos = 0,
                RedPrikaza = 5,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTab09()
            {
                PoPdvTab09ID = 6,
                Oznaka = "9а.4",
                ParentDesc = "9а ПДВ КОЈИ СЕ У ПОРЕСКОЈ ПРИЈАВИ ИСКАЗУЈЕ КАО ПРЕТХОДНИ ПОРЕЗ ",
                Desc = @"Укупан ПДВ који се у пореској пријави исказује као претходни порез (9а.1+9а.2+9а.3)",
                Iznos = 0,
                RedPrikaza = 6,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            }

            );
        }

        private static void DataPoPdvTab10(ZadrugaEntities context)
        {
            context.PoPdvTab10.AddOrUpdate(x => x.PoPdvTab10ID,
              new PoPdvTab10()
              {
                  PoPdvTab10ID = 1,
                  Oznaka = "10",
                  ParentDesc = "10. ПОРЕСКА ОБАВЕЗА (5.7-9а.4)",
                  Desc = @"10. ПОРЕСКА ОБАВЕЗА (5.7-9а.4)",
                  Iznos = 0,
                  RedPrikaza = 1,
                  BoldPozic = true,
                  created_at = DateTime.Now,
                  KORISNIK_ID = 0,
                  ObrPolje = true,
                  NaslovPolje = false,
                  UnosPolje = false
              }
            );
        }

        private static void DataPoPdvTab11(ZadrugaEntities context)
        {
            context.PoPdvTab11.AddOrUpdate(x => x.PoPdvTab11ID,
              new PoPdvTab11()
              {
                  PoPdvTab11ID = 1,
                  Oznaka = "11",
                  ParentDesc = "11. ПРОМЕТ ДОБАРА И УСЛУГА ИЗВРШЕН ВАН РЕПУБЛИКЕ И ДРУГИ ПРОМЕТ КОЈИ НЕ ПОДЛЕЖЕ ",
                  Desc = @"-",
                  Iznos = 0,
                  RedPrikaza = 1,
                  BoldPozic = true,
                  created_at = DateTime.Now,
                  KORISNIK_ID = 0,
                  ObrPolje = false,
                  NaslovPolje = true,
                  UnosPolje = false
              },
              new PoPdvTab11()
              {
                  PoPdvTab11ID = 2,
                  Oznaka = "11.1",
                  ParentDesc = "11. ПРОМЕТ ДОБАРА И УСЛУГА ИЗВРШЕН ВАН РЕПУБЛИКЕ И ДРУГИ ПРОМЕТ КОЈИ НЕ ПОДЛЕЖЕ ",
                  Desc = @"Промет добара и услуга извршен ван Републике ",
                  Iznos = 0,
                  RedPrikaza = 2,
                  BoldPozic = false,
                  created_at = DateTime.Now,
                  KORISNIK_ID = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab11()
              {
                  PoPdvTab11ID = 3,
                  Oznaka = "11.2",
                  ParentDesc = "11. ПРОМЕТ ДОБАРА И УСЛУГА ИЗВРШЕН ВАН РЕПУБЛИКЕ И ДРУГИ ПРОМЕТ КОЈИ НЕ ПОДЛЕЖЕ ",
                  Desc = @"Пренос целокупне, односно дела имовине у складу са чланом 6. став 1. тачка 1) Закона",
                  Iznos = 0,
                  RedPrikaza = 3,
                  BoldPozic = false,
                  created_at = DateTime.Now,
                  KORISNIK_ID = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              },
              new PoPdvTab11()
              {
                  PoPdvTab11ID = 4,
                  Oznaka = "11.3",
                  ParentDesc = "11. ПРОМЕТ ДОБАРА И УСЛУГА ИЗВРШЕН ВАН РЕПУБЛИКЕ И ДРУГИ ПРОМЕТ КОЈИ НЕ ПОДЛЕЖЕ ",
                  Desc = @"Промет добара и услуга из члана 6. Закона, осим из тачке 11.2",
                  Iznos = 0,
                  RedPrikaza = 4,
                  BoldPozic = false,
                  created_at = DateTime.Now,
                  KORISNIK_ID = 0,
                  ObrPolje = false,
                  NaslovPolje = false,
                  UnosPolje = true
              }
              );
        }


        private static void DataPoPdvTabGreska(ZadrugaEntities context)
        {
            context.PoPdvTabGreska.AddOrUpdate(x => x.PoPdvTabGreskaID,
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 1,
                Oznaka = "8a",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 1,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 2,
                Oznaka = "8a.1",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Први пренос права располагања на новоизграђеним грађевинским објектима ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 2,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 3,
                Oznaka = "8a.2",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Добра и услуге, осим добара из тачке 8а.1 ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 3,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 4,
                Oznaka = "8a.3",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Добра и услуге без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 4,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 5,
                Oznaka = "8a.4",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Измена основице за набављена добра и услуге и исправка одбитка претходног пореза по основу измене основице - повећање",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 5,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 6,
                Oznaka = "8a.5",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Измена основице за набављена добра и услуге и исправка одбитка претходног пореза по основу измене основице - смањење",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 6,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 7,
                Oznaka = "8a.6",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Укупна основица за набављена добра и услуге (8а.1+8а.2+8а.3+8а.4+8а.5)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 7,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 8,
                Oznaka = "8a.7",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Накнада или део накнаде који је плаћен пре извршеног промета и ПДВ по том основу (аванс)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 8,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 9,
                Oznaka = "8a.8",
                ParentDesc = "8 а Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник испоручилац добара, односно пружалац услуга ",
                Desc = @"Укупно обрачунати ПДВ од стране обвезника ПДВ - претходног учесника у промету (8а.1+8а.2+8а.3+8а.4+8а.5+8а.7)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 9,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 10,
                Oznaka = "8б",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 10,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 11,
                Oznaka = "8б.1",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Пренос права располагања на грађевинским објектима ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 11,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 12,
                Oznaka = "8б.2",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Добра и услуге, осим добара из тачке 8б.1",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 12,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 13,
                Oznaka = "8б.3",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Добра и услуге без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 13,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 14,
                Oznaka = "8б.4",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Измена основице за набављена добра и услуге - повећање ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 14,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 15,
                Oznaka = "8б.5",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Измена основице за набављена добра и услуге - смањење ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 15,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 16,
                Oznaka = "8б.6",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Укупна основица за набављена добра и услуге (8б.1+8б.2+8б.3+8б.4+8б.5)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 16,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 17,
                Oznaka = "8б.7",
                ParentDesc = "8 б Набавка добара и услуга у Републици од обвезника ПДВ - промет за који је порески дужник прималац добара, односно услуга ",
                Desc = @"Накнада или део накнаде који је плаћен пре извршеног промета (аванс)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 17,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 18,
                Oznaka = "8г",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 18,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 19,
                Oznaka = "8г.1",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Добра и услуге ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 19,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 20,
                Oznaka = "8г.2",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Добра и услуге без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 20,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 21,
                Oznaka = "8г.3",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Измена основице - повећање",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 21,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 22,
                Oznaka = "8г.4",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Измена основице - смањење",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 22,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 23,
                Oznaka = "8г.5",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Укупна основица за набављена добра и услуге (8г.1+8г.2+8г.3+8г.4)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 23,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 24,
                Oznaka = "8г.6",
                ParentDesc = "8 г Набавка добара и услуга у Републици од страних лица која нису обвезници ПДВ - промет за који постоји обавеза обрачунавања ПДВ",
                Desc = @"Накнада или део накнаде плаћен пре извршеног промета (аванс)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 24,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 25,
                Oznaka = "8д",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 25,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 26,
                Oznaka = "8д.1",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"Добра и услуге набављени у Републици од страних лица која нису обвезници ПДВ - промет за који не постоји обавеза обрачунавања ПДВ, као и повећање, односно смањење накнаде за та добра и услуге, укључујући и набавку без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 26,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 27,
                Oznaka = "8д.2",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"Добра и услуге набављени у Републици од лица са територије Републике која нису обвезници ПДВ, као и повећање, односно смањење накнаде за та добра и услуге, укључујући и набавку без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 27,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 27,
                Oznaka = "8д.3",
                ParentDesc = "8д Набавка добара и услуга, осим из тач. 8а до 8г",
                Desc = @"Добра и услуге набављени ван Републике, као и повећање, односно смањење накнаде за та добра и услуге, укључујући и набавку без накнаде",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 28,
                BoldPozic = false,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 28,
                Oznaka = "8ђ",
                ParentDesc = "Укупна основица, накнада, односно вредност набављених добара и услуга (8а.6+8б.6+8в.4+8г.5+8д.1+8д.2+8д.3)",
                Desc = @"Укупна основица, накнада, односно вредност набављених добара и услуга (8а.6+8б.6+8в.4+8г.5+8д.1+8д.2+8д.3) ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 28,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 29,
                Oznaka = "8е",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"-",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 29,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = true,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 30,
                Oznaka = "8е.1",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет набављених добара и услуга за који је порески дужник обвезник ПДВ - испоручилац добара, односно пружалац услуга, а који се може одбити као претходни порез (8а.8 умањен за износ ПДВ који се не може одбити као претходни порез)".Substring(0, 249),
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 30,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 31,
                Oznaka = "8е.2",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет набављених добара и услуга за који је порески дужник обвезник ПДВ - прималац добара, односно услуга, а који се може одбити као претходни порез (3а.9 умањен за износ ПДВ који се не може одбити као претходни порез)".Substring(0, 249),
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 31,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 32,
                Oznaka = "8е.3",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Исправка одбитка - повећање претходног пореза, осим по основу измене основице за промет добара и услуга и по основу увоза добара",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 32,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 33,
                Oznaka = "8е.4",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Исправка одбитка - смањење претходног пореза, осим по основу измене основице за промет добара и услуга",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 33,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = false,
                NaslovPolje = false,
                UnosPolje = true
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 34,
                Oznaka = "8е.5",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет добара и услуга који се може одбити као претходни порез (8е.1+8е.2+8е.3+8е.4)",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 34,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            },
            new PoPdvTabGreska()
            {
                PoPdvTabGreskaID = 35,
                Oznaka = "8е.6",
                ParentDesc = "8е ПДВ ЗА ПРОМЕТ ДОБАРА И УСЛУГА КОЈИ СЕ МОЖЕ ОДБИТИ КАО ПРЕТХОДНИ ПОРЕЗ И ИСПРАВКЕ ОДБИТКА ПРЕТХОДНОГ ПОРЕЗА ",
                Desc = @"Укупно обрачунати ПДВ за промет добара и услуга који се може одбити као претходни порез увећан за износ за који се не може умањити обрачунати ПДВ (8е.5+(5.2+5.5 у апсолутном износу)) ",
                OS_osnov = 0,
                OS_pdv = 0,
                PS_osnov = 0,
                PS_pdv = 0,
                Naknada = 0,
                Iznos = 0,
                RedPrikaza = 35,
                BoldPozic = true,
                created_at = DateTime.Now,
                KORISNIK_ID = 0,
                ObrPolje = true,
                NaslovPolje = false,
                UnosPolje = false
            }
             );
        }

    }
}
