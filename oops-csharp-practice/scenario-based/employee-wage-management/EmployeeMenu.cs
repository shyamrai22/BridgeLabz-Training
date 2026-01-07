using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;

        public void EmployeeChoice()
        {
            employeeService = new EmployeeUtilityImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect Use Case:");
                Console.WriteLine("1. UC1 - Employee Attendance");
                Console.WriteLine("2. UC2 - Daily Wage");
                Console.WriteLine("3. UC3 - Part-Time Wage");
                Console.WriteLine("4. UC4 - Switch Case Attendance");
                Console.WriteLine("5. UC5 - Monthly Wage");
                Console.WriteLine("6. UC6 - Wage till Max Hours or Days");
                Console.WriteLine("7. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        UC1_AttendanceCheck();
                        break;

                    case 2:
                        UC2_DailyWage();
                        break;

                    case 3:
                        UC3_PartTimeWage();
                        break;

                    case 4:
                        UC4_SwitchCaseAttendance();
                        break;

                    case 5:
                        UC5_MonthlyWage();
                        break;

                    case 6:
                        UC6_MaxHoursOrDays();
                        break;

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

        // UC:01
        public void UC1_AttendanceCheck()
        {
            bool isPresent = employeeService.IsEmployeePresent();
            Console.WriteLine(isPresent ? "Employee is Present" : "Employee is Absent");
        }

        // UC:02
        public void UC2_DailyWage()
        {
            if (employeeService.IsEmployeePresent())
                Console.WriteLine($"Daily Wage: {employeeService.CalculateDailyWage()}");
            else
                Console.WriteLine("Employee is absent");
        }

        // UC:03
        public void UC3_PartTimeWage()
        {
            if (employeeService.IsEmployeePresent())
                Console.WriteLine($"Part-Time Wage: {employeeService.CalculatePartTimeWage()}");
            else
                Console.WriteLine("Employee is absent");
        }

        // UC:04
        public void UC4_SwitchCaseAttendance()
        {
            int hoursWorked = employeeService.GetWorkingHour();

            if (hoursWorked == 0)
            {
                Console.WriteLine("Employee is absent");
                return;
            }
            else if (hoursWorked == 4)
            {
                Console.WriteLine("Part-Time Employee");
            }
            else if (hoursWorked == 8)
            {
                Console.WriteLine("Full-Time Employee");
            }

            int wage = hoursWorked * 20;

            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Daily Wage: {wage}");
        }

        // UC:05
        public void UC5_MonthlyWage()
        {
            int monthlyWage = employeeService.CalculateMonthlyWage();
            Console.WriteLine($"Monthly wage of employee is: {monthlyWage}");
        }

        // UC:06
        public void UC6_MaxHoursOrDays()
        {
            int monthlyWage = employeeService.CalculateWageWithCondition();
            Console.WriteLine($"Monthly wage of employee is: {monthlyWage}");
        }
    }
}
