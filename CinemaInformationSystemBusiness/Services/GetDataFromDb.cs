using System.Collections.Generic;
using System.Linq;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;


namespace CinemaInformationSystemBusiness.Services
{
    public class GetDataFromDb
    {   
        CinemaDbContext cinemaDbContext = new CinemaDbContext();
        public List<Auditorium> GetAllAuditoriumAdressListByCity(string City)
        {
            return cinemaDbContext.Auditoriums.Where(auditoriums => auditoriums.City == City).ToList();
        }
        public List<Movie> GetAllMovies()
        {
            return cinemaDbContext.Movies.ToList();
        }
        public List<Auditorium> GetAllAuditorium()
        {
            return cinemaDbContext.Auditoriums.ToList();
        }
    }
}
