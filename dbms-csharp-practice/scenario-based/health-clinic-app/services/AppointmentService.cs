using HealthClinicApp.Models;
using HealthClinicApp.Utility;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace HealthClinicApp.Services
{
  public class AppointmentService
  {
    // UC-3.1: Book New Appointment
    public int BookAppointment(Appointment appointment)
    {
      // 1️⃣ Check if doctor is available at given date & time
      string availabilityQuery = @"
                SELECT COUNT(*)
                FROM appointments
                WHERE doctor_id = @doctorId
                  AND appointment_date = @date
                  AND appointment_time = @time
                  AND status = 'SCHEDULED'";

      SqlParameter[] availabilityParams =
      {
                new SqlParameter("@doctorId", appointment.DoctorId),
                new SqlParameter("@date", appointment.AppointmentDate),
                new SqlParameter("@time", appointment.AppointmentTime)
            };

      int existingCount = Convert.ToInt32(
          DbHelper.ExecuteScalar(availabilityQuery, availabilityParams)
      );

      if (existingCount > 0)
        throw new InvalidOperationException("Doctor is not available at this time.");

      // 2️⃣ Insert appointment
      string insertQuery = @"
                INSERT INTO appointments
                (patient_id, doctor_id, appointment_date, appointment_time, status)
                VALUES
                (@patientId, @doctorId, @date, @time, 'SCHEDULED')";

      SqlParameter[] insertParams =
      {
                new SqlParameter("@patientId", appointment.PatientId),
                new SqlParameter("@doctorId", appointment.DoctorId),
                new SqlParameter("@date", appointment.AppointmentDate),
                new SqlParameter("@time", appointment.AppointmentTime)
            };

      return DbHelper.ExecuteNonQuery(insertQuery, insertParams);
    }

    // UC-3.5: View Daily Appointment Schedule
    public List<Appointment> GetAppointmentsByDate(DateTime date)
    {
      string query = @"
                SELECT
                    appointment_id,
                    patient_id,
                    doctor_id,
                    appointment_date,
                    appointment_time,
                    status
                FROM appointments
                WHERE appointment_date = @date
                ORDER BY appointment_time";

      SqlParameter[] parameters =
      {
                new SqlParameter("@date", date.Date)
            };

      List<Appointment> appointments = new List<Appointment>();

      using SqlDataReader reader = DbHelper.ExecuteReader(query, parameters);

      while (reader.Read())
      {
        appointments.Add(new Appointment
        {
          AppointmentId = reader.GetInt32(0),
          PatientId = reader.GetInt32(1),
          DoctorId = reader.GetInt32(2),
          AppointmentDate = reader.GetDateTime(3),
          AppointmentTime = reader.GetTimeSpan(4),
          Status = reader.GetString(5)
        });
      }

      return appointments;
    }

    // UC-3.3: Cancel Appointment
    public int CancelAppointment(int appointmentId)
    {
      string query = @"
                UPDATE appointments
                SET status = 'CANCELLED'
                WHERE appointment_id = @appointmentId
                  AND status = 'SCHEDULED'";

      SqlParameter[] parameters =
      {
                new SqlParameter("@appointmentId", appointmentId)
            };

      return DbHelper.ExecuteNonQuery(query, parameters);
    }
  }
}
