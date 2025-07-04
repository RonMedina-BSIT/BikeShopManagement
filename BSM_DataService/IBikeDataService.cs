﻿using BSM_Common;
using BSM_DataService;
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
        public bool AddBike(Bikeparts bike);
        public void UpdateBike(int index, Bikeparts bike);
        public bool DeleteBike(int index, Bikeparts bike);
       
    }
}
