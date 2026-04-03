using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class Bonus
    {
        public static void BonusCalculation()
        {
            int empCount = 10;

            // Arrays for input
            double[] salary = new double[empCount];
            double[] y = new double[empCount];

            // Arrays for output
            double[] bonus = new double[empCount];
            double[] newSalary = new double[empCount];

            double tOldSalary = 0;
            double tBonus = 0;
            double tNewSalary = 0;

            // Input
            for (int i = 0; i < empCount; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}");

                Console.Write("Salary: ");
                bool salaryValid = double.TryParse(Console.ReadLine(), out salary[i]);

                Console.Write("Years of Service: ");
                bool yearValid = double.TryParse(Console.ReadLine(), out y[i]);

                if (!salaryValid || !yearValid || salary[i] <= 0 || y[i] < 0)
                {
                    Console.WriteLine("Invalid input! Please enter valid numbers.");
                    i--;
                    continue;
                }
            }

            // Calculation
            for (int i = 0; i < empCount; i++)
            {
                if (y[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;
                }

                newSalary[i] = salary[i] + bonus[i];

                tOldSalary += salary[i];
                tBonus += bonus[i];
                tNewSalary += newSalary[i];
            }

            // Output
            Console.WriteLine("\nEmployee Salary Details");
            for (int i = 0; i < empCount; i++)
            {
                Console.WriteLine(
                    $"Employee {i + 1}: Old Salary = {salary[i]}, Bonus = {bonus[i]}, New Salary = {newSalary[i]}"
                );
            }

            Console.WriteLine("\nCompany Summary (Zara)");
            Console.WriteLine($"Total Old Salary  : {tOldSalary}");
            Console.WriteLine($"Total Bonus Paid : {tBonus}");
            Console.WriteLine($"Total New Salary : {tNewSalary}");
        }
    }
}
