using System;


namespace CinemaInformationSystemRepository.Entities
{
    public class Auditorium
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Owner { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int PlaceCount { get; set; }
        public int RowsCount { get; set; }
        public int RowSeatCount { get; set; }
        public Auditorium(int number, string owner, string city, string adress, int placeCount, int rowsCount, int rowSeatCount)
        {
            Id = Guid.NewGuid();
            Number = number;
            Owner = owner;
            City = city;
            Adress = adress;
            PlaceCount = placeCount;
            RowsCount = rowsCount;
            RowSeatCount = rowSeatCount;
        }
        private Auditorium()
        {

        }
    }
}