using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaInformationSystemBusiness.Services;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class MainForm : Form
    {
        CinemaDbContext cinemaDbContext = new CinemaDbContext();
        AddNewDataToDb addNewDataToDb = new AddNewDataToDb();
        GetDataFromDb getDataFromDb = new GetDataFromDb();
        UpdateDataBase update = new UpdateDataBase();
        public MainForm()
        {
            InitializeComponent();
            AddAllMovesToList();
        }
        private void AddAllMovesToList()
        {
            List<Movie> movies = getDataFromDb.GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                AllMovieListComboBox.Items.Add($"{movies[i].Name}, rodo {movies[i].ShowDate}, {movies[i].ShowTime}");
            }
        }
        private void AddNewMovieButton_Click(object sender, EventArgs e)
        {
            string name = MovieNameTextBox.Text;
            string type = MovieTypeTextBox.Text;
            string company = MovieCompanyTextBox.Text;
            var date = DatePickerBox.Value.Date.ToShortDateString();
            var time = TimePickerBox.Value.ToShortTimeString();
            addNewDataToDb.AddNewMovie(name, type, company, date, time);
            MovieNameTextBox.Clear();
            MovieTypeTextBox.Clear();
            MovieCompanyTextBox.Clear();
            MessageBox.Show("Movie added succesfully");
        }
        private void SearchAuditoriumAdressButton_Click(object sender, EventArgs e)
        {
            _ = new List<Auditorium>();
            string cityName = CityNameTextBox.Text;
            List<Auditorium> auditoriumAdresses = getDataFromDb.GetAllAuditoriumAdressListByCity(cityName);
            for (int i = 0; i < auditoriumAdresses.Count; i++)
            {
                AuditoriumAdressComboBox.Items.Add($"{auditoriumAdresses[i].Adress}, auditorium number {auditoriumAdresses[i].Number}");
            }
        }
        private void AllMovieListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Movie> movies = getDataFromDb.GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                NewMovieIdTextBox.Text = movies[i].Id.ToString();
            }
        }
        private void AddNewMovieIdToAuditoriumDataBaseButton_Click(object sender, EventArgs e)
        {
            var movieId = NewMovieIdTextBox.Text;//nezinau kaip padaryti, kad is listo butu nuskaityta ir apdeitinta DB
        }
        private void AddNewAuditorium_Click(object sender, EventArgs e)
        {
            var Id = Guid.NewGuid();
            int number = Convert.ToInt32(AuditoriumNumberBox.Text);
            string owner = AuditoriumOwnerTextBox.Text;
            string city = CityTextBox.Text;
            string adress = AuditoriumAdressTextBox.Text;
            int placeCount = Convert.ToInt32(AuditoriumPlaceCountTextBox.Text);
            int rowsCount = Convert.ToInt32(AuditoriumRowsCountTextBox.Text);
            int rowSeatCount = Convert.ToInt32(AuditoriumSeatsInRowCountTextBox.Text);
            addNewDataToDb.AddNewAuditorium(number, owner, city, adress, placeCount, rowsCount, rowSeatCount);

        }
        private void SellTicketButton_Click(object sender, EventArgs e)
        {
            SellTicketForm sellTicketForm = new();
            sellTicketForm.ShowDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ataskaitu generavimas
        }
    }
}
