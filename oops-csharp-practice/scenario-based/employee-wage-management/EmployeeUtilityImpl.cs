using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;

        public Employee AddEmployee()
        {
            employee = new Employee(); 
            return employee;
        }

        // UC:01
        public bool IsEmployeePresent()
        {
            Random random = new Random();
            int attendance = random.Next(2);
            return attendance == 1;

        }

    }
}
