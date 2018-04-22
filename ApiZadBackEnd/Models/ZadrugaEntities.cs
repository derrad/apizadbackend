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

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}