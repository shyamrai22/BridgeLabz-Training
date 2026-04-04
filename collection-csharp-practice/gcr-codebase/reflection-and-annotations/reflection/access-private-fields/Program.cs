using System;
using System.Reflection;

class Program
{
  static void Main()
  {
    Person person = new Person();

    // Get Type
    Type type = person.GetType();

    // Get private field "age"
    FieldInfo field = type.GetField(
        "age",
        BindingFlags.NonPublic | BindingFlags.Instance
    );

    // Get old value
    int oldAge = (int)field.GetValue(person);
    Console.WriteLine("Old Age: " + oldAge);

    // Modify value
    field.SetValue(person, 40);

    // Get new value
    int newAge = (int)field.GetValue(person);
    Console.WriteLine("New Age: " + newAge);

    // Check via normal method
    person.ShowAge();
  }
}
