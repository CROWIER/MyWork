using System;
using System.Linq;

public class Program
    {
        public static int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        
        public static int GenerateRandomBookNo()
        {
            int _min = 100;
            int _max = 999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        
        static AirlineCoordinator aCoord;

        public static void deleteFlight()
        {
            int id;
            Console.Clear();
            Console.WriteLine(aCoord.flightList());
            Console.Write("Please enter a flight id to delete:");
            id = Convert.ToInt32(Console.ReadLine());
            if (aCoord.deleteFlight(id))
            {
                Console.WriteLine("Flight with id {0} deleted..", id);
            }
            else
            {
                Console.WriteLine("Flight with id {0} was not found..", id);
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void makeBooking()
        {
            int bId, cId, fNumber;
            bId = GenerateRandomBookNo();
            Console.Clear();
            Console.WriteLine("-----------Make booking----------");
            Console.Write("Please enter the Customer Id:");
            cId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the flight number");
            fNumber = Convert.ToInt32(Console.ReadLine());
            if (aCoord.CustomerExists(cId) && aCoord.FlightExists(fNumber))
            {
                
                if (aCoord.addBooking(bId, cId, fNumber))
                {
                    Console.WriteLine("Booking was created..");
                }
                else
                {
                    Console.WriteLine("Booking was not created..");
                }
            }
            Console.ReadKey();
        }
        public static void deleteCustomers()
        {   
            int id;
            Console.Clear();
            Console.WriteLine(aCoord.customerList());
            Console.Write("Please enter a flight id to delete:");
            id = Convert.ToInt32(Console.ReadLine());
            if (aCoord.deleteFlight(id))
            {
                Console.WriteLine("Customer with id {0} deleted..", id);
            }
            else
            {
                Console.WriteLine("Flight with id {0} was not found..", id);
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }
        
        public static void viewFlights()
        {
            Console.Clear();
            Console.WriteLine(aCoord.flightList());
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void viewCustomers()
        {
            Console.Clear();
            Console.WriteLine(aCoord.customerList());
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void addFlight(){
            int flightNo,maxSeats;
            string origin, destination;

            Console.Clear();
            Console.WriteLine("-----------Add Flight----------");
            Console.Write("Please enter the flight number:");
            flightNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please the maximum number of seats:");
            maxSeats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the port of Origin:");
            origin = Console.ReadLine();
            Console.Write("Please enter the destination port:");
            destination = Console.ReadLine();
            if(aCoord.addFlight(flightNo, origin, destination, maxSeats))
            {
                Console.WriteLine("Flight successfully added..");
            }
            else
            {
                Console.WriteLine("Flight was not added..");
            }
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }

        public static void addCustomer()
        {
            int cId = GenerateRandomNo();
            string fname, lname, phone;

            Console.Clear();
            Console.WriteLine("-----------Add Customer----------");
            Console.Write("Please enter the first name:");
            fname = Console.ReadLine();
            
            Console.Write("Please enter the last name:");
            lname = Console.ReadLine();
            
            Console.Write("Please enter phone number:");
            phone = Console.ReadLine();
            
            if(aCoord.addCustomer(cId, fname, lname, phone))
            {
                Console.WriteLine("Customer successfully added..");
            }
            
            else
            {
                Console.WriteLine("Customer was not added..");
            }
            
            Console.WriteLine("\nPress any key to continue return to the main menu.");
            Console.ReadKey();
        }
        
        public static void showMainMenu()
        {
            Console.Clear();
            Console.WriteLine("XYZ AirLines Limited.\nPlease select a choice from the menu below:\n");
            Console.WriteLine("1: Add Flight\n2 :Add Customer\n3: View Flights\n4: View Customers");
            Console.WriteLine("5: Delete Customer\n6: Delete Flight");
            Console.WriteLine("7:Exit");
        }

        public static int getValidChoice()
        { int choice;
            showMainMenu();
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 9))
            {
                showMainMenu();
                Console.WriteLine("Please enter a valid choice:");
            }
            return choice;
        }
        public static  void runProgram()
        {
            int choice= getValidChoice();
            while (choice != 9)
            {
                if (choice == 1) { addFlight(); }
                if (choice == 2) { addCustomer(); }
                if (choice == 3) { viewFlights(); }
                if (choice == 4) { viewCustomers(); }
                if (choice == 5) { deleteCustomers(); }
                if (choice == 6) { deleteFlight(); }
                if (choice == 7) { makeBooking(); }
                if (choice == 8) {  }
                choice = getValidChoice();
            }                 
        }

        static void Main(string[] args)
        {
            aCoord = new AirlineCoordinator(100, 30, 30, 900);
            runProgram();
            Console.WriteLine("Thank you for using XYZ Airlines System. Press any key to exit.");
            Console.ReadKey();
        }
    }