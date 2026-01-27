class Student
{
  public int Id;
  private string Name;

  public Student() { }

  public Student(int id, string name)
  {
    Id = id;
    Name = name;
  }

  public void Show()
  {
    Console.WriteLine("Student Info");
  }

  private void Secret()
  {
    Console.WriteLine("Secret Method");
  }
}
