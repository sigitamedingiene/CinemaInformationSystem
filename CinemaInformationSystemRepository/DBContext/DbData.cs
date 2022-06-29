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
            Movie movie = new Movie("Cinderella", "Animation", "Walt Disney", "2022-06-30", "16:00");
            _cinemaDbContext.Add(movie);
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbClientData()
        {
            Client client = new Client("Sigita", "Vardene", 17, "vardene@gmail.com");
            _cinemaDbContext.Add(client);           
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbAuditoriumData()
        {   
            Auditorium auditorium1 = new Auditorium(1, "Forum Cinema", "Klaipeda", "Taikos pr. 64", 250, 10, 25);
            _cinemaDbContext.Add(auditorium1);          
            _cinemaDbContext.SaveChanges();
        }
    }
}
