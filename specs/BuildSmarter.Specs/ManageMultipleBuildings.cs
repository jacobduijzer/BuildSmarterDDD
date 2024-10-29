using BuildSmarter.Domain;
using BuildSmarter.Infrastructure;
using Reqnroll;

namespace BuildSmarter.Specs;

[Binding]
[Scope(Feature = "Manage Multiple Buildings")]
public class ManageMultipleBuildings(BuildingRepository buildings, ScenarioContext scenarioContext)
{
    [Given(@"a building named ""(.*)""")]
    public void GivenABuildingNamed(string buildingName)
    {
        var building = new Building(buildingName);
        buildings.Add(building);
    }
    
    [When(@"I add a floor with number (.*) to ""(.*)""")]
    public void WhenIAddAFloorWithNumberTo(int number, string buildingName)
    {
        var building = buildings.ByName(buildingName);
        building.AddFloor(number);
        buildings.Update(building);
    }
    
    [When(@"I retrieve the building named ""(.*)""")]
    public void WhenIRetrieveTheBuildingNamed(string buildingName)
    {
        scenarioContext["Building"] = buildings.ByName(buildingName);
    }

    [Then(@"""(.*)"" should have (.*) floor with number (.*)")]
    public void ThenShouldHaveFloorWithNumber(string buildingName, int amount, int room)
    {
        var building = buildings.ByName(buildingName);
        Assert.True(building.Floors.Count(f => f.FloorNumber.Equals((FloorNumber)room)) == amount);
    }


    [Then(@"the building should be ""(.*)""")]
    public void ThenTheBuildingShouldBe(string buildingName)
    {
        Assert.NotNull(scenarioContext["Building"]);
        Assert.True(((Building)scenarioContext["Building"]).Name == buildingName);
    }

    [When(@"I delete the building named ""(.*)""")]
    public void WhenIDeleteTheBuildingNamed(string buildingName)
    {
       buildings.Delete(buildingName);
    }

    [Then(@"the building named ""(.*)"" should not exist")]
    public void ThenTheBuildingNamedShouldNotExist(string buildingName)
    {
        Assert.Null(buildings.ByName(buildingName));
    }

    [Then(@"the building named ""(.*)"" should exist")]
    public void ThenTheBuildingNamedShouldExist(string buildingName)
    {
        Assert.NotNull(buildings.ByName(buildingName));
    }
}