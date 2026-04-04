using HealthClinicApp.Utility;
using HealthClinicApp.Models;
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
  public class BillingService
  {
    // UC-5.1: Generate Bill for Visit
    public int GenerateBill(int visitId, decimal amount)
    {
      // 1️⃣ Ensure visit exists
      string checkVisitQuery = @"
                SELECT COUNT(*)
                FROM visits
                WHERE visit_id = @visitId";

      SqlParameter[] checkParams =
      {
                new SqlParameter("@visitId", visitId)
            };

      int visitCount = Convert.ToInt32(
          DbHelper.ExecuteScalar(checkVisitQuery, checkParams)
      );

      if (visitCount == 0)
        throw new InvalidOperationException("Visit does not exist.");

      // 2️⃣ Insert bill (UNPAID)
      string insertQuery = @"
                INSERT INTO bills
                (visit_id, amount, payment_status)
                VALUES
                (@visitId, @amount, 'UNPAID')";

      SqlParameter[] insertParams =
      {
                new SqlParameter("@visitId", visitId),
                new SqlParameter("@amount", amount)
            };

      return DbHelper.ExecuteNonQuery(insertQuery, insertParams);
    }

    // UC-5.2: Record Payment
    public int MarkBillAsPaid(int billId, string paymentMode)
    {
      string updateQuery = @"
                UPDATE bills
                SET
                    payment_status = 'PAID',
                    payment_mode = @paymentMode,
                    payment_date = GETDATE()
                WHERE bill_id = @billId
                  AND payment_status = 'UNPAID'";

      SqlParameter[] parameters =
      {
                new SqlParameter("@billId", billId),
                new SqlParameter("@paymentMode", paymentMode)
            };

      int rowsAffected = DbHelper.ExecuteNonQuery(updateQuery, parameters);

      if (rowsAffected == 0)
        throw new InvalidOperationException(
            "Bill not found or already paid."
        );

      return rowsAffected;
    }
  }
}
