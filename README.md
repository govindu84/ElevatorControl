# Elevator Control

## Scenarios

Provide an API over http, that is used by multiple teams to control an elevator:

- A person requests an elevator be sent to their current floor
- A person requests that they be brought to a floor
- An elevator car requests all floors that it’s current passengers are servicing (e.g. to light up the buttons that show which floors the car is going to)
- An elevator car requests the next floor it needs to service

## Build/run

- To Run from the root of the project run, `dotnet run --project .\AIM.ElevatorControl.API\AIM.ElevatorControl.API.csproj` will run at port 8080 through the appsettings.json configuration.

Accepted calls:
- GET http://localhost:8080/API/Elevator/all
- PUT http://localhost:8080/api/elevator/put?floor={N}
- POST http://localhost:8080/API/Elevator/next

# Questions

- Assuemed only 5 floors available, we should change that dynamically. 
- We should secure the app by adding authentication.
