using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        private int WAGE_PER_HOUR = 20;
        private int FULL_DAY_HOURS = 8;

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

        // UC:02
        public int CalculateDailyWage()
        {
            int wage = WAGE_PER_HOUR * FULL_DAY_HOURS;
            return wage;
        }

    }
}
