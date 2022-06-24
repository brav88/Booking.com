using Booking.com.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Booking.com.Controllers
{
    public class UserController
    {
        public bool Login(User user)
        {
            //Register: https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=
            //Login: https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=

            const string firebaseUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=";
            const string apiKey = "AIzaSyA_8Rjs1Pu5x-uZ-gHiso5gpkc6TMmdRfw";

            try
            {
                //Objeto request usando la URL
                var request = (HttpWebRequest)WebRequest.Create(firebaseUrl + apiKey);
                //Data del request
                var data = "email=" + user.Email + "&password=" + user.Password;
                //Conversion de la Data a Bites
                var bytes = Encoding.ASCII.GetBytes(data);
                //Tipo de request / metodo a utilizar
                request.Method = "POST";
                //Tipo de contenido del request
                request.ContentType = "application/x-www-form-urlencoded";
                //Tamaño del contenido del request
                request.ContentLength = bytes.Length;

                //Invocar el request
                using (var stream = request.GetRequestStream())
                {
                    //Inyectar la data al request
                    stream.Write(bytes, 0, bytes.Length);
                }

                //Objeto response
                var response = (HttpWebResponse)request.GetResponse();
                //Lectura del response
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                //Validamos el reponse
                if (responseString.Contains(user.Email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}