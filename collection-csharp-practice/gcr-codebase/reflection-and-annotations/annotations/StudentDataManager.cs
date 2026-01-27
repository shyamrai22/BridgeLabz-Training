using System;
using System.Collections;

class StudentDataManager
{
  public void ShowData()
  {
#pragma warning disable CS8600   // Suppress null conversion warning

    // Using old non-generic collection
    ArrayList students = new ArrayList();

    students.Add(1);
    students.Add("Shyam");
    students.Add(22);

    // Unsafe cast (may cause warning)
    int id = (int)students[0];

#pragma warning restore CS8600

    Console.WriteLine("Student ID: " + id);

    Console.WriteLine("All Data:");
    foreach (var item in students)
    {
      Console.WriteLine(item);
    }
  }
}

class App
{
  static void Main()
  {
    StudentDataManager manager = new StudentDataManager();
    manager.ShowData();
  }
}
