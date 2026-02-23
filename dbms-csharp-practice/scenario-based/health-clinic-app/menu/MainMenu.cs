using System;
using HealthClinicApp.Menu;

namespace HealthClinicApp.Menu
{
  public static class MainMenu
  {
    public static void Show()
    {
      while (true)
      {
        Console.Clear();
        Console.WriteLine("=== HEALTH CLINIC MANAGEMENT SYSTEM ===");
        Console.WriteLine("1. Patient Management");
        Console.WriteLine("2. Appointment Management");
        Console.WriteLine("3. Billing");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            PatientMenu.Show();
            break;
          case "2":
            AppointmentMenu.Show();
            break;
          case "3":
            BillingMenu.Show();
            break;
          case "0":
            return;
          default:
            Console.WriteLine("Invalid choice!");
            Console.ReadKey();
            break;
        }
      }
    }
  }
}
