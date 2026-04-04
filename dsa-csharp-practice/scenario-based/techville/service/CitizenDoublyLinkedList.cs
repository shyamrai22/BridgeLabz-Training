using TechVille.Model;

namespace TechVille.Service
{
  public class CitizenDoublyLinkedList
  {
    private CitizenNode head;
    private CitizenNode tail;

    public void Insert(Citizen citizen)
    {
      CitizenNode newNode = new CitizenNode(citizen);

      if (head == null)
      {
        head = tail = newNode;
        return;
      }

      tail.Next = newNode;
      newNode.Prev = tail;
      tail = newNode;
    }

    public void DisplayForward()
    {
      CitizenNode temp = head;

      while (temp != null)
      {
        Console.WriteLine(temp.Data);
        temp = temp.Next;
      }
    }

    public void DisplayBackward()
    {
      CitizenNode temp = tail;

      while (temp != null)
      {
        Console.WriteLine(temp.Data);
        temp = temp.Prev;
      }
    }
  }
}
