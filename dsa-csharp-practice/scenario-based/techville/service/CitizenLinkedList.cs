using TechVille.Model;

namespace TechVille.Service
{
  public class CitizenLinkedList
  {
    private CitizenNode head;

    public void Insert(Citizen citizen)
    {
      CitizenNode newNode = new CitizenNode(citizen);

      if (head == null)
      {
        head = newNode;
        return;
      }

      CitizenNode temp = head;
      while (temp.Next != null)
      {
        temp = temp.Next;
      }

      temp.Next = newNode;
    }

    public void Display()
    {
      CitizenNode temp = head;

      while (temp != null)
      {
        Console.WriteLine(temp.Data);
        temp = temp.Next;
      }
    }

    public void Delete(int citizenId)
    {
      if (head == null)
        return;

      if (head.Data.CitizenId == citizenId)
      {
        head = head.Next;
        return;
      }

      CitizenNode temp = head;

      while (temp.Next != null && temp.Next.Data.CitizenId != citizenId)
      {
        temp = temp.Next;
      }

      if (temp.Next != null)
      {
        temp.Next = temp.Next.Next;
      }
    }
  }
}
