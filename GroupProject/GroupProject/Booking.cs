namespace GroupProject
{
    public class Booking
    {
        private int bId;
        private Customer cust;
        private Flight _flight;

        public Booking(int bId, Customer cust, Flight _flight)
        {
            this.bId = bId;
            this.cust = cust;
            this._flight = _flight;
        }
        public int get_bId()
        {
            return bId;
        }

        public int get_cId()
        {
            return cust.getId();
        }

        public int get_fn()
        {
            return _flight.getFlightNumber();
        }
        
        public string toString()
        {
            string s = "Booking ";
            s = s + "\nBooking ID: "+ bId;
            s = s + "\nCustomer ID: "+ cust.getId();
            s = s + "\nFlight Number: "+ _flight.getFlightNumber();
            return s;
        }
    }
}