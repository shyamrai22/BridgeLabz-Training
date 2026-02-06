using System;

class HospitalManagementMenu
{
  private IHospital HospitalManagementService;

  public void Start()
  {
    HospitalManagementService = new HospitalManagementUtilityImpl(10);
    Console.WriteLine("Welcome to hospital management system");
    while (true)
    {
      Console.WriteLine("Select an option");
      Console.WriteLine("1. Add a Inpatient");
      Console.WriteLine("2. Add a Outpatient");
      Console.WriteLine("3. Display patients with highest bills");
      Console.WriteLine("0. To exit");
      int choice = int.Parse(Console.ReadLine());
      switch (choice)
      {
        case 0:
          return;
        case 1:
          Console.Write("Enter patient id --> ");
          string patientId = Console.ReadLine();
          Console.Write("Enter patient name --> ");
          string patientName = Console.ReadLine();
          Console.Write("Enter patient room charge --> ");
          double roomCharge = double.Parse(Console.ReadLine());
          Console.Write("Enter the number of days the patient stayed --> ");
          double numberOfDays = double.Parse(Console.ReadLine());

          InPatient inPatient = new InPatient(patientId, patientName, roomCharge, numberOfDays);
          HospitalManagementService.AddPatient(inPatient);
          break;
        case 2:
          Console.Write("Enter patient id --> ");
          string patientId2 = Console.ReadLine();
          Console.Write("Enter patient name --> ");
          string patientName2 = Console.ReadLine();
          Console.Write("Enter patient consultation charge --> ");
          double consultFee = double.Parse(Console.ReadLine());

          OutPatient outPatient = new OutPatient(patientId2, patientName2, consultFee);
          HospitalManagementService.AddPatient(outPatient);
          break;
        case 3:
          HospitalManagementService.DisplayHighestBills();
          break;
        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }

  }
}