

namespace CinemaInformationSystemBusiness.Services
{
    public class SellTicket
    {
        public decimal CountPrice(decimal price, decimal count)
        {
            return price * count;
        }
    }
}
