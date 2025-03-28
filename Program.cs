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

            while (!BMSProcess.ValidateAdmin(password))
            {
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
                    BMSProcess.addBikeBrand = NewBikeBrand;


                    Console.Write("Enter Price: ");
                    int NewBikePrice = Convert.ToInt32(Console.ReadLine());
                    BMSProcess.addBikePrice = NewBikePrice;

                    Console.Write("Enter FrameSet: ");
                    string NewBikeFrameSet = Console.ReadLine();
                    BMSProcess.addBikeFrameSet = NewBikeFrameSet;

                    Console.Write("Enter GroupSet: ");
                    string NewBikeGroupSet = Console.ReadLine();
                    BMSProcess.addBikeGroupSet = NewBikeGroupSet;

                    Console.Write("Enter WheelSet: ");
                    string NewBikeWheelSet = Console.ReadLine();
                    BMSProcess.addBikeWheelSet = NewBikeWheelSet;

                    Console.WriteLine("Bike Added Successfully");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Brand: " + BMSProcess.addBikeBrand);
                    Console.WriteLine("Price: " + BMSProcess.addBikePrice);
                    Console.WriteLine("FrameSet: " + BMSProcess.addBikeFrameSet);
                    Console.WriteLine("GroupSet: " + BMSProcess.addBikeGroupSet);
                    Console.WriteLine("WheelSet: " + BMSProcess.addBikeWheelSet);
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
                    Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                    Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                    Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                    Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);


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

                                BMSProcess.mtpPrice = NewPrice;
                                Console.WriteLine("---------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                                showMenu();
                                break;
                            case 2:

                                Console.Write("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSProcess.mtpFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                                showMenu();
                                break;

                            case 3:

                                Console.Write("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSProcess.mtpGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                                showMenu();
                                break;
                            case 4:
                                Console.Write("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSProcess.mtpWheelset = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("MountainPeak");
                                Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
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
                    Console.WriteLine("Price: " + BMSProcess.trekPrice);
                    Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                    Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                    Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);

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
                                BMSProcess.trekPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSProcess.trekPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                                showMenu();
                                break;
                            case 2:

                                Console.Write("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSProcess.trekFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSProcess.trekPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                                showMenu();
                                break;

                            case 3:

                                Console.Write("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSProcess.trekGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSProcess.trekPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                                showMenu();
                                break;
                            case 4:
                                Console.Write("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSProcess.trekWheelset = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Trek");
                                Console.WriteLine("Price: " + BMSProcess.trekPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
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
                    Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                    Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                    Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                    Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);


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
                                BMSProcess.orbeaPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);


                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSProcess.orbeaFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSProcess.orbeaGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSProcess.orbeaWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Orbea");
                                Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
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
                    Console.WriteLine("Price: " + BMSProcess.giantPrice);
                    Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                    Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                    Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);

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
                                BMSProcess.giantPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSProcess.giantPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                                showMenu();

                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSProcess.giantFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSProcess.giantPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSProcess.giantGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSProcess.giantPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSProcess.giantWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Giant");
                                Console.WriteLine("Price: " + BMSProcess.giantPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
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
                    Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                    Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                    Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                    Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
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
                                BMSProcess.cerveloPrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                                showMenu();
                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSProcess.cerveloFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSProcess.cerveloGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSProcess.cerveloWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cervelo");
                                Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
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
                    Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                    Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                    Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                    Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
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
                                BMSProcess.cannondalePrice = NewPrice;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                                showMenu();

                                break;
                            case 2:

                                Console.WriteLine("Enter New Frameset: ");
                                string NewFrameset = Console.ReadLine();
                                BMSProcess.cannondaleFrameSet = NewFrameset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                                showMenu();
                                break;

                            case 3:

                                Console.WriteLine("Enter New GroupSet: ");
                                string NewGroupSet = Console.ReadLine();
                                BMSProcess.cannondaleGroupSet = NewGroupSet;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                                showMenu();
                                break;
                            case 4:
                                Console.WriteLine("Enter New Wheelset: ");
                                string NewWheelset = Console.ReadLine();
                                BMSProcess.cannondaleWheelSet = NewWheelset;
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("Cannondale");
                                Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                                Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                                Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                                Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
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
            Console.WriteLine("Price: " + BMSProcess.mtpPrice);
            Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
            Console.WriteLine("\n");
            Console.WriteLine("Trek");
            Console.WriteLine("Price: " + BMSProcess.trekPrice);
            Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
            Console.WriteLine("\n");
            Console.WriteLine("Orbea");
            Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
            Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Giant");
            Console.WriteLine("Price: " + BMSProcess.giantPrice);
            Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Cervelo");
            Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
            Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine("Cannondale");
            Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
            Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
            Console.WriteLine("\n");
            Console.WriteLine(BMSProcess.addBikeBrand);
            Console.WriteLine("Price: " + BMSProcess.addBikePrice);
            Console.WriteLine("Frameset: " + BMSProcess.addBikeFrameSet);
            Console.WriteLine("Groupset: " + BMSProcess.addBikeGroupSet);
            Console.WriteLine("Wheelset: " + BMSProcess.addBikeWheelSet);




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
                        Console.WriteLine("Price: " + BMSProcess.trekPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSProcess.giantPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                        showMenu();


                        break;
                    case 2:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSProcess.giantPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                        showMenu();

                        break;
                    case 3:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSProcess.trekPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSProcess.giantPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                        showMenu();


                        break;
                    case 4:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSProcess.trekPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                        showMenu();

                        break;
                    case 5:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSProcess.trekPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSProcess.giantPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cannondale");
                        Console.WriteLine("Price: " + BMSProcess.cannondalePrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cannondaleFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cannondaleGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cannondaleWheelSet);
                        showMenu();
                        break;
                    case 6:
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("MountainPeak");
                        Console.WriteLine("Price: " + BMSProcess.mtpPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.mtpFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.mtpGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.mtpWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Trek");
                        Console.WriteLine("Price: " + BMSProcess.trekPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.trekFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.trekGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.trekWheelset);
                        Console.WriteLine("\n");
                        Console.WriteLine("Orbea");
                        Console.WriteLine("Price: " + BMSProcess.orbeaPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.orbeaFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.orbeaGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.orbeaWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Giant");
                        Console.WriteLine("Price: " + BMSProcess.giantPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.giantFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.giantGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.giantWheelSet);
                        Console.WriteLine("\n");
                        Console.WriteLine("Cervelo");
                        Console.WriteLine("Price: " + BMSProcess.cerveloPrice);
                        Console.WriteLine("Frameset: " + BMSProcess.cerveloFrameSet);
                        Console.WriteLine("Groupset: " + BMSProcess.cerveloGroupSet);
                        Console.WriteLine("Wheelset: " + BMSProcess.cerveloWheelSet);
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
