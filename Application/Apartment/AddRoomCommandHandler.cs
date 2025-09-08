public class AddRoomCommandHandler
{
    private readonly IRoomRepository _roomRepository;

    public AddRoomCommandHandler(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public void Handle(AddRoomCommand command)
    {
        var room = new Room(0, command.Number, command.Type, command.PricePerNight);
        _roomRepository.Add(room);
    }
}
