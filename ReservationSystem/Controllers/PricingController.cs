using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ReservationSystem.Models;
using System.Web.Http;
using System.Threading.Tasks;
using ReservationSystem.BusinessLogic;
using System.Net.Http;

namespace ReservationSystem.Controllers
{
    public class PricingController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/getPricing")]
        public async Task<IHttpActionResult> GetPricing(DateTime checkin, DateTime checkout)
        {

            try
            {
                var response = new Pricing
                {
                    ProductID = 1,
                    // DailyPrice = (decimal)(totalCost / (checkout - checkin).TotalDays)
                    DailyPrice = PricingLogic.GetAverageDailyPrice(checkin, checkout)
                };
                return Ok(response);
            }

            catch (HttpRequestException httpRequestException)
            {
                return BadRequest("Error: " + httpRequestException.Message);
            }
        }
    }
}