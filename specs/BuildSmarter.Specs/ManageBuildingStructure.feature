Feature: Manage Building Structure
As a building administrator
I want to manage the floors and rooms within a building
So that the building's structure is consistent and rooms are correctly organized

    Scenario: Adding a new floor to a building
        Given a building named "Empire State Building"
        When I add a floor with number 1 to the building
        Then the building should have 1 floor with number 1

    Scenario: Adding a duplicate floor to a building
        Given a building named "Empire State Building"
        And a floor with number 1 exists in the building
        When I try to add a floor with number 1 to the building
        Then I should see an error message "Floor number already exists in this building."

    Scenario: Adding a room to an existing floor
        Given a building named "Empire State Building"
        And a floor with number 1 exists in the building
        When I add a room named "Conference Room A" to floor 1
        Then floor 1 should have a room named "Conference Room A"

    Scenario: Adding a room to a non-existent floor
        Given a building named "Empire State Building"
        When I try to add a room named "Conference Room A" to floor 2
        Then I should see an error message "Floor does not exist."

    Scenario: Adding a duplicate room to a floor
        Given a building named "Empire State Building"
        And a floor with number 1 exists in the building
        And a room named "Lobby" exists on floor 1
        When I try to add a room named "Lobby" to floor 1
        Then I should see an error message "Room already exists on this floor."

    Scenario: Viewing building details with floors and rooms
        Given a building named "Empire State Building"
        And a floor with number 1 exists in the building
        And a room named "Lobby" exists on floor 1
        And a room named "Conference Room A" exists on floor 1
        And a floor with number 2 exists in the building
        When I view the details of the building
        Then I should see the following structure:
          | Floor Number | Rooms                    |
          | 1            | Lobby, Conference Room A |
          | 2            |                          |
          
    Scenario: Adding a new floor raises a domain event
        Given a building named "Empire State Building"
        When I add a floor with number 1 to the building
        Then a "FloorAddedEvent" should be raised with floor number 1