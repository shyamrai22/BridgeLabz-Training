class Student
{
  public int Id;
  public string Name;
  public int Age;

  public void Show()
  {
    Console.WriteLine($"{Id} - {Name} - {Age}");
  }
}
