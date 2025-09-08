public class Booking
{
    public int Id { get; private set; }
    public Customer Customer { get; private set; }
    public Room Room { get; private set; }
    public DateRange DateRange { get; private set; }

    public Booking(int id, Customer customer, Room room, DateRange dateRange)
    {
        Id = id;
        Customer = customer;
        Room = room;
        DateRange = dateRange;
    }
}
