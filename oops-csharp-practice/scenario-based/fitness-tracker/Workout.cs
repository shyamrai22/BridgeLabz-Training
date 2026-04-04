using System;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    abstract class Workout : ITrackable
    {
        private string workoutName;
        private double duration;
        private double userWeight;

        public double GetDuration
        {
            get { return duration;}
        }
        public double GetUserWeight
        {
            get { return userWeight;}
        }

        public Workout(string workoutName, double duration, double userWeight)
        {
            this.workoutName = workoutName;
            this.duration = duration;
            this.userWeight = userWeight;
        }

        public abstract double CalculateCalories();
        public abstract double GetWorkoutDuration();

        public void DisplayWorkoutInfo()
        {
            Console.WriteLine($"Workout Name --> {workoutName}");
            Console.WriteLine($"Duration --> {duration}");
        }


    }
}
