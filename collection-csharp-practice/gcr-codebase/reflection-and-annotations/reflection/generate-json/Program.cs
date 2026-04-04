class Program
{
  static void Main()
  {
    Student s = new Student
    {
      Id = 1,
      Name = "Shyam",
      Age = 22
    };

    string json = JsonSerializer.ToJson(s);

    Console.WriteLine(json);
  }
}
