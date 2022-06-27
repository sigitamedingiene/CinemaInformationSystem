﻿using System;
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
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public List<Client> Clients { get; set; }
        public Movie(string name, string type, string companyCreated, string showdate, string showTime)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            CompanyCreated = companyCreated;
            ShowDate = showdate;
            ShowTime = showTime;
            Clients = new List<Client>();            
        }
    }
}
