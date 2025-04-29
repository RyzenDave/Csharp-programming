using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating, double ticketprice)
        {
            Title = title;
            Genre = genre;

            if (rating > 0 && rating <= 5)
            {
                Rating = rating;
                TicketPrice = rating * 5;
            }
            else
            {
                throw new Exception("Rating must have value between 1 and 5");
            }
            
        }
    }
}
