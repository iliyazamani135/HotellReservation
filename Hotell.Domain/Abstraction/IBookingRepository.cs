public interface IBookingRepository
{
    Booking GetById(int id);
    void Add(Booking booking);
    void Update(Booking booking);
}
