using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("npi_taxonomy")]
    public partial class NpiTaxonomy
    {
        [Column("NPI", TypeName = "numeric(18, 0)")]
        public decimal? Npi { get; set; }
        [Column("Healthcare_Provider_Taxonomy_Code")]
        [StringLength(10)]
        public string HealthcareProviderTaxonomyCode { get; set; }
        [Column("Provider_License_Number")]
        [StringLength(20)]
        public string ProviderLicenseNumber { get; set; }
        [Column("Provider_License_Number_State_Code")]
        [StringLength(2)]
        public string ProviderLicenseNumberStateCode { get; set; }
        [Column("Healthcare_Provider_Primary_Taxonomy_Switch")]
        [StringLength(1)]
        public string HealthcareProviderPrimaryTaxonomySwitch { get; set; }
        [Column("Healthcare_Provider_Taxonomy_Group")]
        [StringLength(45)]
        public string HealthcareProviderTaxonomyGroup { get; set; }
    }
}
