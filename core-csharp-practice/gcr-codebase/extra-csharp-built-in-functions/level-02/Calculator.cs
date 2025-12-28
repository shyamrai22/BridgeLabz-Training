using System;

namespace BridgeLabzTraining.extras_csharp_built_in_functions.level_02
{
    class BasicCalculator
    {
        public static void Caller()
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1> Addition");
            Console.WriteLine("2> Subtraction");
            Console.WriteLine("3> Multiplication");
            Console.WriteLine("4> Division");

            int c = Input("Enter choice 1-4: ");

            double num1 = DoubleInput("Enter 1st number: ");
            double num2 = DoubleInput("Enter 2nd number: ");

            double res;

            switch (c)
            {
                case 1:
                    res = Add(num1, num2);
                    break;

                case 2:
                    res = Sub(num1, num2);
                    break;

                case 3:
                    res = Mul(num1, num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero not allowed");
                        return;
                    }
                    res = Div(num1, num2);
                    break;

                default:
                    Console.WriteLine("Invalid");
                    return;
            }

            Display(res);
        }

        static double DoubleInput(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Sub(double x, double y)
        {
            return x - y;
        }

        static double Mul(double x, double y)
        {
            return x * y;
        }

        static double Div(double x, double y)
        {
            return x / y;
        }

        // Output
        static void Display(double res)
        {
            Console.WriteLine($"Result : {res}");
        }
    }
}
