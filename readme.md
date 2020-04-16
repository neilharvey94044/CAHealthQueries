# California Health Queries
### **Project:** C# project that queries CA health data
### **Author**:     [Neil Harvey](https://www.linkedin.com/in/neil-harvey-07009a2a/)
### **Date**:       April 2020 (during Covid-19 Shelter In Place Order)
### **Tools**:    .Net Core, C#, Entity Framework, ADO.NET, SQL Server 2019
### **What is California Health Queries?
Provides boilerplate code that explores multiple different techniques for querying a SQL Server database.  This project is dependent upon projects CAHealthFacilityDBLoad and NPPES-Data-Load.

For more information on the DB access methods explored in this project see [Entity Framework Documentation](https://docs.microsoft.com/en-us/ef/) and [ADO.NET Options Guidelines ](https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/ado-net-technology-options-and-guidelines).
  


#### Project Goals:
- Build a set of queries that demonstrates and provides a quick easy way to get started with different Microsoft DB access methods for querying SQL Server.
- Use data from the real world that is publicly available and will stress these DB access methods.
- Use a .Net Core 3.1 console application adhering to Microsoft's frameworks for dependency injection, host configuration, managing services, etc..

#### Files
- **ConsoleApplication.cs**
  - This class contains all of the queries as separate methods.  Simply undocument the invocations in the run() methods as desired.
- **Process.cs**
    - Contains the Main() method.  Sets up the application container, services, logging, dependency injection, configuration, etc..  Please note that this application uses the Secret Manager tool to hide the database credentials.  See [Safe storage of app secrets in development in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows)



  #### Related Projects
  ### CAHealthFacilityDBLoad - CA Health Facility data load to SQL Server.
  ### NPPES-Data-Load - National Provider data load to SQL server.
  ### CAHealthREST (tbd) - a REST API for the npidata.  Written in C# using ASP.NET Core.
