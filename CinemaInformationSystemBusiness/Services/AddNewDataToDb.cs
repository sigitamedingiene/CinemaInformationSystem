using System;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemBusiness.Services
{
    public class AddNewDataToDb
    {   public Movie _movie;
        public Auditorium _auditorium;
        public AddNewDataToDb(Movie movie, Auditorium auditorium)
        {
            _movie = movie;
            _auditorium = auditorium;
        }
        CinemaDbContext cinemaDbContext = new CinemaDbContext();
        public void AddNewAuditorium(int number, string owner, string city, string adress, int placeCount, int rowsCount, int rowSeatCount, Guid movieId)
        {
            Auditorium newAuditorium = new(number, owner, city, adress, placeCount, rowsCount, rowSeatCount);
            movieId = _movie.Id;
            cinemaDbContext.Auditoriums.Add(newAuditorium);
            cinemaDbContext.Add(movieId);
            cinemaDbContext.SaveChanges();
        }
        public void AddNewClient(string name, string surName, decimal age, string email, Guid auditoriumId)
        {
            Client newClient = new(name, surName, age, email);
            auditoriumId = _auditorium.Id;
            cinemaDbContext.Clients.Add(newClient);
            cinemaDbContext.Add(auditoriumId);
            cinemaDbContext.SaveChanges();
        }
    }
}
