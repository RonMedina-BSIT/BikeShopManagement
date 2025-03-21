using System.ComponentModel;

namespace BikeStoreManagement
{
    internal class Program
    {
       
        

        //mountainpeak info
        private static int mtpPrice = 25000;
        private static string mtpFrameSet = "Mountain Peak Ninja II\nMountain Peak remote lock out air fork 100mm ";
        private static string mtpGroupSet = "SX sram shifter 12speed ";
        private static string mtpWheelset = "Innova-pro skinwall 27.5x2.25";

        //trek info
        private static int trekPrice =25990;
        private static string trekFrameSet = "Alpha Silver Aluminum, internal routing\nspring, preload, 42mm offset for 27.5'' wheel, 100mm";
        private static string trekGroupSet = "Shimano Tourney TY300";
        private static string trekWheelset = "HUB:Formula DC-20, alloy, 6-bolt,\n32-hole, 20mm width, schrader valve\n Bontrager XR2 Comp, wire bead, 30 tpi, 29x2.20''";

        //orbea info
        private static int orbeaPrice = 85000;
        private static string orbeaFrameSet = "FRAME: Orbea Alma Hydro Alloy, Boost 12x148, BSA BB, Internal cable routing.\nFORK: SR Suntour RAIDON 32 100mm Boost";
        private static string orbeaGroupSet = "SRAM PG-1230 Eagle 11-50t 12-Speed";
        private static string orbeaWheelSet = " Orbea OC1 25c Tubeless Ready";

        //Giant info
        private static int giantPrice = 240000;
        private static string giantFrameSet = "Frame: Advanced-grade composite, disc\nFork: Advanced-grade composite, full-composite OverDrive Aero steerer, disc";
        private static string giantGroupSet = "SRAM Rival eTap AXS 2x12";
        private static string giantWheelSet = "Rims: Giant SLR 2 50 Carbon Disc\nTyres: Giant Gavia Course 1";

        //Cervelo info
        private static int cerveloPrice = 179990;
        private static string cerveloFrameSet = "Frame: Caledonia (2024) Endurance Carbon\nFork: Tapered Caledonia Fork ";
        private static string cerveloGroupSet = "Shimano 105, R7100, 12 speed";
        private static string cerveloWheelSet = "Rims: Alexrims Boondocks 5-D, 28h\nTires: Zaffiro Pro V G2.0 700x30c";

        //Cannondale info
        private static int cannondalePrice = 49000;
        private static string cannondaleFrameSet = "Frame: SmartForm C2 Alloy\nFork: CAAD Optimo Full Carbon";
        private static string cannondaleGroupSet = "Shimano Sora, 9-speed";
        private static string cannondaleWheelSet = "Rims: RD 3.0, 28h\nTires: Vittoria Zaffiro, 700 x 28c";


        //add bike info
        private static string addBikeBrand = "";
        private static int addBikePrice= 0;
        private static string addBikeFrameSet = "";
        private static string addBikeGroupSet = "";
        private static string addBikeWheelSet = "";
        



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cy's Bike Shop");
            ShowBikeAction();
        }
        static void ShowBikeAction()
        {
            Console.WriteLine("Select a Type Of Bike");

            string[] actions = new string[] { "[1] Mountain Bikes", "[2] Road Bikes", "[3] Display All","[4] Add Bike" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.Write("Enter Action: ");

            int userAction = Convert.ToInt16(Console.ReadLine());

            switch (userAction)
            {
                case 1:
                    MountainBikes();
                    break;
                case 2:
                    RoadBikes();
                    break;

                case 3:
                    DisplayallAction();
                    break;
                case 4:
                    Console.WriteLine("Enter Bike Brand: ");
                    string NewBikeBrand = Console.ReadLine();

                    addBikeBrand = NewBikeBrand;

                    Console.WriteLine("Enter Brand: " + addBikeBrand);
                    Console.WriteLine("Enter Price: " + addBikePrice);
                    Console.WriteLine("Enter FrameSet: " + addBikeFrameSet);
                    Console.WriteLine("Enter GroupSet: " + addBikeGroupSet);
                    Console.WriteLine("Enter WheelSet: " + addBikeWheelSet);


                    break;

            }

        }
        static void MountainBikes()
        {
           

            Console.WriteLine("Select a Brand for MountainBike");

            string[] actions = new string[] { "[1] MountainPeak", "[2] Trek ", "[3] Orbea" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.Write("Enter Action: ");

            int userAction = Convert.ToInt16(Console.ReadLine());

            switch (userAction)
            {
                case 1:
                    Console.WriteLine("MountainPeak");
                    Console.WriteLine("Price: " + mtpPrice);
                    Console.WriteLine("Frameset: " + mtpFrameSet);
                    Console.WriteLine("Groupset: " + mtpGroupSet);
                    Console.WriteLine("Wheelset: " + mtpWheelset);

                   
                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    string response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y") {


                        Console.WriteLine("Select what you want to update");

                        string[] actions1 = new string[] { "[1] Price", "[2] FrameSet ", "[3] GroupSet", "[4] WheelSet" };
                        Console.WriteLine("ACTIONS");

                        foreach (var action in actions1)
                        {
                            Console.WriteLine(action);
                        }
                        Console.Write("Enter Action: ");

                        int userUpdateAction = Convert.ToInt16(Console.ReadLine());

                        switch (userUpdateAction)
                        {
                            case 1:
                                Console.WriteLine("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                mtpPrice = NewPrice;
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();

                                mtpFrameSet = NewFrameset;
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();

                                mtpGroupSet = NewGroupSet;
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();

                                mtpWheelset = NewWheelset;
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                break;
                        }
                          
                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                    }
                        break;
                case 2:
                    Console.WriteLine("Trek");
                    Console.WriteLine("Price: " + trekPrice);
                    Console.WriteLine("Frameset: " + trekFrameSet);
                    Console.WriteLine("Groupset: " + trekGroupSet);
                    Console.WriteLine("Wheelset: " + trekWheelset);

                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y"){
                        Console.WriteLine("Select what you want to update");

                        string[] actions1 = new string[] { "[1] Price", "[2] FrameSet ", "[3] GroupSet", "[4] WheelSet" };
                        Console.WriteLine("ACTIONS");

                        foreach (var action in actions1)
                        {
                            Console.WriteLine(action);
                        }
                        Console.Write("Enter Action: ");

                        int userUpdateAction = Convert.ToInt16(Console.ReadLine());

                        switch (userUpdateAction)
                        {
                            case 1:
                                Console.WriteLine("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                trekPrice = NewPrice;
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();

                                trekFrameSet = NewFrameset;
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();

                                trekGroupSet = NewGroupSet;
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();

                                trekWheelset = NewWheelset;
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                break;
                        }
 
                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                    }



                        break;
                case 3:
                    Console.WriteLine("Orbea");
                    Console.WriteLine("Price: " + orbeaPrice);
                    Console.WriteLine("Frameset: " + orbeaFrameSet);
                    Console.WriteLine("Groupset: " + orbeaGroupSet);
                    Console.WriteLine("Wheelset: " + orbeaWheelSet);


                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        Console.WriteLine("Select what you want to update");

                        string[] actions1 = new string[] { "[1] Price", "[2] FrameSet ", "[3] GroupSet", "[4] WheelSet" };
                        Console.WriteLine("ACTIONS");

                        foreach (var action in actions1)
                        {
                            Console.WriteLine(action);
                        }
                        Console.Write("Enter Action: ");

                        int userUpdateAction = Convert.ToInt16(Console.ReadLine());

                        switch (userUpdateAction)
                        {
                            case 1:
                                Console.WriteLine("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                orbeaPrice = NewPrice;
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + orbeaPrice);
                                Console.WriteLine("Frameset: " + orbeaFrameSet);
                                Console.WriteLine("Groupset: " + orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + orbeaWheelSet);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();

                                orbeaFrameSet = NewFrameset;
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + orbeaPrice);
                                Console.WriteLine("Frameset: " + orbeaFrameSet);
                                Console.WriteLine("Groupset: " + orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + orbeaWheelSet);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();

                                orbeaGroupSet = NewGroupSet;
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + orbeaPrice);
                                Console.WriteLine("Frameset: " + orbeaFrameSet);
                                Console.WriteLine("Groupset: " + orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + orbeaWheelSet);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();

                                orbeaWheelSet = NewWheelset;
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + orbeaPrice);
                                Console.WriteLine("Frameset: " + orbeaFrameSet);
                                Console.WriteLine("Groupset: " + orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + orbeaWheelSet);
                                break;
                        }

                        }
                    else
                    {
                        Console.WriteLine("Thank you!");
                    }



                        break;
            }

        }
        static void RoadBikes()
        {
            Console.WriteLine("Select a Brand for RoadBike");

            string[] actions = new string[] { "[1] Giant", "[2] Cervelo ", "[3] Cannondale" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.Write("Enter Action: ");

            int userAction = Convert.ToInt16(Console.ReadLine());

            switch (userAction)
            {
                case 1:
                    Console.WriteLine("Giant");
                    Console.WriteLine("Price: " + giantPrice);
                    Console.WriteLine("Frameset: " + giantFrameSet);
                    Console.WriteLine("Groupset: " + giantGroupSet);
                    Console.WriteLine("Wheelset: " + giantWheelSet);

                    Console.WriteLine("Do you want to change Something?(Y/N)");
                   string response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        Console.WriteLine("Select what you want to update");

                        string[] actions1 = new string[] { "[1] Price", "[2] FrameSet ", "[3] GroupSet", "[4] WheelSet" };
                        Console.WriteLine("ACTIONS");

                        foreach (var action in actions1)
                        {
                            Console.WriteLine(action);
                        }
                        Console.Write("Enter Action: ");

                        int userUpdateAction = Convert.ToInt16(Console.ReadLine());

                        switch (userUpdateAction)
                        {
                            case 1:
                                Console.WriteLine("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                giantPrice = NewPrice;
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();

                                giantFrameSet = NewFrameset;
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();

                                giantGroupSet = NewGroupSet;
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();

                                giantWheelSet = NewWheelset;
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                break;
                        }
                        }
                    else
                    {
                        Console.WriteLine("Thank You!");
                    }
                        break;
                case 2:
                    Console.WriteLine("Cervelo");
                    Console.WriteLine("Price: " + cerveloPrice);
                    Console.WriteLine("Frameset: " + cerveloFrameSet);
                    Console.WriteLine("Groupset: " + cerveloGroupSet);
                    Console.WriteLine("Wheelset: " + cerveloWheelSet);
                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        Console.WriteLine("Select what you want to update");

                        string[] actions1 = new string[] { "[1] Price", "[2] FrameSet ", "[3] GroupSet", "[4] WheelSet" };
                        Console.WriteLine("ACTIONS");

                        foreach (var action in actions1)
                        {
                            Console.WriteLine(action);
                        }
                        Console.Write("Enter Action: ");
                        int userUpdateAction = Convert.ToInt16(Console.ReadLine());

                        switch (userUpdateAction)
                        {
                            case 1:
                                Console.WriteLine("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                cerveloPrice = NewPrice;
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();

                                cerveloFrameSet = NewFrameset;
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();

                                cerveloGroupSet = NewGroupSet;
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();

                                cerveloWheelSet = NewWheelset;
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                    }
                        break;
                case 3:
                    Console.WriteLine("Cannondale");
                    Console.WriteLine("Price: " + cannondalePrice);
                    Console.WriteLine("Frameset: " + cannondaleFrameSet);
                    Console.WriteLine("Groupset: " + cannondaleGroupSet);
                    Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    response = Console.ReadLine();
                    response = response.ToUpper();
                    if(response == "Y")
                    {
                        Console.WriteLine("Select what you want to update");

                        string[] actions1 = new string[] { "[1] Price", "[2] FrameSet ", "[3] GroupSet", "[4] WheelSet" };
                        Console.WriteLine("ACTIONS");

                        foreach (var action in actions1)
                        {
                            Console.WriteLine(action);
                        }
                        Console.Write("Enter Action: ");

                        int userUpdateAction = Convert.ToInt16(Console.ReadLine());

                        switch (userUpdateAction)
                        {
                            case 1:
                                Console.WriteLine("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                cannondalePrice = NewPrice;
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();

                                cannondaleFrameSet = NewFrameset;
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();

                                cannondaleGroupSet = NewGroupSet;
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();

                                cannondaleWheelSet = NewWheelset;
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                    }
                        break;
            }
        }

        static void DisplayallAction()
        {
            Console.WriteLine("MountainPeak");
            Console.WriteLine("Price: " + mtpPrice);
            Console.WriteLine("Frameset: " + mtpFrameSet);
            Console.WriteLine("Groupset: " + mtpGroupSet);
            Console.WriteLine("Wheelset: " + mtpWheelset);
            Console.WriteLine("\n");
            Console.WriteLine("Trek");
            Console.WriteLine("Price: " + trekPrice);
            Console.WriteLine("Frameset: " + trekFrameSet);
            Console.WriteLine("Groupset: " + trekGroupSet);
            Console.WriteLine("Wheelset: " + trekWheelset);
            Console.WriteLine("\n");
            Console.WriteLine("Orbea");
            Console.WriteLine("Price: " + orbeaPrice);
            Console.WriteLine("Frameset: " + orbeaFrameSet);
            Console.WriteLine("Groupset: " + orbeaGroupSet);
            Console.WriteLine("Wheelset: " + orbeaWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Giant");
            Console.WriteLine("Price: " + giantPrice);
            Console.WriteLine("Frameset: " + giantFrameSet);
            Console.WriteLine("Groupset: " + giantGroupSet);
            Console.WriteLine("Wheelset: " + giantWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Cervelo");
            Console.WriteLine("Price: " + cerveloPrice);
            Console.WriteLine("Frameset: " + cerveloFrameSet);
            Console.WriteLine("Groupset: " + cerveloGroupSet);
            Console.WriteLine("Wheelset: " + cerveloWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Cannondale");
            Console.WriteLine("Price: " + cannondalePrice);
            Console.WriteLine("Frameset: " + cannondaleFrameSet);
            Console.WriteLine("Groupset: " + cannondaleGroupSet);
            Console.WriteLine("Wheelset: " + cannondaleWheelSet);



            Console.WriteLine("Do you want to Delete Something?(Y/N)");
          string  response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                string[] actions = new string[] { "[1] MountainPeak", "[2] Trek", "[3] Orbea","[4] Giant", "[5] Cervelo", "[6] Cannondale" };
                Console.WriteLine("ACTIONS");

                foreach (var action in actions)
                {
                    Console.WriteLine(action);
                }
                Console.Write("Enter Action: ");
             

                int userAction = Convert.ToInt16(Console.ReadLine());

                switch (userAction)
                {
                    case 1:
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + trekPrice);
                        Console.WriteLine("Frameset: " + trekFrameSet);
                        Console.WriteLine("Groupset: " + trekGroupSet);
                        Console.WriteLine("Wheelset: " + trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + orbeaPrice);
                        Console.WriteLine("Frameset: " + orbeaFrameSet);
                        Console.WriteLine("Groupset: " + orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + giantPrice);
                        Console.WriteLine("Frameset: " + giantFrameSet);
                        Console.WriteLine("Groupset: " + giantGroupSet);
                        Console.WriteLine("Wheelset: " + giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + cerveloPrice);
                        Console.WriteLine("Frameset: " + cerveloFrameSet);
                        Console.WriteLine("Groupset: " + cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + cannondalePrice);
                        Console.WriteLine("Frameset: " + cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                        

                        break;
                    case 2:
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + mtpPrice);
                        Console.WriteLine("Frameset: " + mtpFrameSet);
                        Console.WriteLine("Groupset: " + mtpGroupSet);
                        Console.WriteLine("Wheelset: " + mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + orbeaPrice);
                        Console.WriteLine("Frameset: " + orbeaFrameSet);
                        Console.WriteLine("Groupset: " + orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + giantPrice);
                        Console.WriteLine("Frameset: " + giantFrameSet);
                        Console.WriteLine("Groupset: " + giantGroupSet);
                        Console.WriteLine("Wheelset: " + giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + cerveloPrice);
                        Console.WriteLine("Frameset: " + cerveloFrameSet);
                        Console.WriteLine("Groupset: " + cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + cannondalePrice);
                        Console.WriteLine("Frameset: " + cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + cannondaleWheelSet);


                        break;
                    case 3:
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + mtpPrice);
                        Console.WriteLine("Frameset: " + mtpFrameSet);
                        Console.WriteLine("Groupset: " + mtpGroupSet);
                        Console.WriteLine("Wheelset: " + mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + trekPrice);
                        Console.WriteLine("Frameset: " + trekFrameSet);
                        Console.WriteLine("Groupset: " + trekGroupSet);
                        Console.WriteLine("Wheelset: " + trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + giantPrice);
                        Console.WriteLine("Frameset: " + giantFrameSet);
                        Console.WriteLine("Groupset: " + giantGroupSet);
                        Console.WriteLine("Wheelset: " + giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + cerveloPrice);
                        Console.WriteLine("Frameset: " + cerveloFrameSet);
                        Console.WriteLine("Groupset: " + cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + cannondalePrice);
                        Console.WriteLine("Frameset: " + cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + cannondaleWheelSet);



                        break;
                    case 4:
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + mtpPrice);
                        Console.WriteLine("Frameset: " + mtpFrameSet);
                        Console.WriteLine("Groupset: " + mtpGroupSet);
                        Console.WriteLine("Wheelset: " + mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + trekPrice);
                        Console.WriteLine("Frameset: " + trekFrameSet);
                        Console.WriteLine("Groupset: " + trekGroupSet);
                        Console.WriteLine("Wheelset: " + trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + orbeaPrice);
                        Console.WriteLine("Frameset: " + orbeaFrameSet);
                        Console.WriteLine("Groupset: " + orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + cerveloPrice);
                        Console.WriteLine("Frameset: " + cerveloFrameSet);
                        Console.WriteLine("Groupset: " + cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + cannondalePrice);
                        Console.WriteLine("Frameset: " + cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + cannondaleWheelSet);


                        break;
                    case 5:
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + mtpPrice);
                        Console.WriteLine("Frameset: " + mtpFrameSet);
                        Console.WriteLine("Groupset: " + mtpGroupSet);
                        Console.WriteLine("Wheelset: " + mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + trekPrice);
                        Console.WriteLine("Frameset: " + trekFrameSet);
                        Console.WriteLine("Groupset: " + trekGroupSet);
                        Console.WriteLine("Wheelset: " + trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + orbeaPrice);
                        Console.WriteLine("Frameset: " + orbeaFrameSet);
                        Console.WriteLine("Groupset: " + orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + giantPrice);
                        Console.WriteLine("Frameset: " + giantFrameSet);
                        Console.WriteLine("Groupset: " + giantGroupSet);
                        Console.WriteLine("Wheelset: " + giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + cannondalePrice);
                        Console.WriteLine("Frameset: " + cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + cannondaleWheelSet);

                        break;
                    case 6:
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + mtpPrice);
                        Console.WriteLine("Frameset: " + mtpFrameSet);
                        Console.WriteLine("Groupset: " + mtpGroupSet);
                        Console.WriteLine("Wheelset: " + mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + trekPrice);
                        Console.WriteLine("Frameset: " + trekFrameSet);
                        Console.WriteLine("Groupset: " + trekGroupSet);
                        Console.WriteLine("Wheelset: " + trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + orbeaPrice);
                        Console.WriteLine("Frameset: " + orbeaFrameSet);
                        Console.WriteLine("Groupset: " + orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + giantPrice);
                        Console.WriteLine("Frameset: " + giantFrameSet);
                        Console.WriteLine("Groupset: " + giantGroupSet);
                        Console.WriteLine("Wheelset: " + giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + cerveloPrice);
                        Console.WriteLine("Frameset: " + cerveloFrameSet);
                        Console.WriteLine("Groupset: " + cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + cerveloWheelSet);
                       

                        break;
                }
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
            }
    }
}
