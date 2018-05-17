using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReservationSystem.Models
{
    public class ReservationRequest
    {
        public int ProductID { get; set; }
        public DateTime Checkin { get; set; }

        public DateTime Checkout { get; set; }
    }
}