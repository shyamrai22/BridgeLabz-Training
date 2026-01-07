using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_management
{
    interface IEmployee
    {
        Employee AddEmployee();

        // UC:01
        bool IsEmployeePresent();

        // UC:02
        int CalculateDailyWage();

        // UC:03
        int CalculatePartTimeWage();

        // UC:04
        int GetWorkingHour();

        // UC:05
        int CalculateMonthlyWage();

        // UC:06
        int CalculateWageWithCondition();
    }
}
