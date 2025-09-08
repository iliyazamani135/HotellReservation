public interface IRoomRepository
{
    Room GetById(int id);
    void Add(Room room);
    void Update(Room room);
}
