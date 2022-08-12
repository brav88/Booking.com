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
                    int bookingCode = Convert.ToInt16(Request.QueryString["bookingCode"].ToString());

                    ResortController resortController = new ResortController();
                    List<Resort> resortFound = resortController.GetResort(resortId);
                    repBookResort.DataSource = resortFound;
                    repBookResort.DataBind();

                    if (bookingCode != 0)
                    {
                        BookingController bookingController = new BookingController();
                        List<m.Booking> booking = bookingController.GetBooking(bookingCode);

                        dtCheckin.Value = Convert.ToDateTime(booking[0].Checkin).ToString("yyyy-MM-dd");
                        dtCheckout.Value = Convert.ToDateTime(booking[0].Checkout).ToString("yyyy-MM-dd");
                        intAdults.Value = booking[0].Adults.ToString();
                        intKids.Value = booking[0].Kids.ToString();
                        intNights.InnerText = booking[0].Nights.ToString();
                        BookingCostPerNight.InnerText = booking[0].BookingCostPerNight.ToString();
                        BookingCostDetail.InnerText = booking[0].BookingCostDetail.ToString();
                        BookingTotalCost.InnerText = booking[0].BookingTotalCost.ToString();

                        btnSaveBook.InnerText = "Update book!";
                    }
                    else
                    {
                        dtCheckin.Value = DateTime.Now.AddDays(15).ToString("yyyy-MM-dd");
                        dtCheckout.Value = DateTime.Now.AddDays(19).ToString("yyyy-MM-dd");
                        intAdults.Value = "2";
                        intKids.Value = "0";
                        intNights.InnerText = "4";
                        BookingCostPerNight.InnerText = resortFound[0].Price.ToString();
                        BookingCostDetail.InnerText = Convert.ToDecimal(resortFound[0].Price * 4).ToString();
                        BookingTotalCost.InnerText = Convert.ToDecimal((resortFound[0].Price * 4) + 30).ToString();
                    }

                    lblBookingCost.InnerText = resortFound[0].Price.ToString();
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

                int Nights = (Convert.ToDateTime(dtCheckout.Value) - Convert.ToDateTime(dtCheckin.Value)).Days;
                int BookingCost = Convert.ToInt32(lblBookingCost.InnerText);
                decimal BookingCostPerNight = Convert.ToInt16(intAdults.Value) > 2 ? Convert.ToDecimal(BookingCost * 0.13) + BookingCost : BookingCost;
                int BookingCostDetail = Convert.ToInt32(BookingCostPerNight * Nights);
                int BookingTotalCost = BookingCostDetail + 20 + 10;
                int bookingCode = Convert.ToInt16(Request.QueryString["bookingCode"].ToString());

                m.Booking booking = new m.Booking()
                {
                    BookingCode = bookingCode,
                    Id = resortId,
                    Email = user.Email,
                    Checkin = dtCheckin.Value,
                    Checkout = dtCheckout.Value,
                    Adults = Convert.ToInt16(intAdults.Value),
                    Kids = Convert.ToInt16(intKids.Value),
                    Nights = Nights,
                    BookingTotalCost = BookingTotalCost,
                    BookingCostPerNight = BookingCostPerNight,
                    BookingCostDetail = BookingCostDetail
                };                              

                if (bookingCode != 0)
                {
                    bookingController.UpdateBooking(booking);
                }
                else
                {
                    bookingController.SaveBooking(booking);
                }

                Response.Redirect("bookings.aspx");
            }
            else
            {
                Response.Redirect("resorts.aspx?user=nosession");
            }
        }
    }
}