using Microsoft.Data.SqlClient;
SqlConnection cn = new SqlConnection(@"
Server=.;
Database=Northwind;
Trusted_Connection=true;
TrustServerCertificate=true;");
cn.Open();
cn.Close();
Console.WriteLine("Connect OK");
