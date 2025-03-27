using System.ComponentModel;
using BSM_BusinessDataLogic;
namespace BikeStoreManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Cy's Bike Shop");
            Console.Write("Enter Admin's Password to Continue: ");
            string password = Console.ReadLine();

            while (!BMSProcess.ValidateAdmin(password)){
                Console.WriteLine("Invalid Password");
                Console.Write("Enter Admin's Password to Continue: ");
                password = Console.ReadLine();
            }
           
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
                    BMSData.addBikeBrand = NewBikeBrand;
                    

                    Console.Write("Enter Price: ");
                    int NewBikePrice = Convert.ToInt32(Console.ReadLine());
                    BMSData.addBikePrice = NewBikePrice;
                    
                    Console.Write("Enter FrameSet: ");
                    string NewBikeFrameSet = Console.ReadLine();
                    BMSData.addBikeFrameSet = NewBikeFrameSet;

                    Console.Write("Enter GroupSet: ");
                    string NewBikeGroupSet = Console.ReadLine();
                    BMSData.addBikeGroupSet = NewBikeGroupSet;

                    Console.Write("Enter WheelSet: ");
                    string NewBikeWheelSet = Console.ReadLine();
                    BMSData.addBikeWheelSet = NewBikeWheelSet;

                    Console.WriteLine("Bike Added Successfully");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + BMSData.addBikeBrand);
                    Console.WriteLine("Price: " + BMSData.addBikePrice);
                    Console.WriteLine("FrameSet: " + BMSData.addBikeFrameSet);
                    Console.WriteLine("GroupSet: " + BMSData.addBikeGroupSet);
                    Console.WriteLine("WheelSet: " + BMSData.addBikeWheelSet);
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
                    Console.WriteLine("Price: " + BMSData.mtpPrice);
                    Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                    Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                    Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);


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

                                BMSData.mtpPrice = NewPrice;
                                Console.WriteLine("---------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSData.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                                showMenu();
                                break;
                            case 2:

                                Console.Write("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSData.mtpFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSData.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                                showMenu();
                                break;

                            case 3:

                                Console.Write("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSData.mtpGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSData.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                                showMenu();
                                break;
                            case 4:
                                Console.Write("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSData.mtpWheelset = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSData.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
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
                    Console.WriteLine("Price: " + BMSData.trekPrice);
                    Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                    Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                    Console.WriteLine("Wheelset: " + BMSData.trekWheelset);

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
                                BMSData.trekPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSData.trekPrice);
                                Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                                showMenu();
                                break;
                            case 2:

                                Console.Write("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSData.trekFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSData.trekPrice);
                                Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                                showMenu();
                                break;

                            case 3:

                                Console.Write("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSData.trekGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSData.trekPrice);
                                Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                                showMenu();
                                break;
                            case 4:
                                Console.Write("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSData.trekWheelset = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSData.trekPrice);
                                Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
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
                    Console.WriteLine("Price: " + BMSData.orbeaPrice);
                    Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                    Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                    Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);


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
                                BMSData.orbeaPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSData.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSData.orbeaFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSData.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSData.orbeaGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSData.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSData.orbeaWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSData.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
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
                    Console.WriteLine("Price: " + BMSData.giantPrice);
                    Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                    Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                    Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);

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
                                BMSData.giantPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSData.giantPrice);
                                Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                                showMenu();

                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSData.giantFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSData.giantPrice);
                                Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSData.giantGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSData.giantPrice);
                                Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSData.giantWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSData.giantPrice);
                                Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
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
                    Console.WriteLine("Price: " + BMSData.cerveloPrice);
                    Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                    Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                    Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
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
                                BMSData.cerveloPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSData.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                                showMenu();
                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSData.cerveloFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSData.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSData.cerveloGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSData.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSData.cerveloWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSData.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
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
                    Console.WriteLine("Price: " + BMSData.cannondalePrice);
                    Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                    Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                    Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
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
                                BMSData.cannondalePrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSData.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                                showMenu();

                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSData.cannondaleFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSData.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSData.cannondaleGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSData.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSData.cannondaleWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSData.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
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
            Console.WriteLine("Price: " + BMSData.mtpPrice);
            Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
            Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
            Console.WriteLine("\n");
            Console.WriteLine("Trek");
            Console.WriteLine("Price: " + BMSData.trekPrice);
            Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
            Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
            Console.WriteLine("\n");
            Console.WriteLine("Orbea");
            Console.WriteLine("Price: " + BMSData.orbeaPrice);
            Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
            Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Giant");
            Console.WriteLine("Price: " + BMSData.giantPrice);
            Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
            Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Cervelo");
            Console.WriteLine("Price: " + BMSData.cerveloPrice);
            Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
            Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Cannondale");
            Console.WriteLine("Price: " + BMSData.cannondalePrice);
            Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
            Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine(BMSData.addBikeBrand);
            Console.WriteLine("Price: " + BMSData.addBikePrice);
            Console.WriteLine("Frameset: " + BMSData.addBikeFrameSet);
            Console.WriteLine("Groupset: " + BMSData.addBikeGroupSet);
            Console.WriteLine("Wheelset: " + BMSData.addBikeWheelSet);
          



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
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSData.trekPrice);
                        Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSData.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSData.giantPrice);
                        Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSData.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSData.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                        showMenu();


                        break;
                    case 2:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSData.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSData.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSData.giantPrice);
                        Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSData.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSData.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                        showMenu();

                        break;
                    case 3:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSData.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSData.trekPrice);
                        Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSData.giantPrice);
                        Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSData.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSData.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                        showMenu();


                        break;
                    case 4:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSData.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSData.trekPrice);
                        Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSData.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSData.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSData.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                        showMenu();

                        break;
                    case 5:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSData.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSData.trekPrice);
                        Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSData.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSData.giantPrice);
                        Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSData.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSData.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cannondaleWheelSet);
                        showMenu();
                        break;
                    case 6:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSData.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSData.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSData.trekPrice);
                        Console.WriteLine("Frameset: " + BMSData.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSData.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSData.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSData.giantPrice);
                        Console.WriteLine("Frameset: " + BMSData.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSData.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSData.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSData.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSData.cerveloWheelSet);
                        showMenu();

                        break;
                }
            }
            else
            {
                Console.WriteLine("Thank you!");
                showMenu();
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
