using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Booking.com.Controllers;
using Booking.com.Model;

namespace Booking.com.Views
{
    public partial class resorts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if (user == null)
            {
                NoSession();
            }
            else
            {                
                ActiveSession(user);                
            }

            if (Request.QueryString["user"] == "nosession")
            {
                ShowMessage("You must log in to access this page");
            }

            ResortController resortController = new ResortController();

            repResort.DataSource = resortController.GetResorts();
            repResort.DataBind();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Email = email.Value,
                Password = password.Value
            };

            UserController userController = new UserController();

            if (userController.Login(user))
            {
                Session["User"] = user;
                ActiveSession(user);                                
            }
            else
            {
                ShowMessage("Incorrect username or password");
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            NoSession();
            ShowMessage("Thank you for your visit");
        }

        public void NoSession()
        {
            cardLogin.Visible = true;
            cardLogout.Attributes.Add("hidden", "hidden");
        }

        public void ActiveSession(User user)
        {
            ShowMessage(string.Format("Welcome {0}", user.Email));
            lblUser.InnerText = user.Email;
            cardLogin.Visible = false;
            cardLogout.Attributes.Remove("hidden");
        }

        public void ShowMessage(string message)
        {
            divAlert.InnerText = message;
            divAlert.Attributes.Remove("hidden");
        }
    }
}