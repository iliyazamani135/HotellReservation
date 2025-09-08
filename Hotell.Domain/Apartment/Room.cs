public class Room
{
    public int Id { get; private set; }
    public string Number { get; private set; }
    public RoomType Type { get; private set; }
    public decimal PricePerNight { get; private set; }
    public bool IsAvailable { get; private set; } = true;

    public Room(int id, string number, RoomType type, decimal pricePerNight)
    {
        Id = id;
        Number = number;
        Type = type;
        PricePerNight = pricePerNight;
    }

    public void Book()
    {
        if (!IsAvailable)
            throw new InvalidOperationException("Room is already booked.");
        IsAvailable = false;
    }

    public void Free() => IsAvailable = true;
}
