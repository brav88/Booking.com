using Booking.com.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Booking.com.Views
{
    public partial class bookings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BookingController bookingController = new BookingController();

            repBooking.DataSource = bookingController.GetBookings();
            repBooking.DataBind();
        }
    }
}