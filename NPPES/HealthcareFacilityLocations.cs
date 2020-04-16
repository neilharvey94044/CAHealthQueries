using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("healthcare_facility_locations")]
    public partial class HealthcareFacilityLocations
    {
        [Column("FACID", TypeName = "numeric(18, 0)")]
        public decimal? Facid { get; set; }
        [Column("NPI", TypeName = "numeric(18, 0)")]
        public decimal? Npi { get; set; }
        [Required]
        [Column("FACNAME")]
        [StringLength(100)]
        public string Facname { get; set; }
        [Required]
        [Column("FAC_TYPE_CODE")]
        [StringLength(50)]
        public string FacTypeCode { get; set; }
        [Required]
        [Column("FAC_FDR")]
        [StringLength(50)]
        public string FacFdr { get; set; }
        [Required]
        [Column("LTC")]
        [StringLength(50)]
        public string Ltc { get; set; }
        [Column("CAPACITY")]
        public int Capacity { get; set; }
        [Required]
        [Column("ADDRESS")]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [Column("CITY")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("ZIP")]
        public int? Zip { get; set; }
        [Column("ZIP9")]
        public int? Zip9 { get; set; }
        [Column("FACADMIN")]
        [StringLength(50)]
        public string Facadmin { get; set; }
        [Column("CONTACT_EMAIL")]
        [StringLength(50)]
        public string ContactEmail { get; set; }
        [Column("CONTACT_FAX")]
        [StringLength(50)]
        public string ContactFax { get; set; }
        [Column("CONTACT_PHONE_NUMBER")]
        [StringLength(50)]
        public string ContactPhoneNumber { get; set; }
        [Required]
        [Column("COUNTY_CODE")]
        [StringLength(50)]
        public string CountyCode { get; set; }
        [Required]
        [Column("COUNTY_NAME")]
        [StringLength(50)]
        public string CountyName { get; set; }
        [Column("DISTRICT_NUMBER")]
        public int? DistrictNumber { get; set; }
        [Required]
        [Column("DISTRICT_NAME")]
        [StringLength(50)]
        public string DistrictName { get; set; }
        [Required]
        [Column("ISFACMAIN")]
        [StringLength(50)]
        public string Isfacmain { get; set; }
        [Column("LICENSE_NUMBER")]
        [StringLength(15)]
        public string LicenseNumber { get; set; }
        [Column("BUSINESS_NAME")]
        [StringLength(100)]
        public string BusinessName { get; set; }
        [Column("INITIAL_LICENSE_DATE", TypeName = "date")]
        public DateTime? InitialLicenseDate { get; set; }
        [Column("LICENSE_EFFECTIVE_DATE", TypeName = "date")]
        public DateTime? LicenseEffectiveDate { get; set; }
        [Column("LICENSE_EXPIRATION_DATE", TypeName = "date")]
        public DateTime? LicenseExpirationDate { get; set; }
        [Column("ENTITY_TYPE_DESCRIPTION")]
        [StringLength(50)]
        public string EntityTypeDescription { get; set; }
        [Column("LATITUDE")]
        public double? Latitude { get; set; }
        [Column("LONGITUDE")]
        public double? Longitude { get; set; }
        [Required]
        [Column("LOCATION")]
        [StringLength(50)]
        public string Location { get; set; }
        [Column("OSHPD_ID")]
        [StringLength(15)]
        public string OshpdId { get; set; }
        [Required]
        [Column("STREETNUM")]
        [StringLength(50)]
        public string Streetnum { get; set; }
        [Required]
        [Column("STREETNAME")]
        [StringLength(50)]
        public string Streetname { get; set; }
        [Required]
        [Column("CCLHO_CODE")]
        [StringLength(50)]
        public string CclhoCode { get; set; }
        [Required]
        [Column("CCLHO_NAME")]
        [StringLength(50)]
        public string CclhoName { get; set; }
        [Required]
        [Column("FIPS_COUNTY_CODE")]
        [StringLength(15)]
        public string FipsCountyCode { get; set; }
        [Column("BIRTHING_FACILITY_FLAG")]
        [StringLength(50)]
        public string BirthingFacilityFlag { get; set; }
        [Column("TRAUMA_PED_CTR")]
        [StringLength(50)]
        public string TraumaPedCtr { get; set; }
        [Column("TRAUMA_CTR")]
        [StringLength(50)]
        public string TraumaCtr { get; set; }
        [Column("TYPE_OF_CARE")]
        [StringLength(50)]
        public string TypeOfCare { get; set; }
        [Column("CRITICAL_ACCESS_HOSPITAL")]
        [StringLength(50)]
        public string CriticalAccessHospital { get; set; }
    }
}
