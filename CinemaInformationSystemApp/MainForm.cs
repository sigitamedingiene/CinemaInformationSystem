using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaInformationSystemBusiness.Services;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class MainForm : Form
    {   AddNewDataToDb addNewDataToDb = new AddNewDataToDb();
        GetDataFromDbToList getDataFromDbToList = new GetDataFromDbToList();

        public MainForm()
        {
            InitializeComponent();
        }
        private void AddNewMovieButton_Click(object sender, EventArgs e)
        {
            var Id = Guid.NewGuid();
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
        {   List<Auditorium> auditoriumAdresses = new List<Auditorium>();
            string cityName = CityNameTextBox.Text;
            auditoriumAdresses = getDataFromDbToList.GetAllAuditoriumAdressListByCity(cityName);
            if (CityNameTextBox.Text == cityName)
            {
                for (int i = 0; i < auditoriumAdresses.Count; i++)
                {
                    AuditoriumAdressComboBox.Items.Add(auditoriumAdresses[i].Adress);
                    AuditoriumIdTextBox.AppendText($"{auditoriumAdresses[i].Id}");
                }
            }else
            {
                MessageBox.Show("Add new auditorium data.");
            }
            
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
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
