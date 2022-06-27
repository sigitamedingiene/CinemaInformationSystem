﻿using System;
using System.Windows.Forms;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class MainForm : Form
    {
        CinemaDbContext cinemaDbContext = new();
        

        public MainForm()
        {
            InitializeComponent();
            var Id = Guid.NewGuid();            
            DbData dbData = new(cinemaDbContext);
            dbData.AddDbMovieData();
            dbData.AddDbClientData();
            dbData.AddDbAuditoriumData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Id = Guid.NewGuid();
            string name = MovieNameTextBox.Text;
            string type = MovieTypeTextBox.Text;
            string company = MovieCompanyTextBox.Text;
            var date = DatePickerBox.Value.Date.ToShortDateString();
            var time = TimePickerBox.Value.ToShortTimeString();
            Movie movie = new Movie(Id, name, type, company, date, time);
            cinemaDbContext.Add(movie);
            cinemaDbContext.SaveChanges();
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
