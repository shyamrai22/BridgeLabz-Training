class Program
{
  static void Main()
  {
    // 1D Array for Citizen IDs
    int[] citizenIds = new int[1000];

    for (int i = 0; i < citizenIds.Length; i++)
    {
      citizenIds[i] = 1000 + i;  // Example IDs
    }

    // 2D Array → 5 Zones × 4 Sectors
    int[,] zoneSectorCounts = new int[5, 4];
    Random random = new Random();

    for (int zone = 0; zone < 5; zone++)
    {
      for (int sector = 0; sector < 4; sector++)
      {
        zoneSectorCounts[zone, sector] = random.Next(50, 201);
        // Random citizen count between 50 and 200
      }
    }

    Console.WriteLine("\nZone and Sector Citizen Counts:");

    for (int zone = 0; zone < 5; zone++)
    {
      Console.WriteLine($"\nZone {zone + 1}:");

      for (int sector = 0; sector < 4; sector++)
      {
        Console.WriteLine($"  Sector {sector + 1}: {zoneSectorCounts[zone, sector]} citizens");
      }
    }

    Array.Sort(citizenIds);
    Console.WriteLine("\nCitizen IDs sorted successfully.");

    int searchId = 1050;
    int index = Array.IndexOf(citizenIds, searchId);
    if (index != -1)
      Console.WriteLine($"Citizen ID {searchId} found at index {index}");
    else
      Console.WriteLine("Citizen ID not found.");

    int[] copiedArray = new int[citizenIds.Length];
    Array.Copy(citizenIds, copiedArray, citizenIds.Length);

    Console.WriteLine("Citizen ID array copied successfully.");

  }
}