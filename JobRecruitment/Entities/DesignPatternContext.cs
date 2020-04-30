using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JobRecruitment.Entities
{
    public partial class DesignPatternContext : DbContext
    {
        public DesignPatternContext()
        {
        }

        public DesignPatternContext(DbContextOptions<DesignPatternContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Companys> Companys { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<RequireMent> RequireMent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.;database=DesignPattern;uid=sa;pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_CITIES");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Companys>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK_COMPANYS");

                entity.Property(e => e.CompanyId).ValueGeneratedNever();

                entity.Property(e => e.CompanyAddress).HasMaxLength(50);

                entity.Property(e => e.CompanyIntroduce).HasMaxLength(50);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyNature)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanySize).HasMaxLength(50);

                entity.Property(e => e.IndustryType).HasMaxLength(50);
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId)
                    .HasName("PK_JOBS");

                entity.Property(e => e.JobId).ValueGeneratedNever();

                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.JobPay)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PositionInfo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PublishTime).HasColumnType("datetime");

                entity.Property(e => e.Welfare)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkArea)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkExperience)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_JOBS_REFERENCE_CITIES");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_JOBS_REFERENCE_COMPANYS");
            });

            modelBuilder.Entity<RequireMent>(entity =>
            {
                entity.Property(e => e.RequireMentId).ValueGeneratedNever();

                entity.Property(e => e.Education)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Welfare)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
