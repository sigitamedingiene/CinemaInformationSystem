using System;
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
            Movie movie = new("Aladin", "Animation", "Walt Disney", "2022-07-01", "11:00");
            DbData dbData = new(cinemaDbContext, movie);
            InitializeComponent();
            dbData.AddDbMovieData();
            dbData.AddDbClientData();
            dbData.AddDbAuditoriumData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = MovieNameTextBox.Text;
            string type = MovieTypeTextBox.Text;
            string company = MovieCompanyTextBox.Text;
            var date = DatePickerBox.Value.Date.ToShortDateString();
            var time = TimePickerBox.Value.ToShortTimeString();
            Movie movie = new Movie(name, type, company, date, time);
            cinemaDbContext.Add(movie);
            cinemaDbContext.SaveChanges();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
