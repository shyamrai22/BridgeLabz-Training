class Program
{
  static void Main()
  {
    Dictionary<string, object> data = new()
        {
            { "Id", 1 },
            { "Name", "Shyam" },
            { "Age", 22 }
        };

    Student s = ObjectMapper.ToObject<Student>(
        typeof(Student),
        data
    );

    s.Show();
  }
}
