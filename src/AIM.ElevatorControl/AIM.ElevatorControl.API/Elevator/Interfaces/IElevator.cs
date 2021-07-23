namespace AIM.ElevatorControl.API.Elevator.Interfaces
{
    public interface IElevator
    {
        public int[] GetAllFloorRequests();
        public void AssignFloorRequest(int floor);
        public int? AssignNextFloor();
    }
}
