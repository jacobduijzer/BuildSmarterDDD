Feature: Manage Multiple Buildings
As a building administrator
I want to manage multiple buildings
So that I can keep track of different buildings and their structures

    Scenario: Adding multiple buildings
        Given a building named "Empire State Building"
        And a building named "Chrysler Building"
        When I add a floor with number 1 to "Empire State Building"
        And I add a floor with number 2 to "Chrysler Building"
        Then "Empire State Building" should have 1 floor with number 1
        And "Chrysler Building" should have 1 floor with number 2

    Scenario: Retrieving a building by name
        Given a building named "Empire State Building"
        And a building named "Chrysler Building"
        When I retrieve the building named "Empire State Building"
        Then the building should be "Empire State Building"

    Scenario: Deleting a building
        Given a building named "Empire State Building"
        And a building named "Chrysler Building"
        When I delete the building named "Empire State Building"
        Then the building named "Empire State Building" should not exist
        And the building named "Chrysler Building" should exist