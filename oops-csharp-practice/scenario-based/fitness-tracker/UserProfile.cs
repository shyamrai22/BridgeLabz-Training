using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    class UserProfile
    {
        private string name;
        private int age;
        private string gender;
        private double height;
        private double weight;
        private Workout[] workouts;
        private int workoutCount;

        public UserProfile(string name, int age, string gender, double height, double weight)
        {
            this.name = name;
            this.age = age; 
            this.gender = gender;
            this.height = height;
            this.weight = weight;
            workouts = new Workout[10];
            workoutCount = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public void AddWorkout(Workout workout)
        {
            if (workoutCount < workouts.Length)
            {
                workouts[workoutCount] = workout;
                workoutCount++;
            }
            else
            {
                Console.WriteLine("Workout limit reached.");
            }
        }
        public void DisplayWorkouts()
        {
            if (workoutCount == 0)
            {
                Console.WriteLine("No workouts added yet.");
                return;
            }

            Console.WriteLine("\n--- Workout History ---");

            for (int i = 0; i < workoutCount; i++)
            {
                Console.WriteLine($"Workout {i + 1}:");
                workouts[i].DisplayWorkoutInfo();
                Console.WriteLine($"Calories Burned: {workouts[i].CalculateCalories()}");
                Console.WriteLine("----------------------");
            }
        }
        public void DisplayUserInfo()
        {
            Console.WriteLine($"Name --> {name}");
            Console.WriteLine($"Age --> {age}");
            Console.WriteLine($"Gender --> {gender}");
            Console.WriteLine($"Height --> {height}");
            Console.WriteLine($"Weight --> {weight}");
        }

    }
}
