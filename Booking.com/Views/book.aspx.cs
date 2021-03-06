using Booking.com.Controllers;
using Booking.com.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using m = Booking.com.Model;

namespace Booking.com.Views
{
    public partial class book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User user = (User)Session["User"];

                if (user != null)
                {
                    int resortId = Convert.ToInt16(Request.QueryString["resortId"].ToString());

                    ResortController resortController = new ResortController();

                    List<Resort> resortFound = resortController.GetResort(resortId);

                    lblBookingCost.InnerText = resortFound[0].Price.ToString();
                    dtCheckin.Value = DateTime.Now.AddDays(15).ToString("yyyy-MM-dd");
                    dtCheckout.Value = DateTime.Now.AddDays(19).ToString("yyyy-MM-dd");
                    intAdults.Value = "2";
                    intKids.Value = "0";
                    intNights.InnerText = "4";
                    BookingCostPerNight.InnerText = resortFound[0].Price.ToString();
                    BookingCostDetail.InnerText = Convert.ToDecimal(resortFound[0].Price * 4).ToString();
                    BookingTotalCost.InnerText = Convert.ToDecimal((resortFound[0].Price * 4) + 30).ToString();

                    repBookResort.DataSource = resortFound;
                    repBookResort.DataBind();
                }
                else
                {
                    Response.Redirect("resorts.aspx?user=nosession");
                }
            }
        }

        protected void btnSaveBook_ServerClick(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if (user != null)
            {
                int resortId = Convert.ToInt16(Request.QueryString["resortId"].ToString());
                BookingController bookingController = new BookingController();

                m.Booking booking = new m.Booking()
                {
                    Id = resortId,
                    Email = user.Email,
                    Checkin = dtCheckin.Value,
                    Checkout = dtCheckout.Value,
                    Adults = Convert.ToInt16(intAdults.Value),
                    Kids = Convert.ToInt16(intKids.Value),
                    Nights = Convert.ToInt16(intNights.InnerText),
                    BookingTotalCost = Convert.ToInt32(BookingTotalCost.InnerText),
                    BookingCostPerNight = Convert.ToInt32(BookingCostPerNight.InnerText),
                    BookingCost = Convert.ToInt32(BookingCostDetail.InnerText)
                };

                bookingController.SaveBooking(booking);
            }
            else
            {
                Response.Redirect("resorts.aspx?user=nosession");
            }
        }
    }
}