using System.Collections.Generic;
using System.Linq;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace CinemaInformationSystemBusiness.Services
{
    public class GetDataFromDbToList
    {   CinemaDbContext cinemaDbContext = new CinemaDbContext();
        public List<Auditorium> GetAllAuditoriumAdressListByCity(string City)
        {
            return cinemaDbContext.Auditoriums.Where(auditorium => auditorium.Adress == City).ToList();
        }
        
        
    }
}
