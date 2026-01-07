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
    }
}
