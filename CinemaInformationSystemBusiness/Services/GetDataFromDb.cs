using System;
using System.Collections.Generic;
using System.Linq;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;


namespace CinemaInformationSystemBusiness.Services
{
    public class GetDataFromDb
    {   
        private CinemaDbContext _context;
        public GetDataFromDb(CinemaDbContext context)
        {
            _context = context;
        }        
        public List<Auditorium> GetAllAuditoriumAdressListByCity(string City)
        {
            return _context.Auditoriums.Where(auditoriums => auditoriums.City == City).ToList();
        }
        public List<Auditorium> GetAuditoriumIdByAdressAndNumber(string adress, int number)
        {
            return _context.Auditoriums.Where(auditoriums => auditoriums.Adress == adress && auditoriums.Number == number).ToList();
        }
        public List<Auditorium> GetAllAuditorium()
        {
            return _context.Auditoriums.ToList();
        }
        public List<Auditorium> GetAllAuditoriumByMovie(Guid movieId)
        {
            var auditoriumList = _context.Movies
                .FirstOrDefault(movie => movie.Id == movieId).Auditorium
                .ToList();
            return auditoriumList;
        }
        public List<Auditorium> GetAllAuditoriumByClient(Guid clientId)
        {
            var auditoriumsList = _context.Clients
                .FirstOrDefault(client => client.Id == clientId).UsedAuditoriums
                .ToList();
            return auditoriumsList;
        }
        public List<Auditorium> GetAuditoriumById(Guid auditoriumId)
        {
            return _context.Auditoriums.Where(auditoriums => auditoriums.Id == auditoriumId).ToList();
        }
        public Auditorium GetAuditoriumByID (Guid Id)
        {
            var auditorium = _context.Auditoriums
                .FirstOrDefault(auditorium => auditorium.Id == Id);
            return auditorium;
        }
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
        public Movie GetMovieById(Guid movieId)
        {
            var movie = _context.Movies
                .FirstOrDefault(movie => movie.Id == movieId);
            return movie;
        }
        public List<Client> AllClientsList()
        {
            return _context.Clients.ToList();
        }
    }
}
