using TechVille.Model;

namespace TechVille.Interface
{
  public interface ICitizenManager
  {
    void RegisterCitizen();

    Citizen SearchCitizen(int id);

    void SortCitizenIds();

    void DisplayZones();

    void DisplayCitizen(Citizen citizen);

    void SearchByName(string name);

    void UpdateIncome(int id, double newIncome);

  }
}
