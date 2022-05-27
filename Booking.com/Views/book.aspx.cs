using Booking.com.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Booking.com.Views
{
    public partial class book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int resortId = Convert.ToInt16(Request.QueryString["resortId"].ToString());

            ResortController resortController = new ResortController();

            repBookResort.DataSource = resortController.GetResort(resortId);
            repBookResort.DataBind();
        }
    }
}