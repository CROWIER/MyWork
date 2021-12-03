using GroupProject;

public class AirlineCoordinator
{
    FlightManager flManager;
    CustomerManager custManager; 
    BookingManager BookManager;

    public AirlineCoordinator(int custIdSeed, int maxCust, int maxFlights, int maxBooks)
    {
        flManager = new FlightManager(maxFlights);
        custManager = new CustomerManager(maxCust);
        BookManager = new BookingManager(maxBooks);
    }

    public bool addFlight(int flightNo,string origin,string destination, int maxSeats)
    {
        return flManager.addFlight(flightNo, origin, destination, maxSeats);
    }

    public bool addCustomer(int cId,string fname,string lname, string ph)
    {
        return custManager.addCustomer(cId, fname, lname, ph);
    }
    
    
    public bool addBooking(int bId, int cId, int fNumber)
    {
        Customer customer = custManager.GetCustomer(cId);
        Flight flight = flManager.getFlight(fNumber);
        
        return BookManager.addBooking(bId, customer, flight);
    }

    
    public string bookList()
    {
        return BookManager.getBookingList();
    }
    
    public string flightList()
    {
        return flManager.getFlightList();
    }

    public string customerList()
    {
        return custManager.getCustomerList();
    }
    
    public bool CustomerExists(int cId)
    {
        return custManager.customerExists(cId);
    }
    
    public bool FlightExists(int fn)
    {
        return flManager.flightExists(fn);
    }
    
    public bool deleteCustomer(int cId)
    {
        return custManager.deleteCustomer(cId);
    }
    
    public bool deleteFlight(int fid)
    {
        return flManager.deleteFlight(fid);
    }
}