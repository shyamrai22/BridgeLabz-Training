using System;

namespace BridgeLabzTraining.methods.level_02
{
    internal class Bmi
    {
        // Calculating BMI and filling third column
        public static void BmiCalculations(double[,] d)
        {
            for (int i = 0; i < d.GetLength(0); i++)
            {
                double w = d[i, 0];
                double hCm = d[i, 1];

                double hMeters = hCm / 100;
                double bmi = w / (hMeters * hMeters);

                d[i, 2] = bmi;
            }
        }

        // Determining BMI status
        public static string[] BMIStatus(double[,] d)
        {
            string[] st = new string[d.GetLength(0)];

            for (int i = 0; i < d.GetLength(0); i++)
            {
                double bmi = d[i, 2];

                if (bmi <= 18.4)
                    st[i] = "Underweight";

                else if (bmi <= 24.9)
                    st[i] = "Normal";

                else if (bmi <= 39.9)
                    st[i] = "Overweight";
                
                else
                    st[i] = "Obese";
            
            }

            return st;
        
        }

        // Calling above methods
        public static void Caller()
        {
            double[,] d = new double[10, 3];

            
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter weight of person (kgs) {i + 1}: ");
                d[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Enter height of person (cms) {i + 1}: ");
                d[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

           
            BmiCalculations(d);

           
            string[] st = BMIStatus(d);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Person {i + 1}");
                Console.WriteLine($"Weight : {d[i, 0]} kg");
                Console.WriteLine($"Height : {d[i, 1]} cm");
                Console.WriteLine($"BMI    : {Math.Round(d[i, 2], 2)}");
                Console.WriteLine($"Status : {st[i]}");
            }

        }
    }
}
