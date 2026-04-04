using TechVille.Model;

namespace TechVille.Service
{
  public class CitizenCircularLinkedList
  {
    private CitizenNode head;
    private CitizenNode tail;

    public void Insert(Citizen citizen)
    {
      CitizenNode newNode = new CitizenNode(citizen);

      if (head == null)
      {
        head = tail = newNode;
        tail.Next = head;
        return;
      }

      tail.Next = newNode;
      tail = newNode;
      tail.Next = head;
    }

    public void Display()
    {
      if (head == null)
        return;

      CitizenNode temp = head;

      do
      {
        Console.WriteLine(temp.Data);
        temp = temp.Next;
      }
      while (temp != head);
    }
  }
}
