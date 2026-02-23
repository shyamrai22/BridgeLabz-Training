using HealthClinicApp.Models;
using HealthClinicApp.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
  public class VisitService
  {
    // UC-4.1: Record Patient Visit (TRANSACTIONAL)
    public void RecordVisit(Visit visit)
    {
      SqlConnection connection;
      SqlTransaction transaction = DbHelper.BeginTransaction(out connection);

      try
      {
        // 1️⃣ Ensure appointment exists and is SCHEDULED
        string checkAppointmentQuery = @"
                    SELECT status
                    FROM appointments
                    WHERE appointment_id = @appointmentId";

        SqlParameter[] checkParams =
        {
                    new SqlParameter("@appointmentId", visit.AppointmentId)
                };

        using SqlCommand checkCmd = new SqlCommand(
            checkAppointmentQuery,
            connection,
            transaction
        );

        checkCmd.Parameters.AddRange(checkParams);

        object? statusObj = checkCmd.ExecuteScalar();

        if (statusObj == null)
          throw new InvalidOperationException("Appointment does not exist.");

        if (statusObj.ToString() != "SCHEDULED")
          throw new InvalidOperationException("Appointment is not in SCHEDULED state.");

        // 2️⃣ Insert visit record
        string insertVisitQuery = @"
                    INSERT INTO visits
                    (appointment_id, patient_id, doctor_id, diagnosis, prescription, notes)
                    VALUES
                    (@appointmentId, @patientId, @doctorId, @diagnosis, @prescription, @notes)";

        SqlParameter[] visitParams =
        {
                    new SqlParameter("@appointmentId", visit.AppointmentId),
                    new SqlParameter("@patientId", visit.PatientId),
                    new SqlParameter("@doctorId", visit.DoctorId),
                    new SqlParameter("@diagnosis", (object?)visit.Diagnosis ?? DBNull.Value),
                    new SqlParameter("@prescription", (object?)visit.Prescription ?? DBNull.Value),
                    new SqlParameter("@notes", (object?)visit.Notes ?? DBNull.Value)
                };

        DbHelper.ExecuteNonQuery(insertVisitQuery, visitParams, transaction);

        // 3️⃣ Update appointment status to COMPLETED
        string updateAppointmentQuery = @"
                    UPDATE appointments
                    SET status = 'COMPLETED'
                    WHERE appointment_id = @appointmentId";

        SqlParameter[] updateParams =
        {
                    new SqlParameter("@appointmentId", visit.AppointmentId)
                };

        DbHelper.ExecuteNonQuery(updateAppointmentQuery, updateParams, transaction);

        // 4️⃣ Commit transaction
        transaction.Commit();
      }
      catch
      {
        transaction.Rollback();
        throw;
      }
      finally
      {
        connection.Close();
      }
    }

    // UC-4.2: View Patient Medical History
    public List<Visit> GetVisitsByPatient(int patientId)
    {
      string query = @"
                SELECT
                    visit_id,
                    appointment_id,
                    patient_id,
                    doctor_id,
                    diagnosis,
                    prescription,
                    notes,
                    visit_date
                FROM visits
                WHERE patient_id = @patientId
                ORDER BY visit_date DESC";

      SqlParameter[] parameters =
      {
                new SqlParameter("@patientId", patientId)
            };

      List<Visit> visits = new List<Visit>();

      using SqlDataReader reader = DbHelper.ExecuteReader(query, parameters);

      while (reader.Read())
      {
        visits.Add(new Visit
        {
          VisitId = reader.GetInt32(0),
          AppointmentId = reader.GetInt32(1),
          PatientId = reader.GetInt32(2),
          DoctorId = reader.GetInt32(3),
          Diagnosis = reader.IsDBNull(4) ? null : reader.GetString(4),
          Prescription = reader.IsDBNull(5) ? null : reader.GetString(5),
          Notes = reader.IsDBNull(6) ? null : reader.GetString(6),
          VisitDate = reader.GetDateTime(7)
        });
      }

      return visits;
    }
  }
}
