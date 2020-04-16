using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAHealthQueries.Models
{
    public partial class CA_DATAContext : DbContext
    {
        public CA_DATAContext(DbContextOptions<CA_DATAContext> options)
            : base(options)
        {
           
        }

        public virtual DbSet<HealthcareFacilityBeds> HealthcareFacilityBeds { get; set; }
        public virtual DbSet<HealthcareFacilityLocations> HealthcareFacilityLocations { get; set; }
        public virtual DbSet<HealthcareFacilityServices> HealthcareFacilityServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HealthcareFacilityBeds>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Facid)
                    .HasName("NonClusteredIndex-20200329-134821");

                entity.Property(e => e.Facid).IsUnicode(false);
            });

            modelBuilder.Entity<HealthcareFacilityLocations>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Facid)
                    .HasName("NonClusteredIndex-20200328-182636");

                entity.Property(e => e.Facid).IsUnicode(false);

                entity.Property(e => e.FipsCountyCode).IsUnicode(false);

                entity.Property(e => e.LicenseNumber).IsUnicode(false);

                entity.Property(e => e.Npi).IsUnicode(false);

                entity.Property(e => e.OshpdId).IsUnicode(false);
            });

            modelBuilder.Entity<HealthcareFacilityServices>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Facid)
                    .HasName("NonClusteredIndex-20200329-134742");

                entity.Property(e => e.Facid).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
