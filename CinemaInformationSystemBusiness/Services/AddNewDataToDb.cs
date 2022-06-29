using System;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemBusiness.Services
{
    public class AddNewDataToDb
    {   
        CinemaDbContext cinemaDbContext = new CinemaDbContext();
        public void AddNewAuditorium(int number, string owner, string city, string adress, int placeCount, int rowsCount, int rowSeatCount, Movie movie, Client client)
        {
            Auditorium newAuditorium = new(number, owner, city, adress, placeCount, rowsCount, rowSeatCount);
            newAuditorium.ShowedMovies.Add(movie);
            newAuditorium.Clients.Add(client);
            cinemaDbContext.Add(newAuditorium);
            cinemaDbContext.SaveChanges();
        }
        public void AddNewClient(string name, string surName, decimal age, string email, Movie movie)
        {
            Client newClient = new(name, surName, age, email);
            newClient.WachedMovies.Add(movie);
            cinemaDbContext.Clients.Add(newClient);
            cinemaDbContext.SaveChanges();
        }
        public void AddNewMovie(Guid id, string name, string type, string companyCreated, string showdate, string showTime)
        {
            Movie newMovie = new(id, name, type, companyCreated, showdate, showTime);
            cinemaDbContext.Add(newMovie);
            cinemaDbContext.SaveChanges();
        }
    }
}
