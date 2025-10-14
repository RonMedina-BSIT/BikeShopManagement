using BSM_BusinessDataLogic;
using BSM_Common;
using BSM_DataService;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSM_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BSM_Controller : ControllerBase
    {
        BSM_DataService.BikeDataServiceForDB bikeDataService = new BSM_DataService.BikeDataServiceForDB();
        List<Bikeparts> BikeInfo = new List<Bikeparts>();

        [HttpGet]
        public IEnumerable<Bikeparts> GetAllBikes()
        {
            BikeInfo = bikeDataService.GetAllBikes();

            return BikeInfo;
        }
        [HttpPost]
        public bool AddBike(Bikeparts bike)
        {
           return bikeDataService.AddBike(bike);
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
