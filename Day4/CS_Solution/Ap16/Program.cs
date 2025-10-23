using Microsoft.Data.SqlClient;
using (SqlConnection cn = new SqlConnection(@"
Server=.;
Database=Northwind;
User ID=sa;Password=1234;
TrustServerCertificate=true;"))
{

    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = "SELECT * FROM dbo.Products";

    cn.Open();
    using (SqlDataReader rd = cmd.ExecuteReader())
    {
        while (rd.Read())
        {
            //rd["ProductID"], rd["ProductName"]
            Console.WriteLine($"{rd["ProductID"]}-{rd["ProductName"]}");
        }
        rd.Close();
    }
    cn.Close();
}