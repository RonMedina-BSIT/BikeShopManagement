using BSM_Common;
namespace BSM_DataService
{
    public class BikeDataService
    {
        IBikeDataService bikeDataService;
        public BikeDataService()
        {
            //bikeDataService = new InMemoryBikeDataService();
            
           bikeDataService= new TextFileDataService();
        }
        public List<Bikeparts> GetAllBikes()
        {
            return bikeDataService.GetAllBikes();
        }
        public void AddBike(Bikeparts bike)
        {
            bikeDataService.AddBike(bike);
        }
        public void UpdateBike(int index,Bikeparts bike)
        {
            bikeDataService.UpdateBike(index,bike);
        }
        public void DeleteBike(int index,Bikeparts bike)
        {
            bikeDataService.DeleteBike(index, bike);
        }
    }
}
