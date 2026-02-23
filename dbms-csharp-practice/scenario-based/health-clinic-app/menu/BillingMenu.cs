using System;
using HealthClinicApp.Services;

namespace HealthClinicApp.Menu
{
  public static class BillingMenu
  {
    public static void Show()
    {
      BillingService service = new BillingService();

      while (true)
      {
        Console.Clear();
        Console.WriteLine("=== BILLING MENU ===");
        Console.WriteLine("1. Generate Bill");
        Console.WriteLine("2. Mark Bill as Paid");
        Console.WriteLine("0. Back");
        Console.Write("Choose: ");

        string? choice = Console.ReadLine();

        switch (choice)
        {
          case "1":
            GenerateBill(service);
            break;
          case "2":
            MarkPaid(service);
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

    private static void GenerateBill(BillingService service)
    {
      Console.Write("Visit ID: ");
      int visitId = int.Parse(Console.ReadLine()!);

      Console.Write("Amount: ");
      decimal amount = decimal.Parse(Console.ReadLine()!);

      service.GenerateBill(visitId, amount);

      Console.WriteLine("Bill generated.");
      Console.ReadKey();
    }

    private static void MarkPaid(BillingService service)
    {
      Console.Write("Bill ID: ");
      int billId = int.Parse(Console.ReadLine()!);

      Console.Write("Payment Mode: ");
      string mode = Console.ReadLine()!;

      try
      {
        service.MarkBillAsPaid(billId, mode);
        Console.WriteLine("Payment recorded.");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

      Console.ReadKey();
    }
  }
}
