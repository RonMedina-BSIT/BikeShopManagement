using BSM_BusinessDataLogic;
using BSM_Common;
using BSM_DataService;
using BSM_BusinessDataLogic;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSM_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BSM_Controller : ControllerBase
    {
        private readonly BSMService _bsmService;
        public BSM_Controller(BSMService bsmService)
        {
            _bsmService = bsmService;
        }
        BSM_DataService.BikeDataServiceForDB bikeDataService = new BSM_DataService.BikeDataServiceForDB();
        List<Bikeparts> BikeInfo = new List<Bikeparts>();

        [HttpGet]
        public IEnumerable<Bikeparts> GetAllBikes()
        {
            BikeInfo = bikeDataService.GetAllBikes();

            return BikeInfo;
        }
        [HttpPost]
        public IActionResult AddBike([FromForm]Bikeparts bike)
        {
            _bsmService.AddbikeAndNotify(bike, "test@inbox.mailtrap.io");
            bikeDataService.AddBike(bike);
            return Ok(new { message = "Bike added successfully." });
           
        }

        [HttpDelete]
        public bool DeleteBike(Bikeparts bike)
        {
 
            return bikeDataService.DeleteBike(bike); 
           
        }
        [HttpPatch]
        public bool UpdateBike(Bikeparts bike)
        {
            bikeDataService.UpdateBike(bike);
            return true;
        }
    }
}
