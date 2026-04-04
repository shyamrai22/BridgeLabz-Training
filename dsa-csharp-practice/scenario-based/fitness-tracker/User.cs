/// <summary>
/// The User class represents an individual user in the Fitness Tracker application.
/// It encapsulates user-related data such as the user ID, username, and step count.
/// This class acts as a data model and provides a readable string representation
/// of a user's activity through an overridden ToString method.
/// </summary>


class User
{
  public string UserId { get; set; }
  public string Username { get; set; }
  public int StepsCount { get; set; }

  public User(string userId, string username, int stepsCount)
  {
    UserId = userId;
    Username = username;
    StepsCount = stepsCount;
  }

  public override string ToString()
  {
    return $"{Username} ----> {StepsCount}";
  }
}