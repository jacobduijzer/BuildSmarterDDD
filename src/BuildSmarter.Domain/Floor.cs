namespace BuildSmarter.Domain;

public class Floor(FloorNumber floorNumber)
{
    public FloorNumber FloorNumber => floorNumber;
    private readonly List<Room> _rooms = [];

    public IReadOnlyList<Room> Rooms => _rooms.AsReadOnly();

    public void AddRoom(string roomName)
    {
        if (_rooms.Any(r => r.Name == roomName))
            throw new InvalidOperationException("Room already exists on this floor.");
        
        _rooms.Add(new Room(roomName));
    } 
}