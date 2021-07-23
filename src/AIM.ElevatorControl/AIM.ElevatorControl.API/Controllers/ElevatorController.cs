using AIM.ElevatorControl.API.Elevator.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AIM.ElevatorControl.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElevatorController : ControllerBase
    {

        private readonly ILogger<ElevatorController> _logger;
        private readonly IElevator _elevator;

        public ElevatorController(ILogger<ElevatorController> logger, IElevator elevator)
        {
            _logger = logger;
            _elevator = elevator;
        }

        /// <summary>
        /// Get all assigned floor requests.
        /// </summary>
        /// <returns>List of floor request</returns>
        [HttpGet]
        public IEnumerable<int> GetAllFloorRequests()
        {
            return _elevator.GetAllFloorRequests();
        }

        /// <summary>
        /// Assign floor request to elevator control.
        /// </summary>
        /// <param name="floor">floor number</param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult AssignFloorRequest(int floor)
        {
            try
            {
                _logger.LogInformation("Assigning floor request started " + floor);
                _elevator.AssignFloorRequest(floor);
            }
            catch (IndexOutOfRangeException ex)
            {
                _logger.LogError("Incorrect floor" + ex.Message);
                return BadRequest("Incorrect floor");
            }
            catch (Exception ex)
            {
                _logger.LogError("Incorrect floor" + ex.Message);
                return BadRequest("Incorrect floor");
            }
            _logger.LogInformation("Assigning floor request completed." + floor);
            return Ok();
        }

        /// <summary>
        /// Assign next floor request to elevator control.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AssignNextFloor()
        {
            return Ok(_elevator.AssignNextFloor());
        }
    }
}
