using BuildSmarter.Domain;
using Reqnroll;

namespace BuildSmarter.Specs;

[Binding]
public class ManageBuildingStructure(ScenarioContext scenarioContext, Building building)
{
    private ScenarioContext _scenarioContext = scenarioContext;
    private Building _building;

    [Given(@"a building named ""(.*)""")]
    public void GivenABuildingNamed(string buildingName)
    {
        _building = new Building(buildingName);
    }

    [Given(@"a floor with number (.*) exists in the building")]
    public void GivenAFloorWithNumberExistsInTheBuilding(int floorNumber)
    {
        _building.AddFloor(floorNumber);
    }

    [When(@"I add a floor with number (.*) to the building")]
    public void WhenIAddAFloorWithNumberToTheBuilding(int floorNumber)
    {
        _building.AddFloor(floorNumber);
    }

    [When(@"I try to add a floor with number (.*) to the building")]
    public void WhenITryToAddAFloorWithNumberToTheBuilding(int floorNumber)
    {
        try
        {
            _building.AddFloor(floorNumber);
        }
        catch (InvalidOperationException ex)
        {
            _scenarioContext["ErrorMessage"] = ex.Message;
        }
    }

    [Given(@"a room named ""(.*)"" exists on floor (.*)")]
    [When(@"I add a room named ""(.*)"" to floor (.*)")]
    public void WhenIAddARoomNamedToFloor(string roomName, int floorNumber)
    {
        _building.AddRoomToFloor(floorNumber, roomName);
    }

    [When(@"I try to add a room named ""(.*)"" to floor (.*)")]
    public void WhenITryToAddARoomNamedToFloor(string roomName, int floorNumber)
    {
        try
        {
            _building.AddRoomToFloor(floorNumber, roomName);
        }
        catch (InvalidOperationException ex)
        {
            _scenarioContext["ErrorMessage"] = ex.Message;
        }
    }

    [Then(@"the building should have (.*) floor with number (.*)")]
    public void ThenTheBuildingShouldHaveFloorWithNumber(int numberOfFloors, int floorNumber)
    {
        Assert.Equal(numberOfFloors, _building.Floors.Count);
    }


    [Then(@"I should see an error message ""(.*)""")]
    public void ThenIShouldSeeAnErrorMessage(string errorMessage)
    {
        Assert.True(_scenarioContext["ErrorMessage"] != null &&
                    _scenarioContext["ErrorMessage"].ToString()!.Equals(errorMessage));
    }

    [Then(@"floor (.*) should have a room named ""(.*)""")]
    public void ThenFloorShouldHaveARoomNamed(int number, string roomName)
    {
        Assert.Contains(_building.Floors, f => 
            f.FloorNumber.Equals((FloorNumber)number) && 
            f.Rooms.Any(r => r.Name == roomName));
    }

    [When(@"I view the details of the building")]
    public void WhenIViewTheDetailsOfTheBuilding()
    {
        // EMPTY ON PURPOSE
    }

    [Then(@"I should see the following structure:")]
    public void ThenIShouldSeeTheFollowingStructure(Table table)
    {
        var buildingStructure = table.CreateSet<BuildingStructure>();
        foreach (var structure in buildingStructure)
        {
            var floor = _building.Floors.FirstOrDefault(f => 
                f.FloorNumber.Equals((FloorNumber)structure.FloorNumber));
            Assert.NotNull(floor);

            if (string.IsNullOrEmpty(structure.Rooms))
            {
                Assert.Empty(floor.Rooms);
            }
            else
            {
                foreach (var roomName in structure.Rooms.Split(',').Select(r => r.Trim()))
                {
                    if (!string.IsNullOrEmpty(roomName))
                    {
                        Assert.Contains(floor.Rooms, r => r.Name == roomName);
                    }
                }
            }
        }
    }

    private class BuildingStructure
    {
        public int FloorNumber { get; set; }
        public string Rooms { get; set; }
    }
}