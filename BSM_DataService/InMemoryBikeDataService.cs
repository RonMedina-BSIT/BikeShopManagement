using BSM_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace BSM_DataService
{
    
    public class InMemoryBikeDataService:IBikeDataService
    {
        List<Bikeparts> BikeInfo = new List<Bikeparts>();
        public InMemoryBikeDataService()
        {
            CreateBikeInfo();
        }
        private void CreateBikeInfo()
        {
            if (BikeInfo.Count > 0)
                return;//Para hindi mag duplicate sa mga loop

            Bikeparts mtp = new Bikeparts();
            mtp.BikeType = "Mountain Bike";
            mtp.Brand = "MountainPeak";
            mtp.Price = 25000;
            mtp.Frameset = "Mountain Peak Ninja II\nMountain Peak remote lock out air fork 100mm ";
            mtp.Groupset = "SX sram shifter 12speed";
            mtp.Wheelset = "Innova-pro skinwall 27.5x2.25";
            BikeInfo.Add(mtp);


            Bikeparts trek = new Bikeparts();
            trek.BikeType = "Mountain Bike";
            trek.Brand = "Trek";
            trek.Price = 25990;
            trek.Frameset = "Alpha Silver Aluminum, internal routing\nspring, preload, 42mm offset for 27.5'' wheel, 100mm";
            trek.Groupset = "Shimano Tourney TY300";
            trek.Wheelset = "HUB:Formula DC-20, alloy, 6-bolt,\n32-hole, 20mm width, schrader valve\n Bontrager XR2 Comp, wire bead, 30 tpi, 29x2.20";
            BikeInfo.Add(trek);

            Bikeparts orbea = new Bikeparts();
            orbea.BikeType = "Mountain Bike";
            orbea.Brand = "Orbea";
            orbea.Price = 85000;
            orbea.Frameset = "FRAME: Orbea Alma Hydro Alloy, Boost 12x148, BSA BB, Internal cable routing.\nFORK: SR Suntour RAIDON 32 100mm Boost";
            orbea.Groupset = "SRAM PG-1230 Eagle 11-50t 12-Speed";
            orbea.Wheelset = " Orbea OC1 25c Tubeless Ready";
            BikeInfo.Add(orbea);

            Bikeparts giant = new Bikeparts();
            giant.BikeType = "Road Bike";
            giant.Brand = "Giant";
            giant.Price = 240000;
            giant.Frameset = "Frame: Advanced-grade composite, disc\nFork: Advanced-grade composite, full-composite OverDrive Aero steerer, disc";
            giant.Groupset = "SRAM Rival eTap AXS 2x12";
            giant.Wheelset = "Rims: Giant SLR 2 50 Carbon Disc\nTyres: Giant Gavia Course 1";
            BikeInfo.Add(giant);

            Bikeparts cervelo = new Bikeparts();
            cervelo.BikeType = "Road Bike";
            cervelo.Brand = "Cervelo";
            cervelo.Price = 179990;
            cervelo.Frameset = "Frame: Caledonia (2024) Endurance Carbon\nFork: Tapered Caledonia Fork ";
            cervelo.Groupset = "Shimano 105, R7100, 12 speed";
            cervelo.Wheelset = "Rims: Alexrims Boondocks 5-D, 28h\nTires: Zaffiro Pro V G2.0 700x30c";
            BikeInfo.Add(cervelo);

            Bikeparts cannondale = new Bikeparts();
            cannondale.BikeType = "Road Bike";
            cannondale.Brand = "Cannondale";
            cannondale.Price = 49000;
            cannondale.Frameset = "Frame: SmartForm C2 Alloy\nFork: CAAD Optimo Full Carbon";
            cannondale.Groupset = "Shimano Sora, 9-speed";
            cannondale.Wheelset = "Rims: RD 3.0, 28h\nTires: Vittoria Zaffiro, 700 x 28c";
            BikeInfo.Add(cannondale);

            Bikeparts addBike = new Bikeparts();
            addBike.BikeType = "";
            addBike.Brand = "";
            addBike.Price = 0;
            addBike.Frameset = "";
            addBike.Groupset = "";
            addBike.Wheelset = "";
            BikeInfo.Add(addBike);
        }
        
        public List<Bikeparts> GetAllBikes()
        {
            return BikeInfo;
        }
        public void AddBike(Bikeparts bike)
        {
            BikeInfo.Add(bike);
        }
        public void UpdateBike(int index, Bikeparts updatedBike)
        {
            if (index >= 0 && index < BikeInfo.Count)
            {
                BikeInfo[index] = updatedBike;
            }
           
        }

        public void DeleteBike(int index)
        {
           
        }
    }
    }*/
