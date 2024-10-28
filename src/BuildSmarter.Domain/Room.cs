namespace BuildSmarter.Domain;

public class Room(string name)
{
    public string Name { get; private set; } = name;
}