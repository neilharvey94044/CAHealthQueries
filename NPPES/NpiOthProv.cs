using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("npi_oth_prov")]
    public partial class NpiOthProv
    {
        [Column("NPI", TypeName = "numeric(18, 0)")]
        public decimal? Npi { get; set; }
        [Column("Other_Provider_Identifier")]
        [StringLength(20)]
        public string OtherProviderIdentifier { get; set; }
        [Column("Other_Provider_Identifier_Type_Code")]
        [StringLength(2)]
        public string OtherProviderIdentifierTypeCode { get; set; }
        [Column("Other_Provider_Identifier_State")]
        [StringLength(2)]
        public string OtherProviderIdentifierState { get; set; }
        [Column("Other_Provider_Identifier_Issuer")]
        [StringLength(80)]
        public string OtherProviderIdentifierIssuer { get; set; }
    }
}
