using Booking.com.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace Booking.com.Controllers
{
    public class ResortController
    {
        public List<Resort> GetResorts()
        {
            List<Resort> resorts = new List<Resort>();

            DataTable ds = Database.DatabaseHelper.ExecuteSql("SELECT * FROM Resort");

            foreach (DataRow row in ds.Rows)
            {
                resorts.Add(new Resort()
                {
                    Id = Convert.ToInt16(row["Id"]),
                    Name = row["Name"].ToString(),
                    Description = row["Description"].ToString(),
                    Photo = row["Photo"].ToString(),
                    Price = Convert.ToDecimal(row["Price"])
                });
            }

            return resorts;
        }

        public List<Resort> GetResort(int resortId)
        {
            List<Resort> resorts = GetResorts();

            foreach (Resort resort in resorts)
            {
                if (resort.Id == resortId)
                {
                    resorts.Clear();
                    resorts.Add(resort);
                    return resorts;
                }
            }

            return null;
        }
    }
}