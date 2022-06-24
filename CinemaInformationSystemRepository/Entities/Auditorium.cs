using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaInformationSystemRepository.Entities
{
    public class Auditorium
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Owner { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PlaceCount { get; set; }
        public Guid MovieId { get; set; }
        public Movie Movie { get; set; }
        public List<Movie> ShowedMovies { get; set; }

        public Auditorium(int number, string owner, string city, string adress, int placeCount)
        {
            Id = Guid.NewGuid();
            Number = number;
            Owner = owner;
            City = city;
            Adress = adress;
            PlaceCount = placeCount;
            ShowedMovies = new List<Movie>();
        }
    }
}