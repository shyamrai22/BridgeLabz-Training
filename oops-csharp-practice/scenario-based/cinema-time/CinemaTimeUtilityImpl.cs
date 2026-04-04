using BridgeLabzTraining.oops_csharp_buddy.scenario_based.book_buddy;
using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.cinema_time
{
    class CinemaTimeUtilityImpl : ICinemaTime
    {
        string[] movies = {
                            "The Shawshank Redemption - 142",
                            "The Godfather - 175",
                            "The Dark Knight - 152",
                            "Inception - 148",
                            "Fight Club - 139",
                            "Forrest Gump - 142",
                            "Interstellar - 169",
                            "The Matrix - 136",
                            "Gladiator - 155",
                            "","","","","",""
                         };

        private int movieIndex = 9;

        public void AddMovie(string title, string duration)
        {
            if (movieIndex >= movies.Length)
            {
                Console.WriteLine("Library is already full");
                return;
            }
            movies[movieIndex++] = $"{title.Trim()} - {duration.Trim()}";
        }

        public void SearchMovie(string keyword)
        {
            for (int i = 0; i < movieIndex; i++)
            {
                string movie = movies[i];
                string[] parts = movie.Split('-');

                if (parts.Length < 2)
                {
                    continue;
                }

                string title = parts[0].Trim();

                if (title.ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(movie);
                }
            }
        }

        public void DisplayMovie()
        {
            for (int i = 0; i < movieIndex; i++)
            {
                Console.WriteLine(movies[i]);
            }
        }

    }
}
