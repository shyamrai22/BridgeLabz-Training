using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmployeeMenu menu = new EmployeeMenu();
            menu.EmployeeChoice();

            Console.WriteLine("Program terminated.");
        }
    }
}
