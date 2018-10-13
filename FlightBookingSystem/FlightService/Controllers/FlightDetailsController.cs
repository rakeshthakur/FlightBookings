using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightService.Models;
using FlightService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDetailsController : ControllerBase
    {
        private IRepository<FlightDetails> _flightDetails;

        private IRepository<FlightSchedules> _flightSchedule;

        public FlightDetailsController(IRepository<FlightDetails> flightDetails, IRepository<FlightSchedules> flightSchedule)
        {
            _flightDetails = flightDetails;
            _flightSchedule = flightSchedule;
        }
        [HttpGet("", Name ="ListFlights")]
        public IEnumerable<FlightDetails> GetAllFlights()
        {
            return _flightDetails.GetAll();
            
        }

        [HttpPost]
        public async Task<ActionResult<FlightDetails>> AddFlights(FlightDetails flightDetails)
        {
            var result = await _flightDetails.AddAsync(flightDetails);
            return CreatedAtAction("GetFlightByID", new { id = result.Id }, result);
        }

        [HttpGet("{id:int?}",Name ="GetFlightsByID")]
        public async Task<ActionResult<FlightDetails>> GetFlightByID(int id)
        {
            var result = await _flightDetails.GetByIdAsync(id);
            if (result != null)
            {
                return result;
            }
            else
                return result;
        }

        [HttpDelete("{id:int?}", Name = "GetFlightsByID")]
        public async Task<ActionResult<FlightDetails>> DeleteFlight(int id)
        {
            var result = await _flightDetails.DeleteAync(id);
            if (result == null)
                return NotFound();
            return result;
        }

        [HttpPut("{id:int}", Name = "UpdateFlight")]
        public async Task<ActionResult<FlightDetails>> UpdateFlight(int? id, FlightDetails flightDetails)
        {
            if (id == null) return BadRequest();
            if (id.Value != flightDetails.Id) return NotFound();
            var item = await this._flightDetails.UpdateAsync(id.Value, flightDetails);
            if (item == null)
                return NotFound();
            return item;
        }

        [HttpGet]
        [Route("{Source}/{Destination}/{DepartureDateTime}")]
        public IEnumerable<FlightSchedules> GetByFiltersAsync(string Source, string Destination, DateTime DepartureDateTime)
        {

            var schedule = _flightSchedule.GetAll();
            var flight = _flightDetails.GetAll();
            if (schedule != null)
            {
                var result = schedule.Where(x => x.Source.ToLower() == Source.ToLower() && x.Destination.ToLower() == Destination.ToLower() && x.DepartureDateTime.ToString("MM/dd/yyyy") == DepartureDateTime.ToString("MM/dd/yyyy"));
                return result;
            }
            else
                return null;
        }

    }
}