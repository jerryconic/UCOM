using Microsoft.Data.SqlClient;
using (SqlConnection cn = new SqlConnection(@"
Server=.;
Database=db01;
Trusted_Connection=true;
TrustServerCertificate=true;"))
{

    SqlCommand cmd = cn.CreateCommand();
    cmd.CommandText = @"DELETE FROM dbo.Product 
                        WHERE ProductID = @ProductID";
    cmd.Parameters.AddWithValue("@ProductID", 1);
    cn.Open();
    int n = cmd.ExecuteNonQuery();
    cn.Close();
    Console.WriteLine($"{n} row(s) affected.");
}
