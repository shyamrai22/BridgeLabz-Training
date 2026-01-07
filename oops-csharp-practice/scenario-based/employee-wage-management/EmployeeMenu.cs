using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;

        public EmployeeMenu()
        {
            employeeService = new EmployeeUtilityImpl();
        }

        // UC:01
        public void UC1_AttendanceCheck()
        {
            bool isPresent = employeeService.IsEmployeePresent();

            Console.WriteLine(isPresent
                ? "Employee is Present"
                : "Employee is Absent");
        }

        // UC:02
        public void UC2_DailyWage()
        {
            bool isPresent = employeeService.IsEmployeePresent();

            if (isPresent)
                Console.WriteLine($"Daily Wage: {employeeService.CalculateDailyWage()}");
            else
                Console.WriteLine("Employee is absent");
        }

        // UC:03
        public void UC3_PartTimeWage()
        {
            bool isPresent = employeeService.IsEmployeePresent();

            if (isPresent)
                Console.WriteLine($"Part-Time Wage: {employeeService.CalculatePartTimeWage()}");
            else
                Console.WriteLine("Employee is absent");
        }

        // UC:04
        public void UC4_SwitchCaseAttendance()
        {
            int hoursWorked = employeeService.GetWorkingHour();
            if(hoursWorked == 0)
            {
                Console.WriteLine("Employee is absent");
                return;
            }
            if(hoursWorked == 4)
            {
                Console.WriteLine("Part-Time Employee");
            }
            if(hoursWorked == 8)
            {
                Console.WriteLine("Full-Time Employee");
            }
            int wage = hoursWorked * 20;

            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Daily Wage: {wage}");
        }
    }

}
