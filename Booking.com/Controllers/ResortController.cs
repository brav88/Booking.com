using Booking.com.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Booking.com.Controllers
{
    public class ResortController
    {
        public List<Resort> GetResorts()
        {
            List<Resort> resorts = new List<Resort>();

            Resort resort1 = new Resort()
            {
                Id = 1,
                Name = "Hotel Arenas Punta Leona",
                Description = "Reserva Hotel Arenas All Inclusive, Jacó. ¡Precios increíbles y sin cargos!. Confirmación inmediata.",
                Photo = "Images/1.jpg",
                Price = 125
            };

            Resort resort2 = new Resort()
            {
                Id = 2,
                Name = "Hotel Riu Palace Guanacaste",
                Description = "Precio Más Bajo Garantizado, Todo Incluido 24/7 y No Gaste de Más. ¡Reserve Hoy! En Playa Matapalo, con Piscinas y Jacuzzi.",
                Photo = "Images/2.jpg",
                Price = 135
            };

            Resort resort3 = new Resort()
            {
                Id = 3,
                Name = "Hotel Radisson San José",
                Description = "Radisson San Jose-Costa Rica · Central Street & 3rd-15th Avenue, San José, 494-1007, Costa Rica · +506 2010 6000 · reservaciones@radisson.co.cr",
                Photo = "Images/3.jpg",
                Price = 135
            };

            Resort resort4 = new Resort()
            {
                Id = 4,
                Name = "Hotel Papagayo",
                Description = "Disfruta de tus vacaciones con todo incluido en Costa Rica en el fabuloso hotel sólo para adultos Occidental Papagayo - Adults only. ¡Reserva ahora!",
                Photo = "Images/4.jpg",
                Price = 140
            };

            resorts.Add(resort1);
            resorts.Add(resort2);
            resorts.Add(resort3);
            resorts.Add(resort4);

            return resorts;
        }

        public List<Resort> GetResort(int resortId)
        {
            List<Resort> resorts = GetResorts();

            foreach(Resort resort in resorts)
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