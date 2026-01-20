/// <summary>
/// Provides a console-based menu interface for the Aadhaar management system.
/// Handles user interaction, initializes the utility layer with a specified
/// capacity, and allows users to add and search Aadhaar records through
/// a continuous menu-driven workflow.
/// </summary>


class AadharMenu
{
  private AadharUtilityImpl utility;

  public AadharMenu()
  {
    Console.Write("Enter maximum capacity of Aadhar records: ");
    int capacity = int.Parse(Console.ReadLine());
    utility = new AadharUtilityImpl(capacity);
  }

  public void Start()
  {
    while (true)
    {
      Console.WriteLine("\n--- AADHAR MANAGEMENT MENU ---");
      Console.WriteLine("1. Add Aadhar Card");
      Console.WriteLine("2. Search Aadhar Number");
      Console.WriteLine("3. Exit");
      Console.Write("Enter your choice: ");

      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          utility.AddAadharCard();
          break;

        case "2":
          utility.SearchNumber();
          break;

        case "3":
          Console.WriteLine("Exiting application...");
          return;

        default:
          Console.WriteLine("Invalid choice. Try again.");
          break;
      }
    }
  }
}
