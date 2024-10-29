namespace BuildSmarter.Domain;

public class FloorAddedEvent(FloorNumber floorNumber)
{
    public FloorNumber FloorNumber { get; } = floorNumber;
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}
