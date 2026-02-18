namespace TechVille.Model
{
  public class CitizenNode
  {
    public Citizen Data { get; set; }
    public CitizenNode Next { get; set; }
    public CitizenNode Prev { get; set; }

    public CitizenNode(Citizen citizen)
    {
      Data = citizen;
      Next = null;
      Prev = null;
    }
  }
}
