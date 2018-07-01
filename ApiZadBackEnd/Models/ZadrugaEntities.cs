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
        public DbSet<PoPdvTab01> PoPdvTab01 { get; set; }
        public DbSet<PoPdvTab02> PoPdvTab02 { get; set; }
        public DbSet<PoPdvTab03> PoPdvTab03 { get; set; }
        public DbSet<PoPdvTab03A> PoPdvTab03A { get; set; }
        public DbSet<PoPdvTab04> PoPdvTab04 { get; set; }
        public DbSet<PoPdvTab05> PoPdvTab05 { get; set; }
        public DbSet<PoPdvTab06> PoPdvTab06 { get; set; }
        public DbSet<PoPdvTab07> PoPdvTab07 { get; set; }
        public DbSet<PoPdvTab08> PoPdvTab08 { get; set; }

        public DbSet<PoPdvTab09> PoPdvTab09 { get; set; }
        public DbSet<PoPdvTab10> PoPdvTab10 { get; set; }
        public DbSet<PoPdvTab11> PoPdvTab11 { get; set; }
        //PoPdvTabGreska
        //public DbSet<PoPdvTabGreska> PoPdvTabGreska { get; set; }
        //LabelPoPdv
        public DbSet<LabelPoPdv> LabelPoPdv { get; set; }

        protected override void OnModelCreating(DbModelBuilder ModelBuilder)
        {
            ModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}