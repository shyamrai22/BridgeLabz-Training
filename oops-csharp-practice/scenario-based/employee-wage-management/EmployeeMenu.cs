using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeService;

        public void EmployeeChoice()
        {
            employeeService = new EmployeeUtilityImpl();

            // UC:01
            bool isPresent = employeeService.IsEmployeePresent();

            if (isPresent)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}
