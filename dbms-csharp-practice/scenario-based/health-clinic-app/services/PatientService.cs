using System;
using Microsoft.Data.SqlClient;
using HealthClinicApp.Models;
using HealthClinicApp.Utility;

namespace HealthClinicApp.Services
{
  public class PatientService
  {
    // UC-1.1: Register New Patient
    public int AddPatient(Patient patient)
    {
      string query = @"
                INSERT INTO patients
                (name, dob, phone, email, address, blood_group)
                VALUES
                (@name, @dob, @phone, @email, @address, @bloodGroup)";

      SqlParameter[] parameters =
      {
                new SqlParameter("@name", patient.Name),
                new SqlParameter("@dob", patient.Dob),
                new SqlParameter("@phone", patient.Phone),
                new SqlParameter("@email", (object?)patient.Email ?? DBNull.Value),
                new SqlParameter("@address", patient.Address),
                new SqlParameter("@bloodGroup", patient.BloodGroup)
            };
      return DbHelper.ExecuteNonQuery(query, parameters);
    }

    // UC-1.2: Update Patient Information
    public int UpdatePatient(Patient patient)
    {
      string query = @"
                UPDATE patients
                SET
                    name = @name,
                    dob = @dob,
                    phone = @phone,
                    email = @email,
                    address = @address,
                    blood_group = @bloodGroup
                WHERE patient_id = @patientId";

      SqlParameter[] parameters =
      {
                new SqlParameter("@patientId", patient.PatientId),
                new SqlParameter("@name", patient.Name),
                new SqlParameter("@dob", patient.Dob),
                new SqlParameter("@phone", patient.Phone),
                new SqlParameter("@email", (object?)patient.Email ?? DBNull.Value),
                new SqlParameter("@address", patient.Address),
                new SqlParameter("@bloodGroup", patient.BloodGroup)
            };

      return DbHelper.ExecuteNonQuery(query, parameters);
    }

    // UC-1.3: Search Patient by Phone
    public Patient? GetPatientByPhone(string phone)
    {
      string query = @"
                SELECT
                    patient_id,
                    name,
                    dob,
                    phone,
                    email,
                    address,
                    blood_group,
                    created_at
                FROM patients
                WHERE phone = @phone";

      SqlParameter[] parameters =
      {
                new SqlParameter("@phone", phone)
            };

      using SqlDataReader reader = DbHelper.ExecuteReader(query, parameters);

      if (!reader.Read())
        return null;

      return new Patient
      {
        PatientId = reader.GetInt32(0),
        Name = reader.GetString(1),
        Dob = reader.GetDateTime(2),
        Phone = reader.GetString(3),
        Email = reader.IsDBNull(4) ? null : reader.GetString(4),
        Address = reader.GetString(5),
        BloodGroup = reader.GetString(6),
        CreatedAt = reader.GetDateTime(7)
      };
    }
  }
}
