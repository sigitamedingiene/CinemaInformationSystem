using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CinemaInformationSystemBusiness.Services;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class SellTicketForm : Form
    {   
        private GetDataFromDb _getDataFromDb;
        private AddNewDataToDb _addNewDataToDb;
        private SellTicket _sellTicket;
        public SellTicketForm(GetDataFromDb getDataFromDb, AddNewDataToDb addNewDataToDb, SellTicket sellTicket)
        {
            _getDataFromDb = getDataFromDb;
            _addNewDataToDb = addNewDataToDb;
            _sellTicket = sellTicket;
            InitializeComponent();
            AddAllMovesToList();
            AddAllAuditoriumToList();
            AddNumberToList();
            AddpriceToList();
        }
        private void AddAllMovesToList()
        {
            List<Movie> movies = _getDataFromDb.GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                ChooseMovieComboBox.Items.Add($"{movies[i].Name}, rodo {movies[i].ShowDate}, {movies[i].ShowTime}, {movies[i].Id}");
            }
        }
        private void AddAllAuditoriumToList()
        {
            List<Auditorium> auditorium = _getDataFromDb.GetAllAuditorium();
            for (int i = 0; i < auditorium.Count; i++)
            {
                ChooseAuditoriumComboBox.Items.Add($"{auditorium[i].City}, {auditorium[i].Adress}, {auditorium[i].Number}, {auditorium[i].Id}");
            }
        }
        private void AddNumberToList()
        {
            for (int i = 1; i < 51; i++)
            {
                TicketCountComboBox.Items.Add(i);
            }
        }
        private void AddpriceToList()
        {
            List<decimal> priceList = new();
            priceList.Add(4.99m);
            priceList.Add(8.99m);
            priceList.Add(12.99m);
            for (int i = 0; i < priceList.Count; i++)
            {
                PriceComboBox.Items.Add(priceList[i]);
            }
        }
        private void DrawCinemaSeats(Graphics g, int rowSeatsCount, int rowsCount)
        {
            bool[,] seats = new bool[rowSeatsCount, rowsCount];
            const int size = 18;
            const int space = 3;
            Brush brush;
            for (int j = 0; j < seats.GetLength(1); j++)
            {
                for (int i = 0; i < seats.GetLength(0); i++)
                {
                    if (seats[i, j])
                        brush = Brushes.Red;
                    else
                        brush = Brushes.Green;
                    g.FillRectangle(brush, i * (size + space), j * (size + space), size, size);
                }
            }
        }
        private void ChoosePlacesButton_Click(object sender, EventArgs e)
        {           
            int row = Convert.ToInt32(RowCountTextBox.Text);
            int seatsInRow = Convert.ToInt32(RowSeatsCountTextBox.Text);
            DrawCinemaSeats(CinemaSeatsPictureBox.CreateGraphics(), row, seatsInRow);
        }
        private void ChooseMovieNextButton_Click(object sender, EventArgs e)
        {
            MovieInformationTextBox.AppendText($"{ChooseMovieComboBox.Text}\r\n");
            MovieInformationTextBox.AppendText(ChooseAuditoriumComboBox.Text);
            var price = _sellTicket.CountPrice(Convert.ToDecimal(PriceComboBox.Text), Convert.ToDecimal(TicketCountComboBox.Text));
            MovieInformationTextBox.AppendText($"\r\nTotal price: {price}");
            Guid auditoriumId = Guid.Parse(auditoriumIdBox.Text);
            List<Auditorium> auditoriums = _getDataFromDb.GetAuditoriumById(auditoriumId);
            for (int j = 0; j < auditoriums.Count; j++)
            {
                RowCountTextBox.AppendText(auditoriums[j].RowsCount.ToString());
                RowSeatsCountTextBox.AppendText(auditoriums[j].RowSeatCount.ToString());
            }
        }
        private void ChooseAuditoriumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string auditoriumComboBox = ChooseAuditoriumComboBox.Text;
            string[] auditoriumArray = auditoriumComboBox.Split(", ");
            for (int i = 0; i < auditoriumArray.Length; i++)
            {
                auditoriumIdBox.Text = auditoriumArray[3];
            }
        }
        private void ChooseMovieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movieComboBox = ChooseMovieComboBox.Text;
            string[] movieArray = movieComboBox.Split(", ");
            for (int i = 0; i < movieArray.Length; i++)
            {
                MovieIdTextBox.Text = movieArray[3];
            }
        }
        private void AddNewClient_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            var age = AgeTextBox.Text;
            string email = EmailTextBox.Text;
            Guid movieId = Guid.Parse(MovieIdTextBox.Text);
            var movie = _getDataFromDb.GetMovieById(movieId);
            _addNewDataToDb.AddNewClient(name, surname, Convert.ToDecimal(age), email, movie);
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            AgeTextBox.Clear();
            EmailTextBox.Clear();
            MessageBox.Show("New Client added successfully");
        }

        
    }
}
