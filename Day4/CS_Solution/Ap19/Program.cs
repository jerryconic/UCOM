using Microsoft.Data.SqlClient;
using (SqlConnection cn = new SqlConnection(@"
Server=.;
Database=db01;
Trusted_Connection=true;
TrustServerCertificate=true;"))
{

    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = @"UPDATE dbo.Product 
                        SET ProductName = @ProductName, Price = @Price
                        WHERE ProductID = @ProductID";
    cmd.Parameters.AddWithValue("@ProductID", 1);
    cmd.Parameters.AddWithValue("@ProductName", "CPU");
    cmd.Parameters.AddWithValue("@Price", 12000);
    cn.Open();
    int n = cmd.ExecuteNonQuery();
    cn.Close();
    Console.WriteLine($"{n} row(s) affected.");
}
