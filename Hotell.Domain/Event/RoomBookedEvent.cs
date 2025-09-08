public class RoomBookedEvent
{
    public int RoomId { get; }
    public int BookingId { get; }

    public RoomBookedEvent(int roomId, int bookingId)
    {
        RoomId = roomId;
        BookingId = bookingId;
    }
}
