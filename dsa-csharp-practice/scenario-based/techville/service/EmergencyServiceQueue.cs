using TechVille.Model;
using System.Collections.Generic;

namespace TechVille.Service
{
  public class EmergencyServiceQueue
  {
    private PriorityQueue<Citizen, int> priorityQueue =
        new PriorityQueue<Citizen, int>();

    public void Enqueue(Citizen citizen, int priority)
    {
      priorityQueue.Enqueue(citizen, priority);
    }

    public Citizen Dequeue()
    {
      if (priorityQueue.Count == 0)
        return null;

      return priorityQueue.Dequeue();
    }

    public void Display()
    {
      foreach (var item in priorityQueue.UnorderedItems)
      {
        Console.WriteLine(item.Element);
      }
    }
  }
}
