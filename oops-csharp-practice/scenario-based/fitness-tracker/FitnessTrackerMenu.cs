using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    class FitnessTrackerMenu
    {
        public void Start()
        {
            Console.WriteLine("Welcome to Fitness Track");

            // Create user profile
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Enter Weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Height (cm): ");
            double height = double.Parse(Console.ReadLine());

            UserProfile user = new UserProfile(name, age, gender, height, weight);

            bool running = true;

            while (running)
            {
                Console.WriteLine("Fitness Tracker Menu");
                Console.WriteLine("1. Add Cardio Workout");
                Console.WriteLine("2. Add Strength Workout");
                Console.WriteLine("3. View Workouts");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCardioWorkout(user);
                        break;

                    case 2:
                        AddStrengthWorkout(user);
                        break;

                    case 3:
                        user.DisplayWorkouts();
                        break;

                    case 4:
                        running = false;
                        Console.WriteLine("Thank you for using Fitness Track!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void AddCardioWorkout(UserProfile user)
        {
            Console.Write("Workout Name: ");
            string name = Console.ReadLine();

            Console.Write("Duration (hours): ");
            double duration = double.Parse(Console.ReadLine());

            Console.Write("Distance (km): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("MET value: ");
            double met = double.Parse(Console.ReadLine());

            CardioWorkout workout =
                new CardioWorkout(name, duration, user.Weight, distance, met);

            user.AddWorkout(workout);

            Console.WriteLine("Cardio workout added successfully!");
        }

        private void AddStrengthWorkout(UserProfile user)
        {
            Console.Write("Workout Name: ");
            string name = Console.ReadLine();

            Console.Write("Duration (hours): ");
            double duration = double.Parse(Console.ReadLine());

            Console.Write("Sets: ");
            int sets = int.Parse(Console.ReadLine());

            Console.Write("Reps per set: ");
            int reps = int.Parse(Console.ReadLine());

            Console.Write("Weight lifted (kg): ");
            double liftedWeight = double.Parse(Console.ReadLine());

            StrengthWorkout workout =
                new StrengthWorkout(name, duration, user.Weight, sets, reps, liftedWeight);

            user.AddWorkout(workout);

            Console.WriteLine("Strength workout added successfully!");
        }
    }
}
