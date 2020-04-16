using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.Models
{
    [Table("healthcare_facility_services")]
    public partial class HealthcareFacilityServices
    {
        [Required]
        [Column("FACID")]
        public decimal? Facid { get; set; }
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
        [Column("SERVICE_TYPE_CODE")]
        [StringLength(50)]
        public string ServiceTypeCode { get; set; }
        [Required]
        [Column("SERVICE_TYPE_NAME")]
        [StringLength(100)]
        public string ServiceTypeName { get; set; }
        [Column("SERVICE_OTHER_NAME")]
        [StringLength(50)]
        public string ServiceOtherName { get; set; }
        [Required]
        [Column("IS_OFFSITE_SERVICE")]
        [StringLength(50)]
        public string IsOffsiteService { get; set; }
        [Column("OFFSITE_NAME")]
        [StringLength(100)]
        public string OffsiteName { get; set; }
        [Column("OFFSITE_ADDRESS1")]
        [StringLength(50)]
        public string OffsiteAddress1 { get; set; }
        [Column("OFFSITE_CITY")]
        [StringLength(50)]
        public string OffsiteCity { get; set; }
        [Column("OFFSITE_STATE")]
        [StringLength(50)]
        public string OffsiteState { get; set; }
        [Column("OFFSITE_ZIP")]
        [StringLength(50)]
        public string OffsiteZip { get; set; }
        [Required]
        [Column("COUNTY_NAME")]
        [StringLength(50)]
        public string CountyName { get; set; }
        [Column("START_DATE")]
        public DateTime StartDate { get; set; }
        [Column("LONGITUDE")]
        [StringLength(50)]
        public string Longitude { get; set; }
        [Column("LATITUDE")]
        [StringLength(50)]
        public string Latitude { get; set; }
        [Required]
        [Column("LOCATION")]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
