using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemBusiness.Services
{
    public class AddNewDataToDb
    {   
        private CinemaDbContext _context;
 
        public AddNewDataToDb(CinemaDbContext context)
        {
            _context = context;
        }
        public void AddNewAuditorium(int number, string owner, string city, string adress, int placeCount, int rowsCount, int rowSeatCount)
        {
            Auditorium newAuditorium = new(number, owner, city, adress, placeCount, rowsCount, rowSeatCount);
            _context.Add(newAuditorium);           
            _context.SaveChanges();
        }
        public void AddNewClient(string name, string surName, decimal age, string email, Movie movie, Auditorium auditorium)
        {
            Client newClient = new(name, surName, age, email);
            _context.Clients.Add(newClient);
            newClient.WachedMovies.Add(movie);
            newClient.UsedAuditoriums.Add(auditorium);
            _context.SaveChanges();
        }
        public void AddNewMovie(string name, string type, string companyCreated, string showdate, string showTime, Auditorium auditorium)
        {
            Movie newMovie = new(name, type, companyCreated, showdate, showTime);
            newMovie.Auditorium.Add(auditorium);
           // Client newClient = new Client(_client.Name, _client.SurName, _client.Age, _client.Email);
           // newMovie.Clients.Add(newClient);
            _context.Add(newMovie);
            _context.SaveChanges();
        }
    }
}
