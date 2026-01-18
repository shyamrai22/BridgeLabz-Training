/// <summary>
/// The FitnessTrackerMain class serves as the entry point of the Fitness Tracker
/// console application. It initializes the menu layer and starts the menu-driven
/// workflow by invoking the StartMenu method. This class keeps the application
/// bootstrap logic minimal and maintains a clean separation between startup
/// responsibilities and user interaction handling.
/// </summary>


using System;

class FitnessTrackerMain
{
  static void Main()
  {
    FitnessTrackerMenu menu = new FitnessTrackerMenu();
    menu.StartMenu();
  }
}