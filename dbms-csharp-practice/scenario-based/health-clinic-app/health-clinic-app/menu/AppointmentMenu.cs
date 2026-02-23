using System;
using HealthClinicApp.Models;
using HealthClinicApp.Services;

namespace HealthClinicApp.Menu
{
  public static class AppointmentMenu
  {
    public static void Show()
    {
      AppointmentService service = new AppointmentService();

      while (true)
      {
        Console.Clear();
        Console.WriteLine("=== APPOINTMENT MENU ===");
        Console.WriteLine("1. Book Appointment");
        Console.WriteLine("2. View Appointments by Date");
        Console.WriteLine("0. Back");
        Console.Write("Choose: ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            BookAppointment(service);
            break;
          case "2":
            ViewByDate(service);
            break;
          case "0":
            return;
          default:
            Console.WriteLine("Invalid option!");
            Console.ReadKey();
            break;
        }
      }
    }

    private static void BookAppointment(AppointmentService service)
    {
      Console.Write("Patient ID: ");
      int patientId = int.Parse(Console.ReadLine()!);

      Console.Write("Doctor ID: ");
      int doctorId = int.Parse(Console.ReadLine()!);

      Console.Write("Date (yyyy-mm-dd): ");
      DateTime date = DateTime.Parse(Console.ReadLine()!);

      Console.Write("Time (HH:mm): ");
      TimeSpan time = TimeSpan.Parse(Console.ReadLine()!);

      Appointment appointment = new Appointment
      {
        PatientId = patientId,
        DoctorId = doctorId,
        AppointmentDate = date,
        AppointmentTime = time
      };

      try
      {
        service.BookAppointment(appointment);
        Console.WriteLine("Appointment booked!");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

      Console.ReadKey();
    }

    private static void ViewByDate(AppointmentService service)
    {
      Console.Write("Enter date (yyyy-mm-dd): ");
      DateTime date = DateTime.Parse(Console.ReadLine()!);

      var appointments = service.GetAppointmentsByDate(date);

      foreach (var a in appointments)
      {
        Console.WriteLine(
            $"ID:{a.AppointmentId} Patient:{a.PatientId} Doctor:{a.DoctorId} Time:{a.AppointmentTime} Status:{a.Status}"
        );
      }

      Console.ReadKey();
    }
  }
}
