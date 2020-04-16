using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text;
using CAHealthQueries.Models;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Security;
using Microsoft.EntityFrameworkCore;

namespace CAHealthQueries
{
    class ConsoleApplication
    {

        IConfiguration _config { get; }
        ILogger _logger { get; }
        SqlCredential _sqlcred { get; }

        string _connstr { get; }
        public ConsoleApplication(IConfiguration config, ILogger<ConsoleApplication> logger)
        {
            _config = config;
            _logger = logger;


            // Create SQL Server credential
            string txtPwd = config["Sqlserver:password"];
            SecureString secureStringPwd = new SecureString();
            txtPwd.ToCharArray().ToList().ForEach(p => secureStringPwd.AppendChar(p));
            secureStringPwd.MakeReadOnly();
            string txtUserId = config["Sqlserver:userid"];
            _sqlcred = new SqlCredential(txtUserId, secureStringPwd);

            // Get SQL Server connection string
            _connstr = _config.GetSection("ConnectionStrings")["DefaultConnection"];
        }

        public void run(string[] args)
        {
            _logger.LogInformation("ConsoleApplication.run() started");

            // Query some healthcare data using direct SQL
            // SqlQuery1();

            // Entity Framework Core to query service healthcare data 
            // EFCoreQuery1();

            // Entity Framework Core used to query locations healthcare data
            // EFCoreQuery2();

            // LINQ to Entities query with simple join of locations and services
             LINQ2EntityQuery1();

            // ADO.NET query using DataReader; return only the specified county
            // ADONET_DataReader_Query1("SAN FRANCISCO");
        }

        private void ADONET_DataReader_Query1(String countyName)
        {

            using (SqlConnection connection = new SqlConnection(_connstr, _sqlcred))
            {
                // attach to the NPPES database in a way that minimizes connection pool resources
                // by not explicitly connecting to this database in the connection string
                connection.Open();
                SqlCommand command = new SqlCommand("USE NPPES;", connection);
                command.ExecuteNonQuery();

                // build our select statement
                command.CommandText =
                    "SELECT FACID, left(FACNAME,75) as FACNAME, BED_CAPACITY_TYPE, COUNT_BEDS, COUNTY_NAME " +
                    "FROM dbo.healthcare_facility_beds " +
                    "WHERE COUNTY_NAME = @countyName " +
                    "ORDER BY COUNT_BEDS DESC;";

                command.Parameters.Add("@countyName", SqlDbType.VarChar).Value = countyName;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0,-13} {1,-75} {2,-50} {3,5} {4,-50}",
                            reader.GetDecimal("FACID"),
                            reader.GetString("FACNAME"),
                            reader.GetString("BED_CAPACITY_TYPE"),
                            reader.GetInt32("COUNT_BEDS"),
                            reader.GetString("COUNTY_NAME"));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();
            }


        }

        private void LINQ2EntityQuery1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CA_DATAContext>();
            optionsBuilder.UseSqlServer(new SqlConnection(_connstr, _sqlcred));

            using (var db = new CA_DATAContext(optionsBuilder.Options))
            {
                var locs = from location in db.HealthcareFacilityLocations
                           from service in db.HealthcareFacilityServices
                           where location.CountyName == "SAN FRANCISCO" &&
                           location.Facid == service.Facid
                           select new { location.Facid, location.Facname, service.OffsiteName, service.ServiceTypeName };

                foreach (var loc in locs)
                {
                    Console.WriteLine($"{loc.Facid} | {loc.Facname} | {loc.OffsiteName} | {loc.ServiceTypeName} ");
                }
            }
        }

        private void EFCoreQuery2()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CA_DATAContext>();
            optionsBuilder.UseSqlServer(new SqlConnection(_connstr, _sqlcred));
            using (var db = new CA_DATAContext(optionsBuilder.Options))
            {
                var locs = from location in db.HealthcareFacilityLocations
                           where location.CountyName == "SAN FRANCISCO"
                           orderby location.Capacity descending
                           select new { location.Facid, location.Facname, location.CountyName, location.Capacity };

                foreach (var loc in locs)
                {
                    Console.WriteLine($"{loc.Facid} | {loc.Facname} | {loc.CountyName} | {loc.Capacity}");
                }
            }
        }

        private void EFCoreQuery1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CA_DATAContext>();
            optionsBuilder.UseSqlServer(new SqlConnection(_connstr, _sqlcred));
            using (var db = new CA_DATAContext(optionsBuilder.Options))
            {
                // Read
                var locs = from service in db.HealthcareFacilityServices
                           where service.CountyName == "SAN FRANCISCO"
                           select new { service.Facid, service.Facname, service.OffsiteName, service.CountyName, service.ServiceTypeName };

                foreach (var loc in locs)
                {
                    Console.WriteLine($"{loc.Facid} | {loc.Facname} | {loc.OffsiteName} | {loc.CountyName} | {loc.ServiceTypeName}");
                }

            }

        }

        private void SqlQuery1()
        {
            try
            {
                

                using (SqlConnection connection = new SqlConnection(_connstr, _sqlcred))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT TOP 20 loc.FACID, loc.FACNAME, loc.CITY, beds.COUNT_BEDS ");
                    sb.Append("FROM [dbo].[healthcare_facility_locations] loc ");
                    sb.Append("JOIN [dbo].[healthcare_facility_beds] beds ");
                    sb.Append("ON loc.FACID = beds.FACID;");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1} {2} {3}", reader.GetDecimal(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
        }
    }
}
