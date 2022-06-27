using System;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemRepository.DBContext
{
    public class DbData
    { 
        private readonly CinemaDbContext _cinemaDbContext;
        private readonly Movie _movie;
        public DbData (CinemaDbContext cinemaDbContext, Movie movie)
        {
            cinemaDbContext = _cinemaDbContext;
            movie = _movie;
        }
        public void AddDbMovieData()
        {
            Movie movie = new Movie("Cinderella", "Animation", "Walt Disney", "2022-06-30", "15:00");
            var Id = Guid.NewGuid();
            _cinemaDbContext.Add(movie);
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbClientData()
        {
            Client client = new Client("Sigita", "Medingiene", 34, "sigita@gmail.com", _movie.Id);
            _cinemaDbContext.Add(client);
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbAuditoriumData()
        {
            Auditorium auditorium = new Auditorium(1, "Forum Cinema", "Klaipeda", "Taikos pr. 64", 250);
            _cinemaDbContext.Add(auditorium);
            _cinemaDbContext.SaveChanges();
        }
    }
}
