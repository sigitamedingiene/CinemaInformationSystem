using System;
using System.Collections.Generic;


namespace CinemaInformationSystemRepository.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CompanyCreated { get; set; }
        public string ShowDate { get; set; }
        public string ShowTime { get; set; }
        public Movie(Guid id, string name, string type, string companyCreated, string showdate, string showTime)
        {
            Id = id;
            Name = name;
            Type = type;
            CompanyCreated = companyCreated;
            ShowDate = showdate;
            ShowTime = showTime;           
        }
        private Movie()
        {

        }
    }
}
