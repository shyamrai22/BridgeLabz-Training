namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    class CardioWorkout : Workout
    {
        private double distance;
        private double met;

        public CardioWorkout(string workoutName, double duration, double userWeight,
                             double distance, double met) : base(workoutName, duration, userWeight)
        {
            this.distance = distance; 
            this.met = met;
        }

        public override double CalculateCalories()
        {
            return met * GetUserWeight * GetDuration;
        }

        public override double GetWorkoutDuration()
        {
            return base.GetDuration;
        }
    }
}
