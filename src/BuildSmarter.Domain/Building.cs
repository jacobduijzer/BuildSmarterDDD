namespace BuildSmarter.Domain;

public class Building(string name)
{
    public string Name { get; private set; } = name;
    private List<Floor> _floors = new List<Floor>();

    public IReadOnlyList<Floor> Floors => _floors.AsReadOnly();

    public void AddFloor(int number)
    {
        var floorNumber = new FloorNumber(number);
        if (_floors.Any(f => f.FloorNumber.Equals(floorNumber)))
            throw new InvalidOperationException("Floor number already exists in this building.");
        
        _floors.Add(new Floor(floorNumber));
    }

    public void AddRoomToFloor(int number, string roomName)
    {
        var floor = _floors.SingleOrDefault(f => f.FloorNumber.Equals((FloorNumber)number));
        if (floor == null)
            throw new InvalidOperationException("Floor does not exist.");
        
        floor.AddRoom(roomName);
    }
}