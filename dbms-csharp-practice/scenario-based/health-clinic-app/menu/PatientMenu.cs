using System;
using HealthClinicApp.Models;
using HealthClinicApp.Services;

namespace HealthClinicApp.Menu
{
  public static class PatientMenu
  {
    public static void Show()
    {
      PatientService service = new PatientService();

      while (true)
      {
        Console.Clear();
        Console.WriteLine("=== PATIENT MENU ===");
        Console.WriteLine("1. Add Patient");
        Console.WriteLine("2. Search Patient by Phone");
        Console.WriteLine("0. Back");
        Console.Write("Choose: ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            AddPatient(service);
            break;
          case "2":
            SearchPatient(service);
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

    private static void AddPatient(PatientService service)
    {
      Console.Write("Name: ");
      string name = Console.ReadLine()!;

      Console.Write("DOB (yyyy-mm-dd): ");
      DateTime dob = DateTime.Parse(Console.ReadLine()!);

      Console.Write("Phone: ");
      string phone = Console.ReadLine()!;

      Console.Write("Email: ");
      string? email = Console.ReadLine();

      Console.Write("Address: ");
      string? address = Console.ReadLine();

      Console.Write("Blood Group: ");
      string bloodGroup = Console.ReadLine()!;

      Patient patient = new Patient
      {
        Name = name,
        Dob = dob,
        Phone = phone,
        Email = email,
        Address = address,
        BloodGroup = bloodGroup
      };

      service.AddPatient(patient);

      Console.WriteLine("Patient added successfully!");
      Console.ReadKey();
    }

    private static void SearchPatient(PatientService service)
    {
      Console.Write("Enter phone number: ");
      string phone = Console.ReadLine()!;

      Patient? patient = service.GetPatientByPhone(phone);

      if (patient == null)
      {
        Console.WriteLine("Patient not found.");
      }
      else
      {
        Console.WriteLine($"ID: {patient.PatientId}");
        Console.WriteLine($"Name: {patient.Name}");
        Console.WriteLine($"DOB: {patient.Dob:d}");
        Console.WriteLine($"Blood Group: {patient.BloodGroup}");
      }

      Console.ReadKey();
    }
  }
}
