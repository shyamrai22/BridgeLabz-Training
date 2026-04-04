namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    class StrengthWorkout : Workout
    {
        private int sets;
        private int repsPerSet;
        private double weightLifted;

        public StrengthWorkout(
            string workoutName,
            double duration,
            double userWeight,
            int sets,
            int repsPerSet,
            double weightLifted
        ) : base(workoutName, duration, userWeight)
        {
            this.sets = sets;
            this.repsPerSet = repsPerSet;
            this.weightLifted = weightLifted;
        }

        public override double CalculateCalories()
        {
            double intensityFactor = 6.0; 
            return intensityFactor * GetUserWeight * GetDuration;
        }

        public override double GetWorkoutDuration()
        {
            return base.GetDuration;
        }
    }
}
