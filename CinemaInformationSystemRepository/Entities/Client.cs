using System;
using System.Collections.Generic;


namespace CinemaInformationSystemRepository.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public decimal Age { get; set; }
        public string Email { get; set; }
        public List<Movie> WachedMovies { get; set; }

        public Client(string name, string surName, decimal age, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            SurName = surName;
            Age = age;
            Email = email;
            WachedMovies = new List<Movie>();
        }
    }
}
