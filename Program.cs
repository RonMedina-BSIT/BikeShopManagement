using System.ComponentModel;
using BSM_BusinessDataLogic;
using BSM_Common;
using BSM_DataService;
namespace BikeStoreManagement
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Cy's Bike Shop");
            Console.Write("Enter Admin's Password to Continue: ");
            string password = Console.ReadLine();

            while (!BSMService.ValidateAdmin(password))
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Invalid Password");
                Console.WriteLine("-------------------------");
                Console.Write("Enter Admin's Password to Continue: ");
                password = Console.ReadLine();
            }

            Menu();

        }
        static void Menu()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("SELECT ACTION");

            string[] actions = new string[] { "[1] Mountain Bikes", "[2] Road Bikes", "[3] Add Bike", "[4] Delete", "[5] Update Bike Specs","[6] Display" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.WriteLine("-------------------------");
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
                    AddBike();
                    break;
                case 4:
                    Console.WriteLine("-------------------------");
                    Delete();
                    break;
                case 5:
                    Update();
                    break;
                case 6:
                    Console.WriteLine("-------------------------");
                    DisplayallAction();
                    break;
                default:
                    Console.WriteLine("Invalid Action");
                    ShowMenu();
                    break;

            }

        }
        static void MountainBikes()
        {

            BikeDataService bikeDataService = new BikeDataService();

            Console.WriteLine("Select a Brand for MountainBike");

            string[] actions = new string[] { "[0] MountainPeak", "[1] Trek ", "[2] Orbea" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.WriteLine("-------------------------");
            Console.Write("Enter Action: ");

            int userAction = Convert.ToInt16(Console.ReadLine());

            switch (userAction)
            {
                case 0:


                    Bikeparts mtp = BikeDataService.BikeInfo[0];

                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + mtp.Brand);
                    Console.WriteLine("Price: " + mtp.Price);
                    Console.WriteLine("Frameset: " + mtp.Frameset);
                    Console.WriteLine("Groupset: " + mtp.Groupset);
                    Console.WriteLine("Wheelset: " + mtp.Wheelset);
                    ShowMenu();
                    break;
                case 1:

                    Bikeparts trek = BikeDataService.BikeInfo[1];
                    Console.WriteLine("---------------");
                    Console.WriteLine("Brand: " + trek.Brand);
                    Console.WriteLine("Price: " + trek.Price);
                    Console.WriteLine("Frameset: " + trek.Frameset);
                    Console.WriteLine("Groupset: " + trek.Groupset);
                    Console.WriteLine("Wheelset: " + trek.Wheelset);
                    ShowMenu();
                    break;
                case 2:
                    Bikeparts orbea = BikeDataService.BikeInfo[2];
                    Console.WriteLine("---------------");
                    Console.WriteLine("Brand: " + orbea.Brand);
                    Console.WriteLine("Price: " + orbea.Price);
                    Console.WriteLine("Frameset: " + orbea.Frameset);
                    Console.WriteLine("Groupset: " + orbea.Groupset);
                    Console.WriteLine("Wheelset: " + orbea.Wheelset);
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Action");
                    ShowMenu();
                    break;
            }

        }
        static void RoadBikes()
        {
            BikeDataService bikeDataService = new BikeDataService();

            ;
            Console.WriteLine("Select a Brand for RoadBike");

            string[] actions = new string[] { "[1] Giant", "[2] Cervelo ", "[3] Cannondale" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.WriteLine("-------------------------");
            Console.Write("Enter Action: ");

            int userAction = Convert.ToInt16(Console.ReadLine());

            switch (userAction)
            {
                case 1:
                    Bikeparts giant = BikeDataService.BikeInfo[3];
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + giant.Brand);
                    Console.WriteLine("Price: " + giant.Price);
                    Console.WriteLine("Frameset: " + giant.Frameset);
                    Console.WriteLine("Groupset: " + giant.Groupset);
                    Console.WriteLine("Wheelset: " + giant.Wheelset);
                    ShowMenu();
                    break;
                case 2:
                    Bikeparts cervelo = BikeDataService.BikeInfo[4];
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + cervelo.Brand);
                    Console.WriteLine("Price: " + cervelo.Price);
                    Console.WriteLine("Frameset: " + cervelo.Frameset);
                    Console.WriteLine("Groupset: " + cervelo.Groupset);
                    Console.WriteLine("Wheelset: " + cervelo.Wheelset);
                    ShowMenu();
                    break;
                case 3:
                    Bikeparts cannondale = BikeDataService.BikeInfo[5];
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + cannondale.Brand);
                    Console.WriteLine("Price: " + cannondale.Price);
                    Console.WriteLine("Frameset: " + cannondale.Frameset);
                    Console.WriteLine("Groupset: " + cannondale.Groupset);
                    Console.WriteLine("Wheelset: " + cannondale.Wheelset);
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        static void DisplayallAction()
        {
            BikeDataService bikeDataService = new BikeDataService();

            foreach (Bikeparts bike in BikeDataService.BikeInfo)
            {
                Console.WriteLine("Brand: " + bike.Brand);
                Console.WriteLine("Price:" + bike.Price);
                Console.WriteLine("FrameSet:" + bike.Frameset);
                Console.WriteLine("GroupSet:" + bike.Groupset);
                Console.WriteLine("WheelSet: " + bike.Wheelset);
                Console.WriteLine("\n");
            }
            ShowMenu();

        }

        static void ShowMenu()
        {
            Console.WriteLine("-------------------------");
            Console.Write("Do you want to go back to menu?(Y/N): ");
            string response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "Y")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
        }
        static void Update()
        {
            BikeDataService bikeDataService = new BikeDataService();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Select a Brand you would like to Update");
            int count = -1;
            foreach (Bikeparts bike in BikeDataService.BikeInfo)
            {
                count++;
                Console.WriteLine("[" + count + "]" + bike.Brand);
            }
            Console.WriteLine("-------------------------");
            Console.Write("Enter Action: ");

            int userAction = Convert.ToInt16(Console.ReadLine());

            Bikeparts selectedBrand = BikeDataService.BikeInfo[userAction];

            Console.WriteLine("Select What Bike part you would like to update?");


            string[] actions = new string[] { "[1] Price", "[2] FrameSet", "[3] GroupSet", "[4] WheelSet" };
            Console.WriteLine("ACTIONS");

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.Write("Enter Action: ");

            int userActionBikepart = Convert.ToInt16(Console.ReadLine());

            switch (userActionBikepart)
            {
                case 1:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new price: ");
                    selectedBrand.Price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Update complete!");
                    ShowMenu();

                    break;
                case 2:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new FrameSet: ");
                    selectedBrand.Frameset = Console.ReadLine();
                    Console.WriteLine("Update complete!");
                    ShowMenu();
                    break;
                case 3:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new GroupSet: ");
                    selectedBrand.Groupset = Console.ReadLine();
                    Console.WriteLine("Update complete!");
                    ShowMenu();
                    break;
                case 4:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new WheelSet: ");
                    selectedBrand.Wheelset = Console.ReadLine();
                    Console.WriteLine("Update complete!");
                    ShowMenu();
                    break;
            }
        }
        static void AddBike()
        {
            BikeDataService bikeDataService = new BikeDataService();
            Bikeparts addNewBike = BikeDataService.BikeInfo[6];


            Console.Write("Enter Bike Brand: ");
            addNewBike.Brand = Console.ReadLine();

            Console.Write("Enter price: ");
            addNewBike.Price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Frameset: ");
            addNewBike.Frameset = Console.ReadLine();

            Console.Write("Enter Groupset: ");
            addNewBike.Groupset = Console.ReadLine();

            Console.Write("Enter Wheelset: ");
            addNewBike.Wheelset = Console.ReadLine();

            Console.WriteLine("-------------------------");
            Console.WriteLine("Brand: " + addNewBike.Brand);
            Console.WriteLine("Price: " + addNewBike.Price);
            Console.WriteLine("Frameset: " + addNewBike.Frameset);
            Console.WriteLine("Groupset: " + addNewBike.Groupset);
            Console.WriteLine("Wheelset: " + addNewBike.Wheelset);
            ShowMenu();
        }

        static void Delete()
        {
            Console.WriteLine("Select a Brand you would like to Delete");
           
            int count = -1;
            foreach (Bikeparts bike in BikeDataService.BikeInfo)
            {
                count++;
                Console.WriteLine("[" + count + "]" + bike.Brand);
            }

            Console.WriteLine("-------------------------");
            Console.Write("Enter Action: ");
            int userAction = Convert.ToInt16(Console.ReadLine());

            switch (userAction)
            {
                case 0:

                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(0);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();


                    break;
                case 1:
                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(1);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();

                    break;
                case 2:
                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(2);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();


                    break;
                case 3:
                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(3);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();

                    break;
                case 4:
                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(4);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();
                    break;
                case 5:
                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(5);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();
                    break;
                case 6:
                    Console.WriteLine("-------------------------");
                    BikeDataService.BikeInfo.RemoveAt(6);

                    foreach (Bikeparts bike in BikeDataService.BikeInfo)
                    {
                        Console.WriteLine("Brand: " + bike.Brand);
                        Console.WriteLine("Price:" + bike.Price);
                        Console.WriteLine("FrameSet:" + bike.Frameset);
                        Console.WriteLine("GroupSet:" + bike.Groupset);
                        Console.WriteLine("WheelSet: " + bike.Wheelset);
                        Console.WriteLine("\n");
                    }
                    ShowMenu();
                    break;
                default:
                    Console.WriteLine("Invalid Action");
                    break;
            }
        }
    
        
    }

}
