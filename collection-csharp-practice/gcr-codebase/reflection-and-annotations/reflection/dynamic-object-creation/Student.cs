class Student
{
  public string Name;
  public int Age;

  public Student(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public void Show()
  {
    Console.WriteLine($"Name: {Name}, Age: {Age}");
  }
}
