namespace BuildSmarter.Domain;

public class FloorNumber
{
    public int Value { get; }

    public FloorNumber(int value)
    {
        if (value < 0)
            throw new ArgumentException("Floor number must be non-negative.", nameof(value));

        Value = value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is FloorNumber other)
        {
            return Value == other.Value;
        }
        return false;
    }

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public static implicit operator int(FloorNumber floorNumber) => floorNumber.Value;
    public static explicit operator FloorNumber(int value) => new (value);
}