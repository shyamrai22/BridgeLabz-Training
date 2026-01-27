using System;
using System.Reflection;

// ----------- Custom Annotation -----------
[AttributeUsage(AttributeTargets.Method)]
class OverrideInfoAttribute : Attribute
{
  public string Message { get; }

  public OverrideInfoAttribute(string message)
  {
    Message = message;
  }
}

// ----------- Parent Class -----------
class Animal
{
  // Virtual method
  public virtual void MakeSound()
  {
    Console.WriteLine("Animal makes a sound");
  }
}

// ----------- Child Class -----------
class Dog : Animal
{
  // Apply annotation to overridden method
  [OverrideInfo("Overrides Animal.MakeSound")]
  public override void MakeSound()
  {
    Console.WriteLine("Dog barks");
  }
}

// ----------- Main App -----------
class App
{
  static void Main()
  {
    // Create Dog object
    Dog dog = new Dog();
    dog.MakeSound();

    // Read annotation using Reflection
    Type type = typeof(Dog);

    MethodInfo method = type.GetMethod("MakeSound");

    OverrideInfoAttribute attr =
        method.GetCustomAttribute<OverrideInfoAttribute>();

    if (attr != null)
    {
      Console.WriteLine("Annotation Info: " + attr.Message);
    }
  }
}
