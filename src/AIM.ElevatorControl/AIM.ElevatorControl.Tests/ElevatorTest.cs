using AIM.ElevatorControl.API.Elevator;
using System;
using Xunit;

namespace AIM.ElevatorControl.Tests
{
    public class ElevatorTest
    {
        Elevator elevator;
        public ElevatorTest()
        {
            elevator = new Elevator();
        }

        [Fact]
        public void GetAllFloorRequsted()
        {
            elevator.AssignFloorRequest(1);

            var result = elevator.GetAllFloorRequests();

            Assert.Equal(new int[1] { 1 }, result);
        }


        [Fact]
        public void GetAllFloorRequestWhenEmpty()
        {
            var result = elevator.GetAllFloorRequests();

            Assert.Equal(new int[0], result);
        }
        

        [Fact]
        public void WhenFloorIsWrong()
        {
            void action() => elevator.AssignFloorRequest(200);

            Assert.Throws<IndexOutOfRangeException>(action);
        }

        [Fact]
        public void ReturnNullIfFloorEmpty()
        {

            var result = elevator.AssignNextFloor();

            Assert.Null(result);
        }
    }
}
