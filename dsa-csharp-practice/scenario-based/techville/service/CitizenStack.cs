using TechVille.Model;
using System.Collections.Generic;

namespace TechVille.Service
{
  public class CitizenStack
  {
    private Stack<Citizen> stack = new Stack<Citizen>();

    public void Push(Citizen citizen)
    {
      stack.Push(citizen);
    }

    public Citizen Pop()
    {
      if (stack.Count == 0)
        return null;

      return stack.Pop();
    }

    public void Display()
    {
      foreach (var citizen in stack)
      {
        Console.WriteLine(citizen);
      }
    }
  }
}
