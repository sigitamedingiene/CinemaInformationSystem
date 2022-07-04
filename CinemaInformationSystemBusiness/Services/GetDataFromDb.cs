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
        public List<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }
        public List<Auditorium> GetAllAuditorium()
        {
            return _context.Auditoriums.ToList();
        }
    }
}
