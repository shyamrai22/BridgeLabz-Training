using TechVille.Model;
using System.Collections.Generic;

namespace TechVille.Service
{
  public class ServiceRequestQueue
  {
    private Queue<Citizen> queue = new Queue<Citizen>();

    public void Enqueue(Citizen citizen)
    {
      queue.Enqueue(citizen);
    }

    public Citizen Dequeue()
    {
      if (queue.Count == 0)
        return null;

      return queue.Dequeue();
    }

    public void Display()
    {
      foreach (var citizen in queue)
      {
        Console.WriteLine(citizen);
      }
    }
  }
}
