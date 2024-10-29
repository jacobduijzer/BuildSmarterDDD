using System.Collections.Concurrent;
using BuildSmarter.Domain;

namespace BuildSmarter.Infrastructure;

public class BuildingRepository : IBuildingRepository
{
    private readonly ConcurrentDictionary<string, Building> _buildings = new();

    public Building ByName(string name)
    {
        _buildings.TryGetValue(name, out var building);
        return building!;
    }

    public void Add(Building building) =>
        _buildings[building.Name] = building;

    public void Update(Building building) =>
        _buildings[building.Name] = building;

    public void Delete(string name) =>
        _buildings.TryRemove(name, out _);

    public void SaveChanges()
    {
        // In-memory implementation does not require explicit save.
        // Implement this method if using a database.
    }
}