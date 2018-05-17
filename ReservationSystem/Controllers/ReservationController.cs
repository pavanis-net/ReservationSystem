using ReservationSystem.Models;
using System.Web.Http;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using ReservationSystem.BusinessLogic;

namespace ReservationSystem.Controllers
{
    public class ReservationController : ApiController
    {
        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/reservation")]
        public async Task<IHttpActionResult> CreateReservation([FromBody] ReservationRequest request)
        {
            try
            {
                var response = new Pricing
                {

                    ProductID = 1,
                    DailyPrice = PricingLogic.GetAverageDailyPrice(request.Checkin, request.Checkout)
                };
                return Json(response);

            }
            catch (HttpRequestException httpRequestException)
            {
                return BadRequest("Error: " + httpRequestException.Message);
            }
        }
    }


}
