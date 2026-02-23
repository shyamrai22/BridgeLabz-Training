using HealthClinicApp.Models;
using System.Collections.Generic;

namespace HealthClinicApp.Interfaces
{
  public interface IVisitService
  {
    void RecordVisit(Visit visit);
    List<Visit> GetVisitsByPatient(int patientId);
  }
}
