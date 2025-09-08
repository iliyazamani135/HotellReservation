public class GetBookingHandler
{
    private readonly IBookingRepository _bookingRepository;

    public GetBookingHandler(IBookingRepository bookingRepository)
    {
        _bookingRepository = bookingRepository;
    }

    public Booking Handle(GetBookingQuery query)
    {
        return _bookingRepository.GetById(query.BookingId);
    }
}
