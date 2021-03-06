using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CinemaInformationSystemBusiness.Services;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class MainForm : Form
    {   public static CinemaDbContext _context = new CinemaDbContext();
        public static AddNewDataToDb _addNewDataToDb = new(_context);
        public static GetDataFromDb _getDataFromDb = new(_context);
        public static SellTicket _sellTicket = new SellTicket();
        public static SellTicketForm _sellTicketForm = new(_getDataFromDb, _addNewDataToDb, _sellTicket);
        public MainForm()
        {
            InitializeComponent();
            AddAllMovesToList();
            AddAllAuditoriumToList();
        }
        private void AddAllMovesToList()
        {
            List<Movie> movies = _getDataFromDb.GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                AllMovieListComboBox.Items.Add($"{movies[i].Name}, rodo: {movies[i].ShowDate}, {movies[i].ShowTime}, {movies[i].Id}");
            }
        }
        private void AddAllAuditoriumToList()
        {
            List<Auditorium> auditorium = _getDataFromDb.GetAllAuditorium();
            for (int i = 0; i < auditorium.Count; i++)
            {
                AuditoriumListComboBox.Items.Add($"{auditorium[i].City}, {auditorium[i].Adress}, {auditorium[i].Number}, {auditorium[i].Id}");
            }
        }
        private void AddNewAuditorium_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(AuditoriumNumberBox.Text);
            string owner = AuditoriumOwnerTextBox.Text;
            string city = CityTextBox.Text;
            string adress = AuditoriumAdressTextBox.Text;
            int placeCount = Convert.ToInt32(AuditoriumPlaceCountTextBox.Text);
            int rowsCount = Convert.ToInt32(AuditoriumRowsCountTextBox.Text);
            int rowSeatCount = Convert.ToInt32(AuditoriumSeatsInRowCountTextBox.Text);
            _addNewDataToDb.AddNewAuditorium(number, owner, city, adress, placeCount, rowsCount, rowSeatCount);
            AuditoriumNumberBox.Clear();
            AuditoriumOwnerTextBox.Clear();
            CityTextBox.Clear();
            AuditoriumAdressTextBox.Clear();
            AuditoriumPlaceCountTextBox.Clear();
            AuditoriumRowsCountTextBox.Clear();
            AuditoriumSeatsInRowCountTextBox.Clear();
            MessageBox.Show("Auditorium added succesfully");
            AddAllAuditoriumToList();
        }
        private void AddNewMovieButton_Click(object sender, EventArgs e)
        {
            string name = MovieNameTextBox.Text;
            string type = MovieTypeTextBox.Text;
            string company = MovieCompanyTextBox.Text;
            var date = DatePickerBox.Value.Date.ToShortDateString();
            var time = TimePickerBox.Value.ToShortTimeString();
            string auditoriumComboBox = AuditoriumListComboBox.Text;
            string[] auditoriumArray = auditoriumComboBox.Split(", ");
            for (int i = 0; i < auditoriumArray.Length; i++)
            {
                AuditoriumIdBox.Text = auditoriumArray[3];
            }
            Guid auditoriumId = Guid.Parse(AuditoriumIdBox.Text);
            var auditorium = _getDataFromDb.GetAuditoriumByID(auditoriumId);
            _addNewDataToDb.AddNewMovie(name, type, company, date, time, auditorium);
            MovieNameTextBox.Clear();
            MovieTypeTextBox.Clear();
            MovieCompanyTextBox.Clear();
            MessageBox.Show("Movie added succesfully");
        }
        private void SearchAuditoriumAdressButton_Click(object sender, EventArgs e)
        {
            _ = new List<Auditorium>();
            string cityName = CityNameTextBox.Text;
            List<Auditorium> auditoriumAdresses = _getDataFromDb.GetAllAuditoriumAdressListByCity(cityName);
            for (int i = 0; i < auditoriumAdresses.Count; i++)
            {
                AuditoriumAdressComboBox.Items.Add($"{auditoriumAdresses[i].Adress}, {auditoriumAdresses[i].Number}");
            }
        }
        private void AuditoriumAdressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string auditoriumInfo = AuditoriumAdressComboBox.Text;
            string[] adressNumberArray = auditoriumInfo.Split(", ");
            for (int i = 0; i < adressNumberArray.Length; i++)
            {
                List<Auditorium> auditoriums = _getDataFromDb.GetAuditoriumIdByAdressAndNumber(adressNumberArray[0], Convert.ToInt32(adressNumberArray[1])).ToList();
                for (int j = 0; j < auditoriums.Count; j++)
                {
                    AuditoriumIDTextBox.Text = auditoriums[j].Id.ToString();
                }
            }
        }
        private void AllMovieListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Movie> movies = _getDataFromDb.GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                NewMovieIdTextBox.Text = movies[i].Id.ToString();
            }
        }
        private void AddNewMovieIdToAuditoriumDataBaseButton_Click(object sender, EventArgs e)
        {
            var movieId = Guid.Parse(NewMovieIdTextBox.Text);
            var auditoriumId = Guid.Parse(AuditoriumIDTextBox.Text);
            var movie = _context.Movies.Find(auditoriumId);
            movie.Id = movieId;
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }
        private void SellTicketButton_Click(object sender, EventArgs e)
        {
            _sellTicketForm.ShowDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
                if (NewMovieIdTextBox.Text == "")
                {
                    MessageBox.Show("Please choose movie, from Movie List");
                }
                else
                {
                    var movieId = Guid.Parse(NewMovieIdTextBox.Text);
                    List <Auditorium> auditoriumListByMovie = _getDataFromDb.GetAllAuditoriumByMovie(movieId).ToList();
                    for (int i = 0; i < auditoriumListByMovie.Count; i++)
                    {
                        ReportBox.Text = ($"City: {auditoriumListByMovie[i].City}, adress: {auditoriumListByMovie[i].Adress}, auditorium number: {auditoriumListByMovie[i].Number}, capacity: {auditoriumListByMovie[i].PlaceCount} seats.");
                    }
                }
            }
            else if (checkBox2.Checked)
            {
                List<Client> allClients = _getDataFromDb.AllClientsList();
                for (int i = 0; i < allClients.Count; i++)
                {
                    List<Auditorium> auditoriumListByClient = _getDataFromDb.GetAllAuditoriumByClient(allClients[i].Id);
                    for (int j = 0; j < auditoriumListByClient.Count; j++)
                    {
                        ReportBox.Text = ($"City: {auditoriumListByClient[j].City}, adress: {auditoriumListByClient[j].Adress}, auditorium number: {auditoriumListByClient[i].Number}, capacity: {auditoriumListByClient[i].PlaceCount} seats.\r\n");
                    }
                }
            }else if (checkBox3.Checked)
            {
                List<Client> allClients = _getDataFromDb.AllClientsList();
                for (int i = 0; i < allClients.Count; i++)
                {
                    List<Movie> movieListByClient = _getDataFromDb.GetAllMoviesByClientId(allClients[i].Id);
                    for (int j = 0; j < movieListByClient.Count; j++)
                    {
                        ReportBox.Text = ($"Name: {movieListByClient[j].Name}, type: {movieListByClient[j].Type}, show time: {movieListByClient[i].ShowDate}, {movieListByClient[j].ShowTime}.\r\n");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose report type");
            }
        }
    }
}
