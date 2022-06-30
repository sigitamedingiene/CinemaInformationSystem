﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CinemaInformationSystemBusiness.Services;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class SellTicketForm : Form
    {   
        GetDataFromDb getDataFromDb = new();
        SellTicket sellTicket = new();
        public SellTicketForm()
        {
            InitializeComponent();
            AddAllMovesToList();
            AddAllAuditoriumToList();
        }
        private void AddAllMovesToList()
        {
            List<Movie> movies = getDataFromDb.GetAllMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                ChooseMovieComboBox.Items.Add($"{movies[i].Name}, rodo {movies[i].ShowDate}, {movies[i].ShowTime}");
            }
        }
        private void AddAllAuditoriumToList()
        {
            List<Auditorium> auditorium = getDataFromDb.GetAllAuditorium();
            for (int i = 0; i < auditorium.Count; i++)
            {
                ChooseAuditoriumComboBox.Items.Add($"{auditorium[i].City}, rodo {auditorium[i].Adress}, {auditorium[i].Number}");
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
            DrawCinemaSeats(CinemaSeatsPictureBox.CreateGraphics(), 10, 25);
        }
        private void ChooseMovieNextButton_Click(object sender, EventArgs e)
        {
            MovieInformationTextBox.AppendText(ChooseMovieComboBox.Text);
            MovieInformationTextBox.AppendText(ChooseAuditoriumComboBox.Text);
            var price = sellTicket.CountPrice(Convert.ToDecimal(PriceComboBox.Text), Convert.ToDecimal(TicketCountComboBox.Text));
            MovieInformationTextBox.AppendText($"Total price: {price}");
        }
    }
}
