public class ReserveBookingHandler
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IRoomRepository _roomRepository;

    public ReserveBookingHandler(IBookingRepository bookingRepository, IRoomRepository roomRepository)
    {
        _bookingRepository = bookingRepository;
        _roomRepository = roomRepository;
    }

    public void Handle(ReserveBookingCommand command)
    {
        var room = _roomRepository.GetById(command.RoomId);
        if (!room.IsAvailable)
            throw new InvalidOperationException("Room is not available");

        var booking = new Booking(0, new Customer(command.CustomerId, "Name", "email@example.com"),
                                  room, new DateRange(command.StartDate, command.EndDate));

        room.Book(); // تغییر وضعیت اتاق
        _bookingRepository.Add(booking);
    }
}
