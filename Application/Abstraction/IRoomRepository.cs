public interface IRoomRepository
{
    Room GetById(int id);
    IEnumerable<Room> GetAll();
    void Add(Room room);
    void Update(Room room);
}
