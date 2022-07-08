using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.com.Model
{
    public class Booking : Resort
    {        
        public int BookingCode { get; set; }
        public string Email { get; set; }
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public int Adults { get; set; }
        public int Kids { get; set; }
        public int Nights { get; set; }
        public decimal BookingCost { get; set; }
        public decimal BookingCostPerNight { get; set; }
        public decimal BookingTotalCost { get; set; }
    }
}