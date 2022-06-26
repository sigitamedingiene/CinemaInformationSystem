using System;
using System.Windows.Forms;
using CinemaInformationSystemRepository.DBContext;
using CinemaInformationSystemRepository.Entities;

namespace CinemaInformationSystemApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           /* CinemaDbContext cinemaDbContext = new CinemaDbContext();
            Movie movie = new Movie("Cinderella", "Animation", "Walt Disney", DateTime.Today);
            cinemaDbContext.Add(movie);
            cinemaDbContext.SaveChanges();*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
