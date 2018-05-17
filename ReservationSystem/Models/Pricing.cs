using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class Pricing
    {
        public int ProductID { get; set; }

        public decimal DailyPrice { get; set; }
    }
}