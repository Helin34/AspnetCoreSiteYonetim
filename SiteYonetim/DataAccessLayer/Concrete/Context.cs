using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-MFSA08GG\\MYDATABASESERVER;database=SiteYonetim; " +
                "integrated security=true;");



        }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Daire> Daires{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<KiraciMalSahibi> KiraciMalSahibis { get; set; }
        public DbSet<Gider> Giders { get; set; }
        public DbSet<Aidat> Aidats  { get; set; }
        public DbSet<Bilgi> Bilgis { get; set; }
        public DbSet<Ev> Evs { get; set; }










    }
}
