namespace BuildSmarter.Domain;

public class Building(string name)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; private set; } = name;
    private List<Floor> _floors = new List<Floor>();

    public IReadOnlyList<Floor> Floors => _floors.AsReadOnly();

    public void AddFloor(int number)
    {
        if (_floors.Any(f => f.Number == number))
            throw new InvalidOperationException("Floor number already exists in this building.");
        
        _floors.Add(new Floor(number));
    }

    public void AddRoomToFloor(int floorNumber, string roomName)
    {
        var floor = _floors.SingleOrDefault(f => f.Number == floorNumber);
        if (floor == null)
            throw new InvalidOperationException("Floor does not exist.");
        
        floor.AddRoom(roomName);
    }
}