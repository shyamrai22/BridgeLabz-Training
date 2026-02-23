using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Utility
{
  public static class DbConnection
  {
    private static readonly string _connectionString =
        "Server=localhost\\SQLEXPRESS;" +
        "Database=HealthClinicDB;" +
        "Trusted_Connection=True;" +
        "TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
      SqlConnection connection = new SqlConnection(_connectionString);
      connection.Open();
      return connection;
    }
  }
}
