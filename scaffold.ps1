dotnet ef dbcontext scaffold "Data Source=127.0.0.1; Initial Catalog=NPPES; User Id=sa;Password=?????" Microsoft.EntityFrameworkCore.SqlServer --table dbo.npidata --table dbo.txcodes --table dbo.prov_loc --table dbo.npi_taxonomy --table dbo.npi_oth_prov --table dbo.healthcare_facility_beds --table dbo.healthcare_facility_locations --table dbo.healthcare_facility_services --data-annotations --context-dir NPPES --output-dir NPPES
