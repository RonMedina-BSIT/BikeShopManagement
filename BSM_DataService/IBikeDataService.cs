using BSM_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM_DataService
{
   public interface IBikeDataService
    {
        List<Bikeparts> GetAllBikes();
        void AddBike(Bikeparts bike);
        void UpdateBike(int index, Bikeparts updatedBike);
        void DeleteBike(int index);
    }
}
