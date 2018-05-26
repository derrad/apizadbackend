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

                //  context.sfDrzave.AddOrUpdate(x => x.DrzaveID,
                //      new sfDrzave() { DrzaveID = 1, Naziv = "SRBIJA", KodDrzave = "SRB", NameUser = "System", Opis = "prvi da vidim ide li", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 2, Naziv = "BOSNA I HERCEGOVINA", KodDrzave = "BIH", NameUser = "saska@saska.com", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 3, Naziv = "RUMUNIJA", KodDrzave = "ROM", NameUser = "radivoje@deretic.net", EuClan = true, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 4, KodDrzave = "MNG", Naziv = "Crna Gora", Opis = "Provera", NameUser = "saska@saska.com", created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 5, KodDrzave = "SLK", Naziv = "Slovačka", Opis = "Provera opet", NameUser = "radivoje@deretic.net", EuClan = true, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 6, KodDrzave = "JEM", Naziv = "JEMEN", NameUser = "radivoje@deretic.net", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 7, KodDrzave = "BEL", Naziv = "Belgija", Opis = "Opis kod insert sloga", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 8, KodDrzave = "POL", Naziv = "Poljska", Opis = "prvi put update, drugi put update", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 9, KodDrzave = "LTU", Naziv = "Litvanija", NameUser = "saska@saska.com", EuClan = true, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 10, KodDrzave = "KNA", Naziv = "Sent Kits i Nevis", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 11, KodDrzave = "SWE", Naziv = "Švedska", EuClan = true, NameUser = "saska@saska.com", created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 12, KodDrzave = "ESH", Naziv = "Zapadna sahara", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 13, KodDrzave = "JOR", Naziv = "Jordan", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 14, KodDrzave = "ZAF", Naziv = "Južnoafrička republika", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 15, KodDrzave = "HMD", Naziv = "Herd i MekDonald ostrva", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 16, KodDrzave = "SYR", Naziv = "Sirija", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 17, KodDrzave = "SXM", Naziv = "Sent Martin", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 18, KodDrzave = "PCN", Naziv = "Pitkern", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 19, KodDrzave = "LIE", Naziv = "Lihtenštajn", EuClan = true, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 20, KodDrzave = "COM", Naziv = "Komorska ostrva", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 21, KodDrzave = "BRB", Naziv = "Barbados", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 22, KodDrzave = "HTI", Naziv = "Haiti", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 23, KodDrzave = "ALB", Naziv = "Albanija", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 24, KodDrzave = "COD", Naziv = "Kongo", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 25, KodDrzave = "MTQ", Naziv = "Matinik", EuClan = false, created_at = DateTime.Now },
                //      new sfDrzave() { DrzaveID = 26, KodDrzave = "CYP", Naziv = "Kipar", EuClan = true, NameUser = "saska@saska.com", created_at = DateTime.Now }
                //  );


                //  context.sfOpstine.AddOrUpdate(x => x.OpstineID,
                //      new sfOpstine() { OpstineID = 1, DrzaveID = 1, RegOzn = "BAN", Naziv = "Pančevo", NameUser = "System", created_at = DateTime.Now },
                //      new sfOpstine() { OpstineID = 2, DrzaveID = 1, RegOzn = "BAN", Naziv = "Vršac", NameUser = "System", created_at = DateTime.Now },
                //      new sfOpstine() { OpstineID = 3, DrzaveID = 1, RegOzn = "BAN", Naziv = "Kovin", NameUser = "System", created_at = DateTime.Now },
                //      new sfOpstine() { OpstineID = 4, DrzaveID = 1, RegOzn = "BAN", Naziv = "Alibunar", NameUser = "System", created_at = DateTime.Now },
                //      new sfOpstine() { OpstineID = 5, DrzaveID = 1, RegOzn = "BAN", Naziv = "Plandište", NameUser = "System", created_at = DateTime.Now },
                //      new sfOpstine() { OpstineID = 6, DrzaveID = 1, RegOzn = "BAN", Naziv = "Kovačica", NameUser = "System", created_at = DateTime.Now },
                //      new sfOpstine() { OpstineID = 7, DrzaveID = 1, RegOzn = "BAN", Naziv = "Zrenjanin", NameUser = "System", created_at = DateTime.Now }

                //   );

                //  context.sfMesta.AddOrUpdate(x => x.MestaID,
                //    new sfMesta() { MestaID = 1, OpstineID = 1, Naziv = "Pančevo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                //    new sfMesta() { MestaID = 2, OpstineID = 1, Naziv = "Jabuka", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                //    new sfMesta() { MestaID = 3, OpstineID = 1, Naziv = "Dolovo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                //    new sfMesta() { MestaID = 4, OpstineID = 1, Naziv = "Starčevo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                //    new sfMesta() { MestaID = 5, OpstineID = 1, Naziv = "Omoljica", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                //    new sfMesta() { MestaID = 6, OpstineID = 1, Naziv = "Ivanovo", Ptt = "26000", NameUser = "System", created_at = DateTime.Now },
                //    new sfMesta() { MestaID = 7, OpstineID = 1, Naziv = "Banatski Brestovac", Ptt = "26000", NameUser = "System", created_at = DateTime.Now }

                //   );

                //  context.sfBanke.AddOrUpdate(x => x.BankeID,
                //   new sfBanke() { BankeID = 1, Naziv = "Banka Inteza", Racun = "160-959-6999", NameUser = "System", created_at = DateTime.Now },
                //   new sfBanke() { BankeID = 2, Naziv = "Aik Banka", Racun = "150-985-9699", NameUser = "System", created_at = DateTime.Now },
                //   new sfBanke() { BankeID = 3, Naziv = "Aik Banka1", Racun = "150-6985-9699", NameUser = "System", created_at = DateTime.Now }


                //);


                //   context.PoPdvTab1.AddOrUpdate(x => x.PoPdvTab1ID,
                //     new PoPdvTab1() { PoPdvTab1ID = 1, Oznaka = "1.1", Desc = @"Промет добара која се отпремају у иностранство, укључујући и повећање, односно смањење накнаде за тај промет", RedPrikaza = 1, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, Naknada = 0 },
                //     new PoPdvTab1() { PoPdvTab1ID = 2, Oznaka = "1.2", Desc = @"Промет добара која се отпремaју на територију Аутономне покрајине Косово и Метохија, укључујући и повећање, односно смањење накнаде за тај промет ", RedPrikaza = 2, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, Naknada = 0 },
                //     new PoPdvTab1() { PoPdvTab1ID = 3, Oznaka = "1.3", Desc = @"Промет добара која се уносе у слободну зону и промет добара и услуга у слободној зони, укључујући и повећање", RedPrikaza = 3, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, Naknada = 0 },
                //     new PoPdvTab1() { PoPdvTab1ID = 4, Oznaka = "1.4", Desc = @"Промет добара и  услуга, осим из тач. 1.1 до 1.3, укључујући и повећање, односно смањење накнаде за тај промет", RedPrikaza = 4, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, Naknada = 0 },
                //     new PoPdvTab1() { PoPdvTab1ID = 5, Oznaka = "1.5", Desc = @"Укупан промет (1.1+1.2+1.3+1.4)", RedPrikaza = 5, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Naknada = 0 },
                //     new PoPdvTab1() { PoPdvTab1ID = 6, Oznaka = "1.6", Desc = @"Промет добара и услуга без накнаде", RedPrikaza = 6, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, Naknada = 0 },
                //     new PoPdvTab1() { PoPdvTab1ID = 7, Oznaka = "1.7", Desc = @"Накнада или део накнаде наплаћен пре извршеног промета (аванс)", RedPrikaza = 7, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, Naknada = 0 }

                //);

                context.PoPdvTab2.AddOrUpdate(x => x.PoPdvTab2ID,
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 1,
                        Oznaka = "2.1",
                        Desc = @"Промет новца и капитала, укључујући и повећање, односно смањење накнаде за тај промет",
                        Naknada = 0,
                        RedPrikaza = 1,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    },
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 2,
                        Oznaka = "2.2",
                        Desc = @"Промет земљишта и давање у закуп земљишта, укључујући и повећање, односно смањење накнаде за тај промет",
                        Naknada = 0,
                        RedPrikaza = 2,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    },
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 3,
                        Oznaka = "2.3",
                        Desc = @"Промет објекaта, укључујући и повећање, односно смањење накнаде за тај промет",
                        Naknada = 0,
                        RedPrikaza = 3,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    },
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 4,
                        Oznaka = "2.4",
                        Desc = @"Промет добара и услуга, осим из тач. 2.1 до 2.3, укључујући и повећање, односно смањење накнаде за тај промет ",
                        Naknada = 0,
                        RedPrikaza = 4,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    },
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 5,
                        Oznaka = "2.5",
                        Desc = @"Укупан промет (2.1+2.2+2.3+2.4)",
                        Naknada = 0,
                        RedPrikaza = 5,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    },
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 6,
                        Oznaka = "2.6",
                        Desc = @"Промет добара и услуга без накнаде ",
                        Naknada = 0,
                        RedPrikaza = 6,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    },
                    new PoPdvTab2()
                    {
                        PoPdvTab2ID = 7,
                        Oznaka = "2.7",
                        Desc = @"Накнада или део накнаде наплаћен пре извршеног промета (аванс)",
                        Naknada = 0,
                        RedPrikaza = 7,
                        BoldPozic = false,
                        created_at = DateTime.Now,
                        KORISNIK_ID = 0
                    }
                  );


                //  context.PoPdvTab3.AddOrUpdate(x => x.PoPdvTab3ID,
                //      new PoPdvTab3() { PoPdvTab3ID = 1, Oznaka = "3.1", Desc = @"Први пренос права располагања на новоизграђеним грађевинским објектима за који је порески дужник обвезник ПДВ који врши тај промет ", RedPrikaza = 1, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 2, Oznaka = "3.2", Desc = @"Промет за који је порески дужник обвезник ПДВ који врши тај промет, осим из тачке 3.1", RedPrikaza = 2, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 3, Oznaka = "3.3", Desc = @"Пренос права располагања на грађевинским објектима за који обвезник ПДВ који врши тај промет није порески дужник", RedPrikaza = 3, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 4, Oznaka = "3.4", Desc = @"Промет за који обвезник ПДВ који врши тај промет није порески дужник, осим из тачке 3.3 ", RedPrikaza = 4, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 5, Oznaka = "3.5", Desc = @"Повећање основице, односно ПДВ", RedPrikaza = 5, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 6, Oznaka = "3.6", Desc = @"Смањење основице, односно ПДВ ", RedPrikaza = 6, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 7, Oznaka = "3.7", Desc = @"Промет добара и услуга без накнаде ", RedPrikaza = 7, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 8, Oznaka = "3.8", Desc = @"Укупна основица и обрачунати ПДВ за промет добара и услуга (3.1+3.2+3.3+3.4+3.5+3.6+3.7) ", RedPrikaza = 8, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 9, Oznaka = "3.9", Desc = @"Накнада или део накнаде који је наплаћен пре извршеног промета и ПДВ обрачунат по том основу (аванс)", RedPrikaza = 9, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 },
                //      new PoPdvTab3() { PoPdvTab3ID = 10, Oznaka = "3.10", Desc = @"Укупно обрачунати ПДВ (3.8+3.9)", RedPrikaza = 10, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_osnov = 0, OS_pdv = 0, PS_osnov = 0, PS_pdv = 0 }
                //   );

                //  context.PoPdvTab3A.AddOrUpdate(x => x.PoPdvTab3AID,
                //   new PoPdvTab3A() { PoPdvTab3AID = 1, Oznaka = "3a.1", Desc = @"ПДВ за пренос права располагања на грађевинским објектима за који је порески дужник обвезник ПДВ - прималац добара", RedPrikaza = 1, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 2, Oznaka = "3a.2", Desc = @"ПДВ за промет добара и услуга који у Републици врши страно лице које није обвезник ПДВ, за који је порески дужник обвезник ПДВ - прималац добара и услуга", RedPrikaza = 2, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 3, Oznaka = "3a.3", Desc = @"ПДВ за промет добара и услуга за који је порески дужник обвезник ПДВ - прималац добара и услуга, осим из тач. 3а.1 и 3а.2, укључујући и ПДВ обрачунат у складу са чланом 10. став 3. Закона", RedPrikaza = 3, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 4, Oznaka = "3a.4", Desc = @"Повећање обрачунатог ПДВ", RedPrikaza = 4, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 5, Oznaka = "3a.5", Desc = @"Смањење обрачунатог ПДВ", RedPrikaza = 5, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 6, Oznaka = "3a.6", Desc = @"ПДВ за промет добара и услуга без накнаде", RedPrikaza = 6, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 7, Oznaka = "3a.7", Desc = @"Укупно обрачунати ПДВ за промет добара и услуга (3а.1+3а.2+3а.3+3а.4+3а.5+3а.6)", RedPrikaza = 7, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 8, Oznaka = "3a.8", Desc = @"ПДВ пo основу накнаде или дела накнаде који је плаћен пре извршеног промета (аванс)", RedPrikaza = 8, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = false, OS_pdv = 0, PS_pdv = 0 },
                //   new PoPdvTab3A() { PoPdvTab3AID = 9, Oznaka = "3a.9", Desc = @"Укупно обрачунати ПДВ (3а.7+3а.8)", RedPrikaza = 9, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, OS_pdv = 0, PS_pdv = 0 }
                //);


                // context.PoPdvTab4.AddOrUpdate(x => x.PoPdvTab4ID,
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 1,
                //                Oznaka = "4.1.1",
                //                ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                //                Desc = @"Накнада коју плаћају путници, укључујући и повећање, односно смањење те накнаде ",
                //                RedPrikaza = 1,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 2,
                //                Oznaka = "4.1.2",
                //                ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                //                Desc = @"Стварни трошкови за претходне туристичке услуге, укључујући и повећање, односно смањење тих трошкова ",
                //                RedPrikaza = 2,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 3,
                //                Oznaka = "4.1.3",
                //                ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                //                Desc = @"Разлика (4.1.1 – 4.1.2) ",
                //                RedPrikaza = 3,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 4,
                //                Oznaka = "4.1.4",
                //                ParentDesc = "4.1 Туристичке агенције Утврђивање ",
                //                Desc = @"Обрачунати  ПДВ",
                //                RedPrikaza = 4,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 5,
                //                Oznaka = "4.2.1",
                //                ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                //                Desc = @"Продајна цена добара, укључујући и повећање, односно смањење те цене ",
                //                RedPrikaza = 5,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 6,
                //                Oznaka = "4.2.2",
                //                ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                //                Desc = @"Набавна цена добара, укључујући и повећање, односно смањење те цене ",
                //                RedPrikaza = 6,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 7,
                //                Oznaka = "4.2.3",
                //                ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                //                Desc = @"Разлика (4.2.1 – 4.2.2)",
                //                RedPrikaza = 6,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            },
                //            new PoPdvTab4()
                //            {
                //                PoPdvTab4ID = 8,
                //                Oznaka = "4.2.4",
                //                ParentDesc = "4.2 Половна добра, уметничка дела, колекционарска добра и антиквитети",
                //                Desc = @"Обрачунати  ПДВ",
                //                RedPrikaza = 8,
                //                KORISNIK_ID = 0,
                //                created_at = DateTime.Now,
                //                BoldPozic = false,
                //                Osnovica = 0,
                //                Pdv = 0,
                //                PS_osnov = 0,
                //                OS_osnov = 0,
                //                OS_pdv = 0,
                //                PS_pdv = 0
                //            }

                //  );


                // context.PoPdvTab5.AddOrUpdate(x => x.PoPdvTab5ID,
                //  new PoPdvTab5() { PoPdvTab5ID = 1, Oznaka = "5.1", Desc = @"Укупан опорезиви промет добара и услуга по општој стопи ПДВ (3.8+4.1.1+4.2.1) ", RedPrikaza = 1, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 2, Oznaka = "5.2", Desc = @"Укупно обрачунати ПДВ по општој стопи ПДВ (3.10+3а.9+4.1.4+4.2.4)", RedPrikaza = 2, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 3, Oznaka = "5.3", Desc = @"Укупно обрачунати ПДВ по општој стопи ПДВ увећан за износ за који се не може умањити претходни порез из тачке 8е.6 (5.2+(8е.6 у апсолутном износу))", RedPrikaza = 3, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 4, Oznaka = "5.4", Desc = @"Укупан опорезиви промет добара и услуга по посебној стопи ПДВ (3.8+4.2.1)", RedPrikaza = 4, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 5, Oznaka = "5.5", Desc = @"Укупно обрачунати ПДВ по посебној стопи ПДВ (3.10+3а.9+4.2.4)", RedPrikaza = 5, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 6, Oznaka = "5.6", Desc = @"Укупан промет добара и услуга (1.5+2.5+5.1+5.4)", RedPrikaza = 6, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 7, Oznaka = "5.7", Desc = @"Укупно обрачунати ПДВ (5.3+5.5)", RedPrikaza = 7, KORISNIK_ID = 0, created_at = DateTime.Now, BoldPozic = true, Iznos = 0 }
                //);


                //    context.PoPdvTab5.AddOrUpdate(x => x.PoPdvTab5ID,
                //  new PoPdvTab5() { PoPdvTab5ID = 1, Oznaka = "5.1", Desc = @"A", Iznos = 0, RedPrikaza = 1, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 2, Oznaka = "5.2", Desc = @"", Iznos = 0, RedPrikaza = 2, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 3, Oznaka = "5.3", Desc = @"", Iznos = 0, RedPrikaza = 3, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 4, Oznaka = "5.4", Desc = @"", Iznos = 0, RedPrikaza = 4, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 5, Oznaka = "5.5", Desc = @"", Iznos = 0, RedPrikaza = 5, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 6, Oznaka = "5.6", Desc = @"", Iznos = 0, RedPrikaza = 6, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 },
                //  new PoPdvTab5() { PoPdvTab5ID = 7, Oznaka = "5.7", Desc = @"", Iznos = 0, RedPrikaza = 7, BoldPozic = true, created_at = DateTime.Now, KORISNIK_ID = 0 }
                //);


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
    }
}
