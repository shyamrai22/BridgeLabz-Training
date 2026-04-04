using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.cinema_time
{
    class CinemaTimeMenu
    {
        private ICinemaTime cinemaTimeService;
        public void Start()
        {
            cinemaTimeService = new CinemaTimeUtilityImpl();
            Console.WriteLine("Welcome to Cinema Time, Your very own movies management app");
            Console.WriteLine("===========================================================");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Add a movie");
                Console.WriteLine("2. Search for a movie by name");
                Console.WriteLine("3. Display movies");
                Console.WriteLine("0. Exit application");
                Console.Write("Enter your choice --> ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        exit = true;
                        Console.WriteLine("Exiting the app.....");
                        break;
                    case 1:
                        Console.Write("Enter movie name --> ");
                        string movie = Console.ReadLine();
                        Console.Write("Enter duration in min --> ");
                        string duration = Console.ReadLine();
                        cinemaTimeService.AddMovie(movie, duration);
                        break;

                    case 2:
                        Console.Write("Enter movie name --> ");
                        string movieName = Console.ReadLine();
                        Console.WriteLine("Matched results");
                        cinemaTimeService.SearchMovie(movieName);
                        break;

                    case 3:
                        Console.WriteLine("All movies in library");
                        cinemaTimeService.DisplayMovie();
                        break;

                    default:
                        Console.WriteLine("Invalid choice, try again");
                        break;
                }
            }
        }
    }
}
