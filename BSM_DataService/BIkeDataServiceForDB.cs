using BSM_Common;
namespace BSM_DataService
{
    public class BikeDataServiceForDB
    {
        IBikeDataServiceForDB bikeDataService;
        public BikeDataServiceForDB()
        {
            //bikeDataService = new InMemoryBikeDataService();
            // bikeDataService= new TextFileDataService();
            // bikeDataService=new JsonFileDataService();
            bikeDataService = new DBDataService();
        }
        public List<Bikeparts> GetAllBikes()
        {
            return bikeDataService.GetAllBikes();
        }
        public bool AddBike(Bikeparts bike)
        {
            return bikeDataService.AddBike(bike);
        }
        public void UpdateBike(Bikeparts bike)
        {
            bikeDataService.UpdateBike(bike);
        }
        public bool DeleteBike(Bikeparts bike)
        {
            return bikeDataService.DeleteBike(bike);
        }

    }
}
