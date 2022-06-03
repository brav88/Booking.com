using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Booking.com.Controllers;

namespace Booking.com.Views
{
    public partial class resorts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ResortController resortController = new ResortController();

            repResort.DataSource = resortController.GetResorts();
            repResort.DataBind();  
                       
        }
    }
}