using System;
using EFCore.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Mayor> Mayors { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EFCoreDB;Trusted_Connection=True;");
        //}

        public DbSet<CityCompany> CityCompanies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityCompany>().HasKey(x => new { x.CityId, x.CompanyId });
            modelBuilder.Entity<CityCompany>().HasOne(x => x.City).WithMany(x => x.CityCompanies)
                .HasForeignKey(x => x.CityId);
            modelBuilder.Entity<CityCompany>().HasOne(x => x.Company).WithMany(x => x.CityCompanies)
                .HasForeignKey(x => x.CompanyId);
            modelBuilder.Entity<Mayor>().HasOne(x => x.City).WithOne(x => x.Mayor).HasForeignKey<Mayor>(x => x.CityId);
        }
    }
}