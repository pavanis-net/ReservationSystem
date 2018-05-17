using System;
using ReservationSystem.Models;

namespace ReservationSystem.BusinessLogic
{
    public class PricingLogic
    {
        public static decimal GetAverageDailyPrice(DateTime checkin, DateTime checkout)
        {
            double totalCost = 0;

            for (DateTime d = checkin; d >= checkin && d <= checkout; d = d.AddDays(1))
            {
                if ((d.DayOfWeek >= DayOfWeek.Monday) && (d.DayOfWeek <= DayOfWeek.Thursday))
                {
                    totalCost = totalCost + 8.95;

                }
                else if (d.DayOfWeek == DayOfWeek.Friday)
                    totalCost = totalCost + 9.95;
                else if (d.DayOfWeek == DayOfWeek.Saturday)
                    totalCost = totalCost + 10.95;
                else if (d.DayOfWeek == DayOfWeek.Sunday)
                    totalCost = totalCost + 7.95;

            }

            return (decimal)(totalCost / (checkout - checkin).TotalDays);
          
        }
    }
}