using AIM.ElevatorControl.API.Elevator.Interfaces;
using System.Collections.Generic;

namespace AIM.ElevatorControl.API.Elevator
{
    public class Elevator : IElevator
    {
        // Assuming we have 5 floors.
        private readonly int[] floors = new int[5];

        /// <summary>
        /// Return all assigned floor requests.
        /// </summary>
        /// <returns>List of floor requests.</returns>
        public int[] GetAllFloorRequests()
        {
            var result = new List<int>();

            for (int i = 0; i < floors.Length; ++i)
            {
                if (floors[i] != 0)
                    result.Add(i);
            }
            return result.ToArray();
        }

        /// <summary>
        /// Assign individual floor request.
        /// </summary>
        /// <param name="floor">floor number</param>
        /// <param name="direction"></param>
        public void AssignFloorRequest(int floor)
        {            
            floors[floor] = 1;
        }

        /// <summary>
        /// Assigning next floor request.
        /// </summary>
        /// <returns></returns>
        public int? AssignNextFloor()
        {
            int? result = null;
            for (int i = 0; i < floors.Length; ++i)
            {
                if (floors[i] != 0)
                {
                    floors[i] = 0;
                    result = i;
                    break;
                }
            }
            return result;
        }

    }
}
