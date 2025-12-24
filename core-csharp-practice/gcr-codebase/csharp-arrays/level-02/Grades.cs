using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class Grades
    {
        public static void Assessment()
        {
            // Input

            Console.Write("Enter number of students: ");
            int num = Convert.ToInt32(Console.ReadLine());

            double[] phy = new double[num];
            
            double[] chem = new double[num];
            
            double[] maths = new double[num];
            
            double[] percentArr = new double[num];
            
            char[] gradeArr = new char[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Physics: ");
                phy[i] = Convert.ToDouble(Console.ReadLine());
                if (phy[i] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }

                Console.Write("Chemistry: ");
                chem[i] = Convert.ToDouble(Console.ReadLine());
                if (chem[i] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }

                Console.Write("Maths: ");
                maths[i] = Convert.ToDouble(Console.ReadLine());
                if (maths[i] < 0)
                {
                    Console.WriteLine("Enter positive marks");
                    i--;
                    continue;
                }

                // Calculations
                double total = phy[i] + chem[i] + maths[i];
                percentArr[i] = total / 3;

                if (percentArr[i] >= 80) gradeArr[i] = 'A';

                else if (percentArr[i] >= 70) gradeArr[i] = 'B';
                
                else if (percentArr[i] >= 60) gradeArr[i] = 'C';
                
                else if (percentArr[i] >= 50) gradeArr[i] = 'D';
                
                else if (percentArr[i] >= 40) gradeArr[i] = 'E';
                
                else gradeArr[i] = 'R';
            }


            // Output
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Student {i + 1} Percentage = {percentArr[i]}%, Grade = {gradeArr[i]}");
            }
        }
    }
}