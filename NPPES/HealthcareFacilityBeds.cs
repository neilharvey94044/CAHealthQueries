using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("healthcare_facility_beds")]
    public partial class HealthcareFacilityBeds
    {
        [Column("FACID", TypeName = "numeric(18, 0)")]
        public decimal Facid { get; set; }
        [Required]
        [Column("FACNAME")]
        [StringLength(100)]
        public string Facname { get; set; }
        [Required]
        [Column("FAC_FDR")]
        [StringLength(50)]
        public string FacFdr { get; set; }
        [Required]
        [Column("BED_CAPACITY_TYPE")]
        [StringLength(50)]
        public string BedCapacityType { get; set; }
        [Column("COUNT_BEDS")]
        public int CountBeds { get; set; }
        [Required]
        [Column("COUNTY_NAME")]
        [StringLength(50)]
        public string CountyName { get; set; }
    }
}
