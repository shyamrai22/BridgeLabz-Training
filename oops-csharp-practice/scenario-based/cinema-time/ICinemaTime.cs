using System;

namespace BridgeLabzTraining.oops_csharp_buddy.scenario_based.cinema_time
{
    interface ICinemaTime
    {
        void AddMovie(string title, string duration);

        void SearchMovie(string keyword);

        void DisplayMovie();
    }
}
