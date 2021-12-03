namespace GroupProject
{
    public class BookingManager
    {
            private int maxBooking;
            private int numBooking;
            private Booking[] BookingList;
        
            public BookingManager(int max)
            {
                maxBooking = max;
                numBooking = 0;
                BookingList = new Booking[maxBooking];
            }
        
            public bool addBooking(int bId, Customer cust, Flight _flight)
            {
                if (numBooking >= maxBooking) { return false; }

                Booking f = new Booking(bId, cust, _flight);
                BookingList[numBooking] = f;
                numBooking++;
                return true;
            }
        
            public int findBooking(int fid)
            {
                for (int x = 0; x < numBooking; x++)
                {
                    if (BookingList[x].get_bId() == fid)
                        return x;
                }
                return -1;
            }

            public Booking GetBooking(int fid)
            {
                int loc = findBooking(fid);
                if (loc == -1)
                {
                    return null;
                }

                return BookingList[loc];
            }

            public string getBookingList()
            {
                string s = "Booking List:";
                for (int x = 0; x < numBooking; x++)
                {
                    s = s + "\n" + BookingList[x].get_bId() + " Customer ID " + BookingList[x].get_cId() + " flight Number " + BookingList[x].get_fn();
                }
                return s;
            }
    }
}