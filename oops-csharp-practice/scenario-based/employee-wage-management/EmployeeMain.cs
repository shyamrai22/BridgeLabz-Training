using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeMenu employeeMenu = new EmployeeMenu();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect Use Case:");
                Console.WriteLine("1. UC1 - Employee Attendance");
                Console.WriteLine("2. UC2 - Daily Wage");
                Console.WriteLine("3. UC3 - Part-Time Wage");
                Console.WriteLine("4. UC4 - Switch Case Attendance");
                Console.WriteLine("5. UC5 - Monthly Wage");
                //Console.WriteLine("6. UC6 - Wage till Max Hours or Days");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employeeMenu.UC1_AttendanceCheck();
                        break;

                    case 2:
                        employeeMenu.UC2_DailyWage();
                        break;

                    case 3:
                        employeeMenu.UC3_PartTimeWage();
                        break;

                    case 4:
                        employeeMenu.UC4_SwitchCaseAttendance();
                        break;

                    case 5:
                        employeeMenu.UC5_MonthlyWage();
                        break;

                    //case 6:
                    //    employeeMenu.UC6_MaxHoursOrDays();
                    //    break;

                    case 7:
                        exit = true;
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
