using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSM_BusinessDataLogic
{
    
    public class BMSProcess
    {
        //mountainpeak info
        public static int mtpPrice = 25000;
        public static string mtpFrameSet = "Mountain Peak Ninja II\nMountain Peak remote lock out air fork 100mm ";
        public static string mtpGroupSet = "SX sram shifter 12speed ";
        public static string mtpWheelset = "Innova-pro skinwall 27.5x2.25";

        //trek info
        public static int trekPrice = 25990;
        public static string trekFrameSet = "Alpha Silver Aluminum, internal routing\nspring, preload, 42mm offset for 27.5'' wheel, 100mm";
        public static string trekGroupSet = "Shimano Tourney TY300";
        public static string trekWheelset = "HUB:Formula DC-20, alloy, 6-bolt,\n32-hole, 20mm width, schrader valve\n Bontrager XR2 Comp, wire bead, 30 tpi, 29x2.20''";

        //orbea info
        public static int orbeaPrice = 85000;
        public static string orbeaFrameSet = "FRAME: Orbea Alma Hydro Alloy, Boost 12x148, BSA BB, Internal cable routing.\nFORK: SR Suntour RAIDON 32 100mm Boost";
        public static string orbeaGroupSet = "SRAM PG-1230 Eagle 11-50t 12-Speed";
        public static string orbeaWheelSet = " Orbea OC1 25c Tubeless Ready";

        //Giant info
        public static int giantPrice = 240000;
        public static string giantFrameSet = "Frame: Advanced-grade composite, disc\nFork: Advanced-grade composite, full-composite OverDrive Aero steerer, disc";
        public static string giantGroupSet = "SRAM Rival eTap AXS 2x12";
        public static string giantWheelSet = "Rims: Giant SLR 2 50 Carbon Disc\nTyres: Giant Gavia Course 1";

        //Cervelo info
        public static int cerveloPrice = 179990;
        public static string cerveloFrameSet = "Frame: Caledonia (2024) Endurance Carbon\nFork: Tapered Caledonia Fork ";
        public static string cerveloGroupSet = "Shimano 105, R7100, 12 speed";
        public static string cerveloWheelSet = "Rims: Alexrims Boondocks 5-D, 28h\nTires: Zaffiro Pro V G2.0 700x30c";

        //Cannondale info
        public static int cannondalePrice = 49000;
        public static string cannondaleFrameSet = "Frame: SmartForm C2 Alloy\nFork: CAAD Optimo Full Carbon";
        public static string cannondaleGroupSet = "Shimano Sora, 9-speed";
        public static string cannondaleWheelSet = "Rims: RD 3.0, 28h\nTires: Vittoria Zaffiro, 700 x 28c";

        //add bike info
        public static string addBikeBrand = "";
        public static int addBikePrice = 0;
        public static string addBikeFrameSet = "";
        public static string addBikeGroupSet = "";
        public static string addBikeWheelSet = "";
        static string adminpassword = "admin";

        public static bool ValidateAdmin(string password)
        {
            return password == adminpassword;
        }





    }
}
