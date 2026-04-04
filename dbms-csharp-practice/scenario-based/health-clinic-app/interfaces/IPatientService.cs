using HealthClinicApp.Models;

namespace HealthClinicApp.Interfaces
{
  public interface IPatientService
  {
    int AddPatient(Patient patient);
    int UpdatePatient(Patient patient);
    Patient? GetPatientByPhone(string phone);
  }
}
