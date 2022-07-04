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
        public List<Auditorium> GetAuditoriumData(string city, string adress, int number)
        {
            return _context.Auditoriums.Where(auditoriums => auditoriums.City == city && auditoriums.Adress == adress && auditoriums.Number == number).ToList();
        }
        public List<Auditorium> GetAllAuditorium()
        {
            return _context.Auditoriums.ToList();
        }
        public List<Auditorium> GetAllAuditoriumByMovie(Guid selectedMovieId)
        {
            var auditoriumList = _context.Movies
                .FirstOrDefault(movie => movie.Id == selectedMovieId).Auditorium
                .ToList();
            return auditoriumList;
        }
        public List<Auditorium> GetAuditoriumById(Guid auditoriumId)
        {
            return _context.Auditoriums.Where(auditoriums => auditoriums.Id == auditoriumId).ToList();
        }
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
