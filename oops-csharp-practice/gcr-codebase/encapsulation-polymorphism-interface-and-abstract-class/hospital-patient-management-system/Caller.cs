using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_patient_management_system
{
    class Caller
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n===== Hospital Patient Management System =====");
                Console.WriteLine("1. Add Doctor");
                Console.WriteLine("2. Add Patient");
                Console.WriteLine("3. Display All Patients");
                Console.WriteLine("4. Generate Bill");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddDoctor();
                        break;

                    case 2:
                        utility.AddPatient();
                        break;

                    case 3:
                        utility.DisplayPatients();
                        break;

                    case 4:
                        utility.GenerateBill();
                        break;

                    case 5:
                        exit = true;
                        Console.WriteLine("Exiting system. Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
