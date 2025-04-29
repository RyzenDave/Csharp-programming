using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{

    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema()
        {
            Halls = new List<int>();
            Movies = new List<Movie>();
        }
        public Cinema(string name)
        {
            Name = name;
            Halls = new List<int>();
            Movies = new List<Movie>();
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}