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
        public Auditorium GetAuditoriumById(Guid Id)
        {
            return _context.Auditoriums.Find(Id);
        }
        public Movie GetMovieById(Guid Id)
        {
            return _context.Movies.Find(Id);
        }
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
