using System;

namespace BridgeLabzTraining.arrays.level_02
{
    internal class GradesTwo
    {
        public static void Assessment()
        {
            //Getting input from the user

            Console.Write("Enter number of student: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double[,] marks = new double[num, 3];
            double[] percentages = new double[num];
            char[] grades = new char[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write("Physics : ");
                marks[i, 0] = Convert.ToDouble(Console.ReadLine());
                if (marks[i, 0] < 0)
                {
                    Console.WriteLine("Marks");
                    i--;
                    continue;
                }

                Console.Write("Chemistry : ");
                marks[i, 1] = Convert.ToDouble(Console.ReadLine());
                
                if (marks[i, 1] < 0)
                {
                    Console.WriteLine("Marks");
                    i--;
                    continue;
                }

                Console.Write("Maths : ");
                marks[i, 2] = Convert.ToDouble(Console.ReadLine());
                
                if (marks[i, 2] < 0)
                {
                    Console.WriteLine("Marks");
                    i--;
                    continue;
                }

                //Calculations
                double t = marks[i, 0] + marks[i, 1] + marks[i, 2];
                percentages[i] = t / 3;
                
                if (percentages[i] >= 80) grades[i] = 'A';

                else if (percentages[i] >= 70) grades[i] = 'B';
                
                else if (percentages[i] >= 60) grades[i] = 'C';
                
                else if (percentages[i] >= 50) grades[i] = 'D';
                
                else if (percentages[i] >= 40) grades[i] = 'E';
                
                else grades[i] = 'R';
            }

            //Output
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"student {i + 1} percentage = {percentages[i]}%, grade = {grades[i]}");
            }
        }
    }
}