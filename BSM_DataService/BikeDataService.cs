using BSM_Common;
namespace BSM_DataService
{
    public class BikeDataService
    {
        IBikeDataService bikeDataService;
        public BikeDataService()
        {
            bikeDataService = new InMemoryBikeDataService();
        }
        public List<Bikeparts> GetAllBikes()
        {
            return bikeDataService.GetAllBikes();
        }
        public void AddBike(Bikeparts bike)
        {
            bikeDataService.AddBike(bike);
        }
        public void UpdateBike(int index, Bikeparts updatedBike)
        {
            bikeDataService.UpdateBike(index, updatedBike);
        }
        public void DeleteBike(int index)
        {
            bikeDataService.DeleteBike(index);
        }
    }
}
