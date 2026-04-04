/// <summary>
/// The IFitnessTracker interface defines the core operations supported by the
/// Fitness Tracker application. It establishes a contract for adding users,
/// updating step counts for existing users, and retrieving the top-performing
/// users based on their activity data. Implementing classes are responsible for
/// providing the concrete business logic for these operations.
/// </summary>


interface IFitnessTracker
{
  void AddUser(User user);
  void AddSteps(string username);
  void TopPerformers(int n);
}