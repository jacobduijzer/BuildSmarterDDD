namespace BuildSmarter.Domain;

public interface IBuildingRepository
{
    Building ByName(string name);
    void Add(Building building);
    void Update(Building building);
    void Delete(string name);
    void SaveChanges();
}