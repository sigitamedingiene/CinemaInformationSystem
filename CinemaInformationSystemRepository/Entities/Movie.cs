using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaInformationSystemRepository.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string CompanyCreated { get; set; }
        public DateTime ShowTime { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
        public List<Client> Clients { get; set; }
        public Movie(string name, string type, string companyCreated, DateTime showTime)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            CompanyCreated = companyCreated;
            ShowTime = showTime;
            Clients = new List<Client>();

        }
    }
}
