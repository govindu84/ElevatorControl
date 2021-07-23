# Elevator Control

## Scenarios

We need to provide an API over http, that is used by multiple teams to control an elevator:

- A person requests an elevator be sent to their current floor
- A person requests that they be brought to a floor
- An elevator car requests all floors that it’s current passengers are servicing (e.g. to light up the buttons that show which floors the car is going to)
- An elevator car requests the next floor it needs to service


# API Request calls
- To get all Floor details, perform following request. 
    GET http://localhost:8080/api/elevator/GetAllFloorRequests
- Assign floor request to elevator control.
    PUT http://localhost:8080/api/elevator/AssignFloorRequest?floor={N}
-  Assign next floor request to elevator control.
    POST http://localhost:8080/API/Elevator/AssignNextFloor

## Build/run

- If you want to Run from the root of the project run, `dotnet run --project .\AIM.ElevatorControl.API\AIM.ElevatorControl.API.csproj` will run at port 8080.

# Questions

- Assuemed only 5 floors available, we should change that dynamically. 
- We should secure the app by adding authentication.
