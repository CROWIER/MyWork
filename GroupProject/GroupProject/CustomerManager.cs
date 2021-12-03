public class CustomerManager
{

    private int maxCustomers;
    private int numCustomers;
    private Customer[] CustomerList;

    public CustomerManager(int max)
    {
        maxCustomers = max;
        numCustomers = 0;
        CustomerList = new Customer[maxCustomers];
    }

    public bool addCustomer(int cId,string fname,string lname, string ph)
    {
        if (numCustomers >= maxCustomers) { return false; }
        Customer f = new Customer(cId, fname, lname, ph);
        CustomerList[numCustomers] = f;
        numCustomers++;
        return true;
    }
  
    public int findCustomer(int cid)
    {
        for (int x = 0; x < numCustomers; x++)
        {
            if (CustomerList[x].getId() == cid)
                return x;
        }
        return -1;
    }

    public bool customerExists(int fid)
    {
        int loc = findCustomer(fid);
        if (loc == -1) { return false; }
        return true;
    }
    
    public Customer GetCustomer(int fid)
    {
        int loc = findCustomer(fid);
        if (loc == -1) { return null; }
        return CustomerList[loc];
    }

    public bool deleteCustomer(int fid)
    {
        int loc = findCustomer(fid);
        if (loc == -1) { return false; }
        CustomerList[loc] = CustomerList[numCustomers-1];
        numCustomers--;
        return true;
    }
    
    public string getCustomerList()
    {
        string s = "Customer List:";
        for (int x = 0; x < numCustomers; x++)
        {
            s = s + "\n" + CustomerList[x].getId() + " First Name " + CustomerList[x].getFirstName() + " Last Name " + CustomerList[x].getLastName() + " phone " + CustomerList[x].getPhone() + " Booking " + CustomerList[x].getNumBookings();
        }
        return s;
    }
}