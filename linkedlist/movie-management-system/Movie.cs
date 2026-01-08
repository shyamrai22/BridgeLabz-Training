using System;

namespace BridgeLabzTraining.dsa_csharp_practice.movie_management_system
{
    class Movie
    {
        private string title;
        private string director;
        private int year;
        private double rating;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public Movie(string title, string director, int year, double rating)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Title: {Title}, Director: {Director}, Year: {Year}, Rating: {Rating}"
            );
        }
    }
}
