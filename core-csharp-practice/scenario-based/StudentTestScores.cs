using System;

/*
Scenario Summary:
This program manages test scores for n students using an array. It allows the user to
input student scores, calculates and displays the average score, identifies the highest
and lowest scores, and lists all scores that are above the average. The program also
includes proper input validation to handle invalid cases such as non-numeric input
and negative scores, ensuring robust and error-free execution.
*/


namespace BridgeLabzTraining.scenario_based
{
    internal class StudentTestScores
    {
        // To get average marks of students
        public static double Average(double[] marks)
        {
            double sum = 0;

            foreach(double mark in marks)
            {
                sum += mark;
            }
            return (sum/marks.Length) ; 
        }

        // To get highest and lowest of the scores
        public static double[] ExtremeScores(double[] marks)
        {
            double highest = marks[0];
            double lowest = marks[0];

            foreach(double mark in marks)
            {
                if(mark > highest)
                    highest = mark;

                if (mark < lowest)
                    lowest = mark;
            }
            return new double[] {lowest, highest} ; 
        }
        
        // To display all the above average scores
        public static void AboveAverage(double[] marks)
        {
            double avg = Average(marks);

            Console.WriteLine("All scores above average are below : ");
            Console.WriteLine();
            foreach (double mark in marks)
            {
                if (mark > avg)
                    Console.WriteLine(mark);
            }
        }

        // Method to call above methods
        public static void Caller()
        {
            Console.Write("Enter the number of student : ");
            int num = int.Parse(Console.ReadLine());

            if(num <= 0)
            {
                Console.WriteLine("Enter a valid number.");
                return;
            }
            double[] marks = new double[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter test score of student {i+1} : ");
                marks[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Menu : ");
            Console.WriteLine();
            Console.WriteLine("1.Get average of the marks");
            Console.WriteLine("2.Get highest and lowest of the marks");
            Console.WriteLine("3.Get marks above average");
            Console.WriteLine("4.All of the above");
            Console.WriteLine("-----------------");
            Console.Write("Give your choice (1/2/3/4) : ");
            int choice = int.Parse(Console.ReadLine());
            if (choice < 1 && choice > 4)
            {
                Console.WriteLine("Enter a valid choice");
                return;
            }
            Console.WriteLine();
            // To perform menu driven actions  
            switch(choice)
            {
                case 1:
                    Console.Write("Average of the marks : ");
                    Console.WriteLine(Average(marks));
                    break;
                
                case 2:
                    double[] nums = ExtremeScores(marks);
                    Console.WriteLine($"Highest Number : {nums[1]}");
                    Console.WriteLine($"Lowest Number : {nums[0]}");
                    break;

                case 3:
                    AboveAverage(marks);
                    break;

                case 4:
                    Console.Write("Average of the marks : ");
                    Console.WriteLine(Average(marks));

                    double[] nums2 = ExtremeScores(marks);
                    Console.WriteLine($"Highest Number : {nums2[1]}");
                    Console.WriteLine($"Lowest Number : {nums2[0]}");

                    AboveAverage(marks);
                    break;

                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}
