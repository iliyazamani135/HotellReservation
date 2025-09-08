public interface IUserRepository
{
    Customer GetById(int id);
    void Add(Customer customer);
    void Update(Customer customer);
}
