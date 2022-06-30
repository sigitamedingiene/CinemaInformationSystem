using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemBusiness.Services
{
    public class UpdateDataBase
    {
        CinemaDbContext cinemaDbContext = new CinemaDbContext();
        public void UpdateMovieId(Auditorium auditorium)
        {
            cinemaDbContext.Auditoriums.Update(auditorium);
            cinemaDbContext.SaveChanges();
        }
    }
}
