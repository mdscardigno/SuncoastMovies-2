using System;
using System.Linq;

namespace SuncoastMovies
{
    //class or model
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PrimaryDirector { get; set; }
        public int YearReleased { get; set; }
        public string Genre { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SuncoastMoviesContext();
            // this feels like:
            //
            // var transactionCount = transactions.Count();
            //var dinoCount = dinos.Count();
            var movieCount = context.Movies.Count();
            Console.WriteLine($"There are {movieCount} movies!");
        }
    }
}
