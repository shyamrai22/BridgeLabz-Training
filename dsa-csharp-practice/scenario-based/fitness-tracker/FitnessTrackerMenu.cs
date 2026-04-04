/// <summary>
/// The FitnessTrackerMenu class provides a console-based, menu-driven user interface
/// for interacting with the Fitness Tracker application. It allows users to add new
/// users, update step counts for existing users, view the top-performing users based
/// on their step counts, and exit the application. The class acts as an intermediary
/// between user input and the core business logic exposed through the IFitnessTracker
/// interface.
/// </summary>


using System;

class FitnessTrackerMenu
{
  private IFitnessTracker FitnessTrackerService;
  public void StartMenu()
  {
    FitnessTrackerService = new FitnessTrackerUtilityImpl();
    while (true)
    {
      Console.WriteLine("Welcome to your very own Fitness-Tracker app");
      Console.WriteLine("1. Add a user.");
      Console.WriteLine("2. Update user's step count.");
      Console.WriteLine("3. See top performers.");
      Console.WriteLine("0. To exit.");
      int choice;
      Console.WriteLine("Enter your choice -->");
      int.TryParse(Console.ReadLine(), out choice);
      switch (choice)
      {
        case 0:
          Console.WriteLine("Exiting....");
          return;
        case 1:
          Console.Write("Enter userid --> ");
          string userId = Console.ReadLine();
          Console.Write("Enter username --> ");
          string username = Console.ReadLine();
          Console.Write("Enter user's steps count --> ");
          int stepCount = int.Parse(Console.ReadLine());
          User newUser = new User(userId, username, stepCount);
          FitnessTrackerService.AddUser(newUser);
          break;
        case 2:
          Console.Write("Enter username --> ");
          string username02 = Console.ReadLine();
          FitnessTrackerService.AddSteps(username02);
          break;
        case 3:
          Console.WriteLine("Top Performers:");
          Console.WriteLine("---------------");
          FitnessTrackerService.TopPerformers(5);
          break;
        default:
          Console.WriteLine("Invalid choice");
          break;
      }
    }
  }
}