using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;

namespace ApiZadBackEnd.Models
{
    public class ZadrugaEntities : DbContext
    {
        public ZadrugaEntities() : base("name=ZadrugaEntities")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

        }

        public DbSet<sfBanke> sfBanke { get; set; }
        public DbSet<sfDrzave> sfDrzave { get; set; }
        public DbSet<sfMesta> sfMesta { get; set; }
        public DbSet<sfOpstine> sfOpstine { get; set; }
        public DbSet<PoPdvTab1> PoPdvTab1 { get; set; }
        public DbSet<PoPdvTab2> PoPdvTab2 { get; set; }
        public DbSet<PoPdvTab3> PoPdvTab3 { get; set; }
        public DbSet<PoPdvTab3A> PoPdvTab3A { get; set; }
        public DbSet<PoPdvTab4> PoPdvTab4 { get; set; }
        public DbSet<PoPdvTab5> PoPdvTab5 { get; set; }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}