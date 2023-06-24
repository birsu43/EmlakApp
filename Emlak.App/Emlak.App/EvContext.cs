using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.App
{
    public class EvContext:DbContext
    {
        public DbSet<Ev> Evler { get; set; }
        public DbSet<Admin> Adminler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmlakDeneme;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ev>().ToTable("tblEv");
            modelBuilder.Entity<Ev>().Property(o => o.Semt).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Admin>().ToTable("tblAdmin");
            modelBuilder.Entity<Admin>().HasIndex(o=>o.KullaniciAd).IsUnique();
            modelBuilder.Entity<Admin>().Property(o => o.KullaniciAd).HasColumnType("varchar").HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Admin>().Property(o => o.Sifre).HasColumnType("varchar").HasMaxLength(30).IsRequired();



        }
    }
}
