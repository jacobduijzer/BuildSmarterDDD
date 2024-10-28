namespace BuildSmarter.Domain;

public class Floor(int number)
{
    public int Number { get; private set; } = number;
    private readonly List<Room> _rooms = new List<Room>();

    public IReadOnlyList<Room> Rooms => _rooms.AsReadOnly();

    public void AddRoom(string roomName)
    {
        if (_rooms.Any(r => r.Name == roomName))
            throw new InvalidOperationException("Room already exists on this floor.");
        
        _rooms.Add(new Room(roomName));
    } 
}