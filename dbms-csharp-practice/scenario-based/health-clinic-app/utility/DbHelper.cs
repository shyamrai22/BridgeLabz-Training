using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Utility
{
  public static class DbHelper
  {
    // INSERT, UPDATE, DELETE
    public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null, SqlTransaction transaction = null)
    {
      using SqlCommand command = new SqlCommand(query);

      if (transaction != null)
      {
        command.Connection = transaction.Connection;
        command.Transaction = transaction;
      }
      else
      {
        command.Connection = DbConnection.GetConnection();
      }

      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }

      int rowsAffected = command.ExecuteNonQuery();

      if (transaction == null)
      {
        command.Connection.Close();
      }

      return rowsAffected;
    }

    // SELECT (multiple rows)
    public static SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
    {
      SqlConnection connection = DbConnection.GetConnection();
      SqlCommand command = new SqlCommand(query, connection);

      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }

      // Connection closes automatically when reader is closed
      return command.ExecuteReader(CommandBehavior.CloseConnection);
    }

    // SELECT single value (COUNT, SUM, ID)
    public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
    {
      using SqlConnection connection = DbConnection.GetConnection();
      using SqlCommand command = new SqlCommand(query, connection);

      if (parameters != null)
      {
        command.Parameters.AddRange(parameters);
      }

      return command.ExecuteScalar();
    }

    // TRANSACTION SUPPORT
    public static SqlTransaction BeginTransaction(out SqlConnection connection)
    {
      connection = DbConnection.GetConnection();
      return connection.BeginTransaction();
    }
  }
}
