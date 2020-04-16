using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CAHealthQueries.NPPES
{
    public partial class NPPESContext : DbContext
    {
        public NPPESContext(DbContextOptions<NPPESContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HealthcareFacilityBeds> HealthcareFacilityBeds { get; set; }
        public virtual DbSet<HealthcareFacilityLocations> HealthcareFacilityLocations { get; set; }
        public virtual DbSet<HealthcareFacilityServices> HealthcareFacilityServices { get; set; }
        public virtual DbSet<NpiOthProv> NpiOthProv { get; set; }
        public virtual DbSet<NpiTaxonomy> NpiTaxonomy { get; set; }
        public virtual DbSet<Npidata> Npidata { get; set; }
        public virtual DbSet<ProvLoc> ProvLoc { get; set; }
        public virtual DbSet<Txcodes> Txcodes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HealthcareFacilityBeds>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HealthcareFacilityLocations>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<HealthcareFacilityServices>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<NpiOthProv>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Npi)
                    .HasName("npi_oth_prov_idx");

                entity.Property(e => e.OtherProviderIdentifier).IsUnicode(false);

                entity.Property(e => e.OtherProviderIdentifierIssuer).IsUnicode(false);

                entity.Property(e => e.OtherProviderIdentifierState).IsUnicode(false);

                entity.Property(e => e.OtherProviderIdentifierTypeCode).IsUnicode(false);
            });

            modelBuilder.Entity<NpiTaxonomy>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Npi)
                    .HasName("npi_tax_idx");

                entity.Property(e => e.HealthcareProviderPrimaryTaxonomySwitch).IsUnicode(false);

                entity.Property(e => e.HealthcareProviderTaxonomyCode).IsUnicode(false);

                entity.Property(e => e.HealthcareProviderTaxonomyGroup).IsUnicode(false);

                entity.Property(e => e.ProviderLicenseNumber).IsUnicode(false);

                entity.Property(e => e.ProviderLicenseNumberStateCode).IsUnicode(false);
            });

            modelBuilder.Entity<Npidata>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Npi)
                    .HasName("npi_idx");

                entity.Property(e => e.AuthorizedOfficialCredentialText).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialFirstName).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialLastName).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialMiddleName).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialNamePrefixText).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialNameSuffixText).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialTelephoneNumber).IsUnicode(false);

                entity.Property(e => e.AuthorizedOfficialTitleOrPosition).IsUnicode(false);

                entity.Property(e => e.EmployerIdentificationNumber).IsUnicode(false);

                entity.Property(e => e.IsOrganizationSubpart).IsUnicode(false);

                entity.Property(e => e.IsSoleProprietor).IsUnicode(false);

                entity.Property(e => e.NpiDeactivationReasonCode).IsUnicode(false);

                entity.Property(e => e.ParentOrganizationLbn).IsUnicode(false);

                entity.Property(e => e.ParentOrganizationTin).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessMailingAddressCityName).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessMailingAddressCountryCode).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessMailingAddressFaxNumber).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessMailingAddressPostalCode).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessMailingAddressStateName).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessMailingAddressTelephoneNumber).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessPracticeLocationAddressCityName).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessPracticeLocationAddressCountryCode).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessPracticeLocationAddressFaxNumber).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessPracticeLocationAddressPostalCode).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessPracticeLocationAddressStateName).IsUnicode(false);

                entity.Property(e => e.ProviderBusinessPracticeLocationAddressTelephoneNumber).IsUnicode(false);

                entity.Property(e => e.ProviderCredentialText).IsUnicode(false);

                entity.Property(e => e.ProviderFirstLineBusinessMailingAddress).IsUnicode(false);

                entity.Property(e => e.ProviderFirstLineBusinessPracticeLocationAddress).IsUnicode(false);

                entity.Property(e => e.ProviderFirstName).IsUnicode(false);

                entity.Property(e => e.ProviderGenderCode).IsUnicode(false);

                entity.Property(e => e.ProviderLastName).IsUnicode(false);

                entity.Property(e => e.ProviderMiddleName).IsUnicode(false);

                entity.Property(e => e.ProviderNamePrefixText).IsUnicode(false);

                entity.Property(e => e.ProviderNameSuffixText).IsUnicode(false);

                entity.Property(e => e.ProviderOrgName).IsUnicode(false);

                entity.Property(e => e.ProviderOtherCredentialText).IsUnicode(false);

                entity.Property(e => e.ProviderOtherFirstName).IsUnicode(false);

                entity.Property(e => e.ProviderOtherLastName).IsUnicode(false);

                entity.Property(e => e.ProviderOtherMiddleName).IsUnicode(false);

                entity.Property(e => e.ProviderOtherNamePrefixText).IsUnicode(false);

                entity.Property(e => e.ProviderOtherNameSuffixText).IsUnicode(false);

                entity.Property(e => e.ProviderOtherOrganizationName).IsUnicode(false);

                entity.Property(e => e.ProviderOtherOrganizationNameTypeCode).IsUnicode(false);

                entity.Property(e => e.ProviderSecondLineBusinessMailingAddress).IsUnicode(false);

                entity.Property(e => e.ProviderSecondLineBusinessPracticeLocationAddress).IsUnicode(false);
            });

            modelBuilder.Entity<ProvLoc>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Npi)
                    .HasName("prov_loc_idx");

                entity.Property(e => e.ProviderSecondarPracticeLocationAddressFaxNumber).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressCityName).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressCountryCode).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressLine1).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressLine2).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressPostalCode).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressStateName).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressTelephoneExt).IsUnicode(false);

                entity.Property(e => e.ProviderSecondaryPracticeLocationAddressTelephoneNumber).IsUnicode(false);
            });

            modelBuilder.Entity<Txcodes>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Code)
                    .HasName("txcodes_idx");

                entity.Property(e => e.Code).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
