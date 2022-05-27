﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.com.Model
{
    public class Resort
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
    }
}