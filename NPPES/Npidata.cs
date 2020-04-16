using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("npidata")]
    public partial class Npidata
    {
        [Column("NPI", TypeName = "numeric(18, 0)")]
        public decimal? Npi { get; set; }
        [Column("Entity_Type_Code")]
        public int? EntityTypeCode { get; set; }
        [Column("Replacement_NPI", TypeName = "numeric(18, 0)")]
        public decimal? ReplacementNpi { get; set; }
        [Column("Employer_Identification_Number")]
        [StringLength(9)]
        public string EmployerIdentificationNumber { get; set; }
        [Column("Provider_Org_Name")]
        [StringLength(70)]
        public string ProviderOrgName { get; set; }
        [Column("Provider_Last_Name")]
        [StringLength(35)]
        public string ProviderLastName { get; set; }
        [Column("Provider_First_Name")]
        [StringLength(20)]
        public string ProviderFirstName { get; set; }
        [Column("Provider_Middle_Name")]
        [StringLength(20)]
        public string ProviderMiddleName { get; set; }
        [Column("Provider_Name_Prefix_Text")]
        [StringLength(5)]
        public string ProviderNamePrefixText { get; set; }
        [Column("Provider_Name_Suffix_Text")]
        [StringLength(5)]
        public string ProviderNameSuffixText { get; set; }
        [Column("Provider_Credential_Text")]
        [StringLength(20)]
        public string ProviderCredentialText { get; set; }
        [Column("Provider_Other_Organization_Name")]
        [StringLength(70)]
        public string ProviderOtherOrganizationName { get; set; }
        [Column("Provider_Other_Organization_Name_Type_Code")]
        [StringLength(1)]
        public string ProviderOtherOrganizationNameTypeCode { get; set; }
        [Column("Provider_Other_Last_Name")]
        [StringLength(35)]
        public string ProviderOtherLastName { get; set; }
        [Column("Provider_Other_First_Name")]
        [StringLength(20)]
        public string ProviderOtherFirstName { get; set; }
        [Column("Provider_Other_Middle_Name")]
        [StringLength(20)]
        public string ProviderOtherMiddleName { get; set; }
        [Column("Provider_Other_Name_Prefix_Text")]
        [StringLength(5)]
        public string ProviderOtherNamePrefixText { get; set; }
        [Column("Provider_Other_Name_Suffix_Text")]
        [StringLength(5)]
        public string ProviderOtherNameSuffixText { get; set; }
        [Column("Provider_Other_Credential_Text")]
        [StringLength(20)]
        public string ProviderOtherCredentialText { get; set; }
        [Column("Provider_Other_Last_Name_Type_Code")]
        public int? ProviderOtherLastNameTypeCode { get; set; }
        [Column("Provider_First_Line_Business_Mailing_Address")]
        [StringLength(55)]
        public string ProviderFirstLineBusinessMailingAddress { get; set; }
        [Column("Provider_Second_Line_Business_Mailing_Address")]
        [StringLength(55)]
        public string ProviderSecondLineBusinessMailingAddress { get; set; }
        [Column("Provider_Business_Mailing_Address_City_Name")]
        [StringLength(40)]
        public string ProviderBusinessMailingAddressCityName { get; set; }
        [Column("Provider_Business_Mailing_Address_State_Name")]
        [StringLength(40)]
        public string ProviderBusinessMailingAddressStateName { get; set; }
        [Column("Provider_Business_Mailing_Address_Postal_Code")]
        [StringLength(20)]
        public string ProviderBusinessMailingAddressPostalCode { get; set; }
        [Column("Provider_Business_Mailing_Address_Country_Code")]
        [StringLength(2)]
        public string ProviderBusinessMailingAddressCountryCode { get; set; }
        [Column("Provider_Business_Mailing_Address_Telephone_Number")]
        [StringLength(20)]
        public string ProviderBusinessMailingAddressTelephoneNumber { get; set; }
        [Column("Provider_Business_Mailing_Address_Fax_Number")]
        [StringLength(20)]
        public string ProviderBusinessMailingAddressFaxNumber { get; set; }
        [Column("Provider_First_Line_Business_Practice_Location_Address")]
        [StringLength(55)]
        public string ProviderFirstLineBusinessPracticeLocationAddress { get; set; }
        [Column("Provider_Second_Line_Business_Practice_Location_Address")]
        [StringLength(55)]
        public string ProviderSecondLineBusinessPracticeLocationAddress { get; set; }
        [Column("Provider_Business_Practice_Location_Address_City_Name")]
        [StringLength(40)]
        public string ProviderBusinessPracticeLocationAddressCityName { get; set; }
        [Column("Provider_Business_Practice_Location_Address_State_Name")]
        [StringLength(40)]
        public string ProviderBusinessPracticeLocationAddressStateName { get; set; }
        [Column("Provider_Business_Practice_Location_Address_Postal_Code")]
        [StringLength(20)]
        public string ProviderBusinessPracticeLocationAddressPostalCode { get; set; }
        [Column("Provider_Business_Practice_Location_Address_Country_Code")]
        [StringLength(2)]
        public string ProviderBusinessPracticeLocationAddressCountryCode { get; set; }
        [Column("Provider_Business_Practice_Location_Address_Telephone_Number")]
        [StringLength(20)]
        public string ProviderBusinessPracticeLocationAddressTelephoneNumber { get; set; }
        [Column("Provider_Business_Practice_Location_Address_Fax_Number")]
        [StringLength(20)]
        public string ProviderBusinessPracticeLocationAddressFaxNumber { get; set; }
        [Column("Provider_Enumeration_Date", TypeName = "date")]
        public DateTime? ProviderEnumerationDate { get; set; }
        [Column("Last_Update_Date", TypeName = "date")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("NPI_Deactivation_Reason_Code")]
        [StringLength(2)]
        public string NpiDeactivationReasonCode { get; set; }
        [Column("NPI_Deactivation_Date", TypeName = "date")]
        public DateTime? NpiDeactivationDate { get; set; }
        [Column("NPI_Reactivation_Date", TypeName = "date")]
        public DateTime? NpiReactivationDate { get; set; }
        [Column("Provider_Gender_Code")]
        [StringLength(1)]
        public string ProviderGenderCode { get; set; }
        [Column("Authorized_Official_Last_Name")]
        [StringLength(35)]
        public string AuthorizedOfficialLastName { get; set; }
        [Column("Authorized_Official_First_Name")]
        [StringLength(20)]
        public string AuthorizedOfficialFirstName { get; set; }
        [Column("Authorized_Official_Middle_Name")]
        [StringLength(20)]
        public string AuthorizedOfficialMiddleName { get; set; }
        [Column("Authorized_Official_Title_or_Position")]
        [StringLength(35)]
        public string AuthorizedOfficialTitleOrPosition { get; set; }
        [Column("Authorized_Official_Telephone_Number")]
        [StringLength(20)]
        public string AuthorizedOfficialTelephoneNumber { get; set; }
        [Column("Is_Sole_Proprietor")]
        [StringLength(1)]
        public string IsSoleProprietor { get; set; }
        [Column("Is_Organization_Subpart")]
        [StringLength(1)]
        public string IsOrganizationSubpart { get; set; }
        [Column("Parent_Organization_LBN")]
        [StringLength(70)]
        public string ParentOrganizationLbn { get; set; }
        [Column("Parent_Organization_TIN")]
        [StringLength(9)]
        public string ParentOrganizationTin { get; set; }
        [Column("Authorized_Official_Name_Prefix_Text")]
        [StringLength(5)]
        public string AuthorizedOfficialNamePrefixText { get; set; }
        [Column("Authorized_Official_Name_Suffix_Text")]
        [StringLength(5)]
        public string AuthorizedOfficialNameSuffixText { get; set; }
        [Column("Authorized_Official_Credential_Text")]
        [StringLength(20)]
        public string AuthorizedOfficialCredentialText { get; set; }
        [Column("Certification_Date", TypeName = "date")]
        public DateTime? CertificationDate { get; set; }
    }
}
