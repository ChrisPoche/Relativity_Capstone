using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelativityCapstone.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RelativityCapstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly AirportContext _context;

        public AirportController(AirportContext context)
        {
            _context = context;
        }

        // GET api/airport
        [HttpGet]
        public ActionResult<Airport> Get()
        {
            var allAirports = _context.Airports;
            Console.WriteLine("HERE IS THE QUERY");
            
            
            return new JsonResult(allAirports);
        }

        // GET api/airport/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {

            return "values";
        }

        // POST api/airport
        [HttpPost]
        public ActionResult newAirport()
        {


            Airport newAirport = new Airport();
            // newAirport.city = "Chicago";
            // newAirport.country = "United States";
            // newAirport.lastUpdated = DateTime.Now;
            // newAirport.latitude = 42.990299224853516;
            // newAirport.longitude = -96.06279754638672;
            // newAirport.name = "Chicago O'Hare International Airport";
            // _context.Add(newAirport);
            // _context.SaveChanges();

            return new JsonResult(newAirport);

        }

        // PUT api/airport/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/airport/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
