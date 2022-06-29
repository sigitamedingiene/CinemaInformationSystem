using System;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemRepository.DBContext
{
    public class DbData
    { 
        private readonly CinemaDbContext _cinemaDbContext;
        public DbData (CinemaDbContext cinemaDbContext)
        {
            _cinemaDbContext = cinemaDbContext; 
        }
        public void AddDbMovieData()
        {
            var Id = Guid.NewGuid();
            Movie movie = new Movie("Aladin", "Animation", "Walt Disney", "2022-07-01", "14:20");
            _cinemaDbContext.Add(movie);
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbClientData()
        {
            Client client = new Client("Sigita", "Medingiene", 28, "sigita@gmail.com");
            _cinemaDbContext.Add(client);           
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbAuditoriumData()
        {   
            Auditorium auditorium1 = new Auditorium(2, "Forum Cinema", "Klaipeda", "Taikos pr. 64", 150, 10, 15);
            _cinemaDbContext.Add(auditorium1);          
            _cinemaDbContext.SaveChanges();
        }
    }
}
