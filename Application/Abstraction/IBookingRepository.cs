public interface IBookingRepository
{
    Booking GetById(int id);
    IEnumerable<Booking> GetAll();
    void Add(Booking booking);
    void Update(Booking booking);
}
