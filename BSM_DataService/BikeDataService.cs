using BSM_Common;
namespace BSM_DataService
{
    public class BikeDataService
    {
        IBikeDataService bikeDataService;
        public BikeDataService()
        {
           //bikeDataService = new InMemoryBikeDataService();
           // bikeDataService= new TextFileDataService();
          bikeDataService=new JsonFileDataService();
        
        }
        public List<Bikeparts> GetAllBikes()
        {
            return bikeDataService.GetAllBikes();
        }
        public bool AddBike(Bikeparts bike)
        {
            return bikeDataService.AddBike(bike);
        }
        public void UpdateBike(int index,Bikeparts bike)
        {
            bikeDataService.UpdateBike(index,bike);
        }
        public bool DeleteBike(int index,Bikeparts bike)
        {
           return bikeDataService.DeleteBike(index,bike);
        }
      
    }
}
