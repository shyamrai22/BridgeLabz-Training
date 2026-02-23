using HealthClinicApp.Models;
using System;
using System.Collections.Generic;

namespace HealthClinicApp.Interfaces
{
  public interface IAppointmentService
  {
    int BookAppointment(Appointment appointment);
    List<Appointment> GetAppointmentsByDate(DateTime date);
    int CancelAppointment(int appointmentId);
  }
}
