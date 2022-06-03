using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using m = Booking.com.Model;

namespace Booking.com.Controllers
{
    public class BookingController
    {
        public List<m.Booking> GetBookings()
        {
            List<m.Booking> bookings = new List<m.Booking>();

            m.Booking booking1 = new m.Booking()
            {
                Photo = "Images/1.jpg",
                Name = "Hotel Arenas Punta Leona",
                Checkin = "19/05/2023",
                Checkout = "24/05/2023",
                Adults = 2,
                Kids = 0,
                Nights = 5,
                BookingTotalCost = 1750
            };

            m.Booking booking2 = new m.Booking()
            {
                Photo = "Images/2.jpg",
                Name = "Hotel Riu Palace Guanacaste",
                Checkin = "19/05/2023",
                Checkout = "24/05/2023",
                Adults = 2,
                Kids = 0,
                Nights = 5,
                BookingTotalCost = 1750
            };

            bookings.Add(booking1);
            bookings.Add(booking2);

            return bookings;
        }
    }
}