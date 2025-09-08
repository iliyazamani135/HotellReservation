public class BookingCancelledEvent
{
    public int BookingId { get; }

    public BookingCancelledEvent(int bookingId)
    {
        BookingId = bookingId;
    }
}
