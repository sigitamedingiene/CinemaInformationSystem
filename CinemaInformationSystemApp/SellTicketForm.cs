using System;
using System.Drawing;
using System.Windows.Forms;
using CinemaInformationSystemBusiness.Services;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class SellTicketForm : Form
    {
        public SellTicketForm()
        {
            InitializeComponent();
        }
        CinemaDbContext cinemaDbContext = new();

        private void ChoosePlacesButton_Click(object sender, EventArgs e)
        {
            /*void DrawCinemaSeats(Graphics g)
        {
            bool[,] seats = new bool[, auditorium.RowsCount];
            const int size = 16;
            const int space = 2;
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
        }*/
    }
    }
}
