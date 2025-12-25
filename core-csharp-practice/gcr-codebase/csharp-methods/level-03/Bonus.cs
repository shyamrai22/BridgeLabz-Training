using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Bonus
    {
        
        public static double[,] EmployeeData(int emp)
        {
            double[,] d = new double[emp, 2];
            Random rnd = new Random();

            for (int i = 0; i < emp; i++)
            {
                d[i, 0] = rnd.Next(10000, 100000); /
                d[i, 1] = rnd.Next(1, 11);        
            }

            return d;
        }

        
        public static double[,] BonusCal(double[,] d)
        {

            int row = d.GetLength(0);
            double[,] res = new double[row, 3];

            for (int i = 0; i < row; i++)
            {
                double oSalary = d[i, 0];
                double yrs = d[i, 1];

                double bRate = (yrs > 5) ? 0.05 : 0.02;
                double bonus = oSalary * bRate;
                double nSalary = oSalary + bonus;

                res[i, 0] = oSalary;
                res[i, 1] = bonus;
                res[i, 2] = nSalary;

            }

            return res;
        }

        
        public static void Display(double[,] data, double[,] salData)
        {

            double tOldSalary = 0;
            double tBonus = 0;
            double tNewSalary = 0;

            Console.WriteLine("Emp  OldSalary   Years   Bonus       NewSalary");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                double oSalary = salData[i, 0];
                double bonus = salData[i, 1];
                double nSalary = salData[i, 2];
                double yrs = data[i, 1];

                tOldSalary += oSalary;
                tBonus += bonus;
                tNewSalary += nSalary;

                Console.WriteLine($"{i + 1}   {oSalary}       {yrs}   {Math.Round(bonus, 2)}      {Math.Round(nSalary, 2)}");
            }

            Console.WriteLine();
            Console.WriteLine($"Total Old Salary : {Math.Round(tOldSalary, 2)}");
            Console.WriteLine($"Total Bonus      : {Math.Round(tBonus, 2)}");
            Console.WriteLine($"Total New Salary : {Math.Round(tNewSalary, 2)}");
        }

        // Calling above methods
        public static void Caller()
        {
            int emp = 10;

            double[,] empData = EmployeeData(emp);
            double[,] salaryData = BonusCal(empData);

            Display(empData, salaryData);
        }
    }
}
