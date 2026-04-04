using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Employee employee;
        private int wagePerHour = 20;
        private int fullDayHours = 8;
        private int partTimeHours = 4;

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
            int wage = wagePerHour * fullDayHours;
            return wage;
        }

        // UC:03
        public int CalculatePartTimeWage()
        {
            int wage = wagePerHour * partTimeHours;
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
                    return fullDayHours;

                case 2:
                    return partTimeHours;

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
                totalWage += GetWorkingHour() * wagePerHour;
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
                totalWage += hours * wagePerHour;
                if(hours > 0) 
                    totalDays++;
            }
            return totalWage;
        }



    }
}
