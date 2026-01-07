using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeMain
    { 
        public static void Main(string[] args)
        {   
            // UC:00
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeMenu employeeMenu = new EmployeeMenu();

            // UC:01
            //employeeMenu.EmployeeChoice();

            // UC:02
            employeeMenu.EmployeeChoice();

        }
    }
}
