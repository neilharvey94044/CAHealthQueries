using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("prov_loc")]
    public partial class ProvLoc
    {
        [Column("NPI", TypeName = "numeric(18, 0)")]
        public decimal? Npi { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_Line1")]
        [StringLength(55)]
        public string ProviderSecondaryPracticeLocationAddressLine1 { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_Line2")]
        [StringLength(55)]
        public string ProviderSecondaryPracticeLocationAddressLine2 { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_City_Name")]
        [StringLength(40)]
        public string ProviderSecondaryPracticeLocationAddressCityName { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_State_Name")]
        [StringLength(40)]
        public string ProviderSecondaryPracticeLocationAddressStateName { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_Postal_Code")]
        [StringLength(20)]
        public string ProviderSecondaryPracticeLocationAddressPostalCode { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_Country_Code")]
        [StringLength(2)]
        public string ProviderSecondaryPracticeLocationAddressCountryCode { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_Telephone_Number")]
        [StringLength(20)]
        public string ProviderSecondaryPracticeLocationAddressTelephoneNumber { get; set; }
        [Column("Provider_Secondary_Practice_Location_Address_Telephone_Ext")]
        [StringLength(20)]
        public string ProviderSecondaryPracticeLocationAddressTelephoneExt { get; set; }
        [Column("Provider_Secondar_Practice_Location_Address_Fax_Number")]
        [StringLength(20)]
        public string ProviderSecondarPracticeLocationAddressFaxNumber { get; set; }
    }
}
