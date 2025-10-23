using Microsoft.Data.SqlClient;
using (SqlConnection cn = new SqlConnection(@"
Server=.;
Database=db01;
Trusted_Connection=true;
TrustServerCertificate=true;"))
{

    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = @"INSERT INTO dbo.Product(ProductID, ProductName, Price) 
                        VALUES(@ProductID, @ProductName, @Price)";
    cmd.Parameters.AddWithValue("@ProductID", 1);
    cmd.Parameters.AddWithValue("@ProductName", "A-Product");
    cmd.Parameters.AddWithValue("@Price", 99999);
    cn.Open();
    int n = cmd.ExecuteNonQuery();
    cn.Close();
    Console.WriteLine($"{n} row(s) affected.");
}
