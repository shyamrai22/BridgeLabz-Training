/// <summary>
/// The FitnessTrackerUtilityImpl class implements the IFitnessTracker interface and
/// contains the core business logic for the Fitness Tracker application. It manages
/// users using a fixed-size array, supports adding new users, updating step counts,
/// and retrieving the top-performing users based on their step counts. The class
/// uses an internal Bubble Sort implementation to rank users without modifying the
/// original data and provides separate constructors for production use and testing
/// with pre-filled sample data.
/// </summary>


using System;

class FitnessTrackerUtilityImpl : IFitnessTracker
{
  private int Capacity;
  private User[] Users = {
                            new User("U001", "Shyam", 8500),
                            new User("U002", "Arpit", 12000),
                            new User("U003", "Sambhav", 6500),
                            new User("U004", "Rohit", 15000),
                            new User("U005", "Aman", 4000)
                          };
  private int UserCount = 5;

  public FitnessTrackerUtilityImpl(int capacity)
  {
    Capacity = capacity;
    Users = new User[capacity];
    UserCount = 0;
  }

  //Constructor for TESTING
  public FitnessTrackerUtilityImpl()
  {
    Users = new User[]
    {
            new User("U001", "Shyam", 8500),
            new User("U002", "Arpit", 12000),
            new User("U003", "Sambhav", 6500),
            new User("U004", "Rohit", 15000),
            new User("U005", "Aman", 4000)
    };

    UserCount = Users.Length;
    Capacity = Users.Length;
  }

  public void AddUser(User user)
  {
    if (UserCount >= Capacity)
    {
      Console.WriteLine("UserList is already full.");
      return;
    }
    Users[UserCount++] = user;
    Console.WriteLine("User added successfully.");
  }

  public void AddSteps(string username)
  {
    for (int i = 0; i < UserCount; i++)
    {
      if (Users[i].Username.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine(Users[i]);
        Console.Write("Enter the number of steps to add --> ");
        int steps = int.Parse(Console.ReadLine());
        Users[i].StepsCount += steps;
        Console.WriteLine("Steps added successfully");
        Console.WriteLine(Users[i]);
        return;
      }
    }
    Console.WriteLine($"User: {username}, not found.");
  }

  public void TopPerformers(int n)
  {
    User[] topPerformers = BubbleSort(Users);
    int limit = Math.Min(n, topPerformers.Length);
    for (int i = 0; i < limit; i++)
    {
      Console.WriteLine($"{i + 1}. {topPerformers[i]}");
    }
  }

  private User[] BubbleSort(User[] users)
  {
    User[] topPerformers = new User[UserCount];
    Array.Copy(users, topPerformers, UserCount);
    for (int i = 0; i < UserCount - 1; i++)
    {
      bool swapped = false;
      for (int j = 0; j < UserCount - i - 1; j++)
      {
        if (topPerformers[j].StepsCount < topPerformers[j + 1].StepsCount)
        {
          User temp = topPerformers[j];
          topPerformers[j] = topPerformers[j + 1];
          topPerformers[j + 1] = temp;

          swapped = true;
        }
      }
      if (!swapped)
      {
        break;
      }
    }
    return topPerformers;
  }
}