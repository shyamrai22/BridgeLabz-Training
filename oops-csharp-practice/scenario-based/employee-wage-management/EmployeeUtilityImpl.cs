using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        private int WAGE_PER_HOUR = 20;
        private int FULL_DAY_HOURS = 8;
        private int PART_TIME_HOURS = 4;

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

        // UC:03
        public int CalculatePartTimeWage()
        {
            int wage = WAGE_PER_HOUR * PART_TIME_HOURS;
            return wage;
        }

        // UC:04
        public int GetWorkingHour()
        {
            Random random = new Random();
            int attendance = random.Next(3);

            switch(attendance)
            {
                case 1:
                    return FULL_DAY_HOURS;

                case 2:
                    return PART_TIME_HOURS;

                default:
                    return 0;
            }
        }

        // UC:05
        public int CalculateMonthlyWage()
        {
            int totalWage = 0;

            for (int day = 1; day <= 20; day++)
            {
                totalWage += GetWorkingHour() * WAGE_PER_HOUR;
            }
            return totalWage;
        }

        // UC:06
        public int CalculateWageWithCondition()
        {
            int totalHours = 0;
            int totalDays = 0;
            int totalWage = 0;

            while (totalHours < 100 && totalDays < 20)
            {
                int hours = GetWorkingHour();
                totalHours += hours;
                totalWage += hours * WAGE_PER_HOUR;
                if(hours > 0) 
                    totalDays++;
            }
            return totalWage;
        }



    }
}
