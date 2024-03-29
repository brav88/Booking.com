﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using m = Booking.com.Model;

namespace Booking.com.Controllers
{
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
                new SqlParameter("@BookingCost", booking.BookingCostDetail),
                new SqlParameter("@BookingCostPerNight", booking.BookingCostPerNight),
                new SqlParameter("@BookingTotalCost", booking.BookingTotalCost),
            };

            Database.DatabaseHelper.ExecuteNonQuery("[dbo].[spSaveBooking]", param);
        }

        public void UpdateBooking(m.Booking booking)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@BookingCode", booking.BookingCode),
                new SqlParameter("@Checkin", booking.Checkin),
                new SqlParameter("@Checkout", booking.Checkout),
                new SqlParameter("@Adults", booking.Adults),
                new SqlParameter("@Kids", booking.Kids),
                new SqlParameter("@Nights", booking.Nights),
                new SqlParameter("@BookingCost", booking.BookingCostDetail),
                new SqlParameter("@BookingCostPerNight", booking.BookingCostPerNight),
                new SqlParameter("@BookingTotalCost", booking.BookingTotalCost),
            };

            Database.DatabaseHelper.ExecuteNonQuery("[dbo].[spUpdateBooking]", param);
        }

        public List<m.Booking> GetBooking(int bookingCode)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@BookingCode", bookingCode),
            };

            return GetBookingData(Database.DatabaseHelper.ExecuteQuery("[dbo].[spGetBooking]", param));
        }

        public List<m.Booking> GetBookings(string email)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@Email", email),
            };

            return GetBookingData(Database.DatabaseHelper.ExecuteQuery("[dbo].[spGetBookings]", param));
        }

        public List<m.Booking> GetBookingData(DataTable ds)
        {
            List<m.Booking> bookings = new List<m.Booking>();

            foreach (DataRow row in ds.Rows)
            {
                bookings.Add(new m.Booking()
                {
                    Name = Convert.ToString(row["Name"]),
                    Photo = Convert.ToString(row["Photo"]),
                    BookingCode = Convert.ToInt16(row["BookingCode"]),
                    Id = Convert.ToInt16(row["ResortID"]),
                    Email = Convert.ToString(row["email"]),
                    Checkin = Convert.ToDateTime(row["Checkin"]).ToString("dd-MM-yyyy"),
                    Checkout = Convert.ToDateTime(row["Checkout"]).ToString("dd-MM-yyyy"),
                    Adults = Convert.ToInt16(row["Adults"]),
                    Kids = Convert.ToInt16(row["Kids"]),
                    Nights = Convert.ToInt16(row["Nights"]),
                    BookingCostDetail = Convert.ToDecimal(row["BookingCost"]),
                    BookingCostPerNight = Convert.ToDecimal(row["BookingCostPerNight"]),
                    BookingTotalCost = Convert.ToDecimal(row["BookingTotalCost"]),
                });
            }

            return bookings;
        }

        public void DeleteBooking(int bookingCode)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@BookingCode", bookingCode),
            };

            Database.DatabaseHelper.ExecuteNonQuery("[dbo].[spDeleteBooking]", param);
        }
    }
}