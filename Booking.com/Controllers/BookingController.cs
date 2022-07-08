using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using m = Booking.com.Model;

namespace Booking.com.Controllers
{
    /*
        1. Crear un store procedure spGetBookings (parametro @Email)
            a. SELECT a la tabla Booking WHERE por email = @Email
	
        2. En el bookingController modificar el metodo GetBookings() para que vaya 
            a ejecutar spGetBookings de la base de datos. Basarse en 'public List<Resort> GetResorts()'

        3. Probar     
    */

    public class BookingController
    {
        public void SaveBooking(m.Booking booking)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@ResortId", booking.Id),
                new SqlParameter("@Email", booking.Email),
                new SqlParameter("@Checkin", booking.Checkin),
                new SqlParameter("@Checkout", booking.Checkout),
                new SqlParameter("@Adults", booking.Adults),
                new SqlParameter("@Kids", booking.Kids),
                new SqlParameter("@Nights", booking.Nights),
                new SqlParameter("@BookingCost", booking.BookingCost),
                new SqlParameter("@BookingCostPerNight", booking.BookingCostPerNight),
                new SqlParameter("@BookingTotalCost", booking.BookingTotalCost),
            };

            Database.DatabaseHelper.ExecuteNonQuery("[dbo].[spSaveBooking]", param);
        }

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