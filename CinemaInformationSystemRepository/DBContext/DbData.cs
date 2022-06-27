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
            Movie movie = new Movie(Id, "Cinderella", "Animation", "Walt Disney", "2022-06-30", "15:00");
            _cinemaDbContext.Add(movie);
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbClientData()
        {
            Client client = new Client("Sigita", "Medingiene", 34, "sigita@gmail.com");
            _cinemaDbContext.Add(client);
            _cinemaDbContext.SaveChanges();
        }
        public void AddDbAuditoriumData()
        {
            Auditorium auditorium1 = new Auditorium(1, "Forum Cinema", "Klaipeda", "Taikos pr. 64", 250, 10, 25);
            Auditorium auditorium2 = new Auditorium(2, "Forum Cinema", "Klaipeda", "Taikos pr. 64", 200, 10, 20);
            Auditorium auditorium3 = new Auditorium(3, "Forum Cinema", "Klaipeda", "Taikos pr. 64", 150, 10, 15);
            _cinemaDbContext.Add(auditorium1);
            _cinemaDbContext.Add(auditorium2);
            _cinemaDbContext.Add(auditorium3);
            _cinemaDbContext.SaveChanges();
        }
    }
}
