using System.ComponentModel;
using BSM_BusinessDataLogic;
using BSM_Common;
using BSM_DataService;
namespace BikeStoreManagement
{
    internal class Program
    {
        static BikeDataService bikeDataService = new BikeDataService();
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

            string[] actions = new string[] { "[1] Show Bikes ", "[2] Add Bike", "[3] Delete Bike", "[4] Update Bike Info" };
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
                    DisplayBikes();
                    ShowMenu();

                    break;
                case 2:
                    Console.WriteLine("-------------------------");
                    AddBike();
                    break;

                case 3:
                    Console.WriteLine("-------------------------");
                    Delete();
                    break;
                case 4:
                    Console.WriteLine("-------------------------");
                    Update();
                    break;
                default:
                    Console.WriteLine("Invalid Action");
                    ShowMenu();
                    break;

            }

        }
        static void DisplayBikes()
        {
            List<Bikeparts> bikes = bikeDataService.GetAllBikes();



            for (int i = 0; i < bikes.Count; i++)
            {
                var bike = bikes[i];
                Console.WriteLine($"[{i}] Type: {bike.BikeType}");
                Console.WriteLine($"Brand: {bike.Brand}");
                Console.WriteLine($"Price: {bike.Price}");
                Console.WriteLine($"FrameSet: {bike.Frameset}");
                Console.WriteLine($"GroupSet: {bike.Groupset}");
                Console.WriteLine($"WheelSet: {bike.Wheelset}");
            }


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
            else if (response == "N") 
            {
                Console.WriteLine("Thank you!");
            }
            else
            {
                 Console.WriteLine("Invalid input");
            }
        }
        static void Update()
        {
            List<Bikeparts> bikes = bikeDataService.GetAllBikes();
            DisplayBikes();

            Console.WriteLine("-------------------------");
            Console.Write("Enter index of the bike to update: ");
            string input = Console.ReadLine();
            int index;

            while (!BSMService.IsValidIndex(input, bikes.Count, out index))
            {
                Console.WriteLine("Invalid index.");
                Console.Write("Please enter a valid index: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("-------------------------");
            Bikeparts selectedBike = bikes[index];

            Console.WriteLine("Select what bike part you would like to update:");
            string[] actions = new string[] { "[1] Price", "[2] FrameSet", "[3] GroupSet", "[4] WheelSet" };

            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.WriteLine("-------------------------");
            Console.Write("Enter option number: ");
            int updateOption = Convert.ToInt32(Console.ReadLine());

            switch (updateOption)
            {
                case 1:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new price: ");
                    selectedBike.Price = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new FrameSet: ");
                    selectedBike.Frameset = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new GroupSet: ");
                    selectedBike.Groupset = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("-------------------------");
                    Console.Write("Enter new WheelSet: ");
                    selectedBike.Wheelset = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Invalid option.");
                    ShowMenu();
                    return;
            }

            bikeDataService.UpdateBike(index, selectedBike);
            Console.WriteLine("-------------------------");
            Console.WriteLine("Update complete!");
            ShowMenu();
        }

        static void AddBike()
        {

            Bikeparts addNewBike = new Bikeparts();

            Console.Write("Enter Bike type: ");
            addNewBike.BikeType = Console.ReadLine();

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

            bikeDataService.AddBike(addNewBike);
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
            List<Bikeparts> bikes = bikeDataService.GetAllBikes();
            DisplayBikes();
            Console.WriteLine("-------------------------");
            Console.Write("Enter index of the bike to delete: ");
            string input = Console.ReadLine();
            int index;

            while (!BSMService.IsValidIndex(input, bikes.Count, out index))
            {
                Console.WriteLine("Invalid index.");
                Console.Write("Please enter a valid index: ");
                input = Console.ReadLine();
            }

            bikeDataService.DeleteBike(index, bikes[index]);
            Console.WriteLine("Bike successfully deleted.");
            ShowMenu();
        }

    }

}
