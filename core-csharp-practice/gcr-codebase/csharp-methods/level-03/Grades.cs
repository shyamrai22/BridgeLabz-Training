using System;

namespace BridgeLabzTraining.methods.level_03
{
    internal class Grades
    {
        
        public static int[,] Marks(int student)
        {
            int[,] m = new int[student, 3];
            Random rnd = new Random();

            for (int i = 0; i < student; i++)
            {

                m[i, 0] = rnd.Next(10, 100);
                m[i, 1] = rnd.Next(10, 100);
                m[i, 2] = rnd.Next(10, 100);

            }

            return m;
        }

        
        public static double[,] Results(int[,] m)
        {
            int student = m.GetLength(0);
         
            double[,] res = new double[student, 3];

            for (int i = 0; i < student; i++)
            {

                int t = m[i, 0] + m[i, 1] + m[i, 2];
                double avg = t / 3.0;
                double per = (t / 300.0) * 100;


                res[i, 0] = t;
                res[i, 1] = Math.Round(avg, 2);
                res[i, 2] = Math.Round(per, 2);
            }

            return res;
        }

        // Grade calculation
        public static string Grade(double per)
        {
            if (per >= 80) return "A";
            if (per >= 70) return "B";
            if (per >= 60) return "C";
            if (per >= 50) return "D";
            if (per >= 40) return "E";
            return "R";
        }

        // Display 
        public static void Display(int[,] m, double[,] res)
        {
            Console.WriteLine("Stu  Phy     Chem    Math    TotalAvg    %   Grade");

            for (int i = 0; i < m.GetLength(0); i++)
            {
                string grade = Grade(res[i, 2]);

                Console.WriteLine(
                    $"{i + 1}   {m[i, 0]}   {m[i, 1]}   {m[i, 2]}   " + $"{res[i, 0]}   {res[i, 1]} {res[i, 2]} {grade}"
                );
            }
        }

        // Calling above methods
        public static void Caller()
        {
            Console.Write("Enter number of students: ");
            int student = Convert.ToInt32(Console.ReadLine());
            int[,] m = Marks(student);
            double[,] res = Results(m);
            Display(m, res);

        }
    }
}
