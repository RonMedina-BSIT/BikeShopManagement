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
        private static int trekPrice = 25990;
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
        private static int addBikePrice = 0;
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

            string[] actions = new string[] { "[1] Mountain Bikes", "[2] Road Bikes", "[3] Display All", "[4] Add Bike" };
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
                    Console.WriteLine("-------------------------");
                    MountainBikes();
                    break;
                case 2:
                    Console.WriteLine("-------------------------");
                    RoadBikes();
                    break;

                case 3:
                    Console.WriteLine("-------------------------");
                    DisplayallAction();
                    break;
                case 4:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter Bike Brand: ");
                    string NewBikeBrand = Console.ReadLine();
                    addBikeBrand = NewBikeBrand;
                    

                    Console.Write("Enter Price: ");
                    int NewBikePrice = Convert.ToInt32(Console.ReadLine());
                    addBikePrice = NewBikePrice;
                    
                    Console.Write("Enter FrameSet: ");
                    string NewBikeFrameSet = Console.ReadLine();
                    addBikeFrameSet = NewBikeFrameSet;

                    Console.Write("Enter GroupSet: ");
                    string NewBikeGroupSet = Console.ReadLine();
                    addBikeGroupSet = NewBikeGroupSet;

                    Console.Write("Enter WheelSet: ");
                    string NewBikeWheelSet = Console.ReadLine();
                    addBikeWheelSet = NewBikeWheelSet;

                    Console.WriteLine("Bike Added Successfully");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + addBikeBrand);
                    Console.WriteLine("Price: " + addBikePrice);
                    Console.WriteLine("FrameSet: " + addBikeFrameSet);
                    Console.WriteLine("GroupSet: " + addBikeGroupSet);
                    Console.WriteLine("WheelSet: " + addBikeWheelSet);
                    showMenu();

                    break;
                default:
                    Console.WriteLine("Invalid Action");
                    showMenu();
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
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("MountainPeak");
                    Console.WriteLine("Price: " + mtpPrice);
                    Console.WriteLine("Frameset: " + mtpFrameSet);
                    Console.WriteLine("Groupset: " + mtpGroupSet);
                    Console.WriteLine("Wheelset: " + mtpWheelset);


                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    string response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {

                        Console.WriteLine("-------------------------");
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
                                Console.Write("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());

                                mtpPrice = NewPrice;
                                Console.WriteLine("---------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                showMenu();
                                break;
                            case 2:

                                Console.Write("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                mtpFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                showMenu();
                                break;

                            case 3:

                                Console.Write("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                mtpGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                showMenu();
                                break;
                            case 4:
                                Console.Write("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                mtpWheelset = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + mtpPrice);
                                Console.WriteLine("Frameset: " + mtpFrameSet);
                                Console.WriteLine("Groupset: " + mtpGroupSet);
                                Console.WriteLine("Wheelset: " + mtpWheelset);
                                showMenu();
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thank You!");

                        showMenu();
                    }
                    break;
                case 2:
                    Console.WriteLine("---------------");
                    Console.WriteLine("Trek");
                    Console.WriteLine("Price: " + trekPrice);
                    Console.WriteLine("Frameset: " + trekFrameSet);
                    Console.WriteLine("Groupset: " + trekGroupSet);
                    Console.WriteLine("Wheelset: " + trekWheelset);

                    Console.WriteLine("Do you want to change Something?(Y/N)");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        Console.WriteLine("---------------");
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
                                Console.Write("Enter New Price: ");
                                int NewPrice = Convert.ToInt32(Console.ReadLine());
                                trekPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                showMenu();
                                break;
                            case 2:

                                Console.Write("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                trekFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                showMenu();
                                break;

                            case 3:

                                Console.Write("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                trekGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                showMenu();
                                break;
                            case 4:
                                Console.Write("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                trekWheelset = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + trekPrice);
                                Console.WriteLine("Frameset: " + trekFrameSet);
                                Console.WriteLine("Groupset: " + trekGroupSet);
                                Console.WriteLine("Wheelset: " + trekWheelset);
                                showMenu();
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                        showMenu();
                    }



                    break;
                case 3:
                    Console.WriteLine("---------------");
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
                        Console.WriteLine("---------------");
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
                                Console.WriteLine("-------------------------");
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
                                Console.WriteLine("-------------------------");
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
                                Console.WriteLine("-------------------------");
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
                                Console.WriteLine("-------------------------");
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

                        showMenu();
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
                    Console.WriteLine("-------------------------");
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
                        Console.WriteLine("-------------------------");
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
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                showMenu();

                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                giantFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                giantGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                giantWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + giantPrice);
                                Console.WriteLine("Frameset: " + giantFrameSet);
                                Console.WriteLine("Groupset: " + giantGroupSet);
                                Console.WriteLine("Wheelset: " + giantWheelSet);
                                showMenu();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                        showMenu();
                    }
                    break;
                case 2:
                    Console.WriteLine("-------------------------");
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
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                showMenu();
                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                cerveloFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                cerveloGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                cerveloWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + cerveloPrice);
                                Console.WriteLine("Frameset: " + cerveloFrameSet);
                                Console.WriteLine("Groupset: " + cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + cerveloWheelSet);
                                showMenu();
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                        showMenu();
                    }
                    break;
                case 3:
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Cannondale");
                    Console.WriteLine("Price: " + cannondalePrice);
                    Console.WriteLine("Frameset: " + cannondaleFrameSet);
                    Console.WriteLine("Groupset: " + cannondaleGroupSet);
                    Console.WriteLine("Wheelset: " + cannondaleWheelSet);
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
                                cannondalePrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                showMenu();

                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                cannondaleFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                cannondaleGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                cannondaleWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + cannondalePrice);
                                Console.WriteLine("Frameset: " + cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + cannondaleWheelSet);
                                showMenu();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thank You!");
                        showMenu();
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
            Console.WriteLine("\n");
            Console.WriteLine(addBikeBrand);
            Console.WriteLine("Price: " + addBikePrice);
            Console.WriteLine("Frameset: " + addBikeFrameSet);
            Console.WriteLine("Groupset: " + addBikeGroupSet);
            Console.WriteLine("Wheelset: " + addBikeWheelSet);
          



            Console.WriteLine("Do you want to Delete Something?(Y/N)");
            string response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                string[] actions = new string[] { "[1] MountainPeak", "[2] Trek", "[3] Orbea", "[4] Giant", "[5] Cervelo", "[6] Cannondale" };
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

        static void showMenu()
        {
            Console.WriteLine("Do you want to go back to menu?(Y/N)");
            string response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                Console.WriteLine("-------------------------");
                ShowBikeAction();
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
            }
    }

}
