public class Hotel
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Address Address { get; private set; }

    public Hotel(int id, string name, Address address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}
