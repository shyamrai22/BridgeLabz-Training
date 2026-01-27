using System;
using System.Reflection;

// ----------- Custom Role Attribute -----------
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
  public string Role { get; }

  public RoleAllowedAttribute(string role)
  {
    Role = role;
  }
}

// ----------- User Simulation -----------
class User
{
  public string Name { get; set; }
  public string Role { get; set; }
}

// ----------- Secure Service -----------
class AdminService
{
  [RoleAllowed("ADMIN")]
  public void DeleteUser()
  {
    Console.WriteLine("User deleted successfully.");
  }

  [RoleAllowed("USER")]
  public void ViewProfile()
  {
    Console.WriteLine("Profile viewed.");
  }
}

// ----------- Access Manager -----------
class AccessManager
{
  public static void Execute(User user, object service, string methodName)
  {
    Type type = service.GetType();

    MethodInfo method = type.GetMethod(methodName);

    if (method == null)
    {
      Console.WriteLine("Method not found!");
      return;
    }

    // Get RoleAllowed attribute
    RoleAllowedAttribute attr =
        method.GetCustomAttribute<RoleAllowedAttribute>();

    if (attr != null)
    {
      // Check role
      if (user.Role != attr.Role)
      {
        Console.WriteLine("Access Denied!");
        return;
      }
    }

    // If allowed, execute
    method.Invoke(service, null);
  }
}

// ----------- Main App ----------------
class App
{
  static void Main()
  {
    AdminService service = new AdminService();

    // Simulate users
    User admin = new User
    {
      Name = "Shyam",
      Role = "ADMIN"
    };

    User normalUser = new User
    {
      Name = "Amit",
      Role = "USER"
    };

    Console.WriteLine("Admin tries to delete:");
    AccessManager.Execute(admin, service, "DeleteUser");

    Console.WriteLine();

    Console.WriteLine("User tries to delete:");
    AccessManager.Execute(normalUser, service, "DeleteUser");

    Console.WriteLine();

    Console.WriteLine("User views profile:");
    AccessManager.Execute(normalUser, service, "ViewProfile");
  }
}
