using System;

/*
    EduQuiz is a console-based quiz grading application that presents 10 True/False
    questions to the user. The program collects student responses, allowing answers
    as True, False, or Skipped. It then compares the responses with predefined correct
    answers to calculate the total score, display per-question feedback, and compute
    the final percentage.

    The user can choose from a menu to:
    1) Calculate score
    2) View feedback for each question
    3) Calculate percentage and pass/fail status
    4) View all results together

    The application demonstrates the use of arrays, loops, conditional statements,
    methods, user input handling, and basic validation in C#.
*/


namespace BridgeLabzTraining.scenario_based._30th_December
{
    internal class EduQuiz
    {
        // Method to generate questions and take in answers
        public static string[] GenerateQuestionsAndTakeAnswers()
        {
            string[] studentAnswers = new string[10];
            string[] questions = {
                                    "Python is an interpreted programming language.",
                                    "HTML is a programming language.",
                                    "In C#, int is a value type.",
                                    "Git is used for version control.",
                                    "CSS is used to style web pages.",
                                    "A Boolean variable can store more than two values.",
                                    "In Java, main() is the entry point of the program.",
                                    "SQL is used to manage and query databases.",
                                    "An array index always starts from 1 in all programming languages.",
                                    "Machine Learning is a subset of Artificial Intelligence."
                                 };
            int answerIndex = 0;
            foreach (string ques in questions)
            {
                Console.WriteLine($"Q->{ques}");
                Console.Write($"A-> ");
                string temp = Console.ReadLine();
                if (temp.ToLower() == "t")
                {
                    studentAnswers[answerIndex++] = "True";
                }
                else if (temp.ToLower() == "f")
                {
                    studentAnswers[answerIndex++] = "False";
                }
                else if (temp.ToLower() == "")
                {
                    studentAnswers[answerIndex++] = "Skipped";
                }
                Console.WriteLine();
                
            }
            return studentAnswers;
        }

        // Method to calculate the score
        public static int CalculateScore(string[] correctAnswers, string[] studentAnswers)
        {
            int score = 0;
            for (int i=0; i<correctAnswers.Length; i++)
            {
                if (correctAnswers[i] == studentAnswers[i])
                    score++;
            } 
            return score;
        }

        // Method to display the feedback
        public static void DisplayFeedback(string[] correctAnswers, string[] studentAnswers)
        {
            for(int i=0; i<correctAnswers.Length; i++)
            {
                if(correctAnswers[i] == studentAnswers[i])
                {
                    Console.WriteLine($"Question {i} --> Correct");
                }
                else if(correctAnswers[i] != studentAnswers[i])
                {
                    Console.WriteLine($"Question {i} --> Incorrect");
                }
                else if(studentAnswers[i].ToLower() == "skipped")
                {
                    Console.WriteLine($"Question {i} --> Skipped this question");
                }
            }
        }

        // Method to calculate percentage
        public static double CalculatePercentage(string[] correctAnswers, string[] studentAnswers)
        {
            double score = (double) CalculateScore(correctAnswers, studentAnswers);
            return (score/(double)(correctAnswers.Length)) * 100.0 ;
        }
        
        // This acts as the main method, all the above functions are called here
        public static void Caller()
        {
            Console.WriteLine("-------Welcome to EduQuiz--------");
            Console.WriteLine("----Your very own grading app----");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Answer below questions in either 'T'(True) or 'F'(False):");
            Console.WriteLine("To skip the question press ENTER :");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            string[] correctAnswers = { "True", "False", "True", "True", "True", "False", "True", "True", "False", "True" };
            string[] studentAnswers = GenerateQuestionsAndTakeAnswers();
            Console.WriteLine();
            Console.WriteLine("------Menu------");
            Console.WriteLine("1. Calculate score");
            Console.WriteLine("2. Display feedback");
            Console.WriteLine("3. Calculate percentage");
            Console.WriteLine("4. All of the above");
            Console.WriteLine();
            Console.Write("Enter your choice(1/2/3/4) : ");
            int choice = int.Parse(Console.ReadLine());
            if(choice < 1 || choice > 4)
            {
                Console.WriteLine("Enter valid choice.");
                return;
            }
            // Used to create a menu-driven application
            switch(choice)
            {
                case 1:
                    Console.WriteLine($"Your score is --> {CalculateScore(correctAnswers,studentAnswers)}/10");
                    break;

                case 2:
                    DisplayFeedback(correctAnswers,studentAnswers);
                    break;

                case 3:
                    double percent = CalculatePercentage(correctAnswers,studentAnswers);
                    Console.WriteLine($"Your percentage --> {percent:F2}%");
                    if (percent >= 40.0)
                        Console.WriteLine("Passed");
                    else Console.WriteLine("Failed. Try Again");
                    break;

                case 4:
                    Console.WriteLine($"Your score is --> {CalculateScore(correctAnswers, studentAnswers)}/10");
                    Console.WriteLine();
                    DisplayFeedback(correctAnswers, studentAnswers);
                    Console.WriteLine();
                    double percent2 = CalculatePercentage(correctAnswers, studentAnswers);
                    Console.WriteLine($"Your percentage --> {percent2:F2}%");
                    if (percent2 >= 40.0)
                        Console.WriteLine("Passed");
                    else Console.WriteLine("Failed. Try Again");
                    break;

            }
        }
    }
}
