using System;

class Program
{
  static void Main()
  {
    // Get Type
    Type type = typeof(Student);

    // Create object dynamically
    object obj = Activator.CreateInstance(
        type,
        "Shyam",
        22
    );

    // Cast
    Student student = (Student)obj;

    student.Show();
  }
}
