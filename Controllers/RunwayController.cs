using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelativityCapstone.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RelativityCapstone.Brain;

namespace RelativityCapstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunwayController : ControllerBase
    {
        private readonly AirportContext _context;

        public RunwayController(AirportContext context)
        {
            _context = context;
        }

        // GET api/Runway
        [HttpGet]
        public ActionResult<Runway> Get()
        {
            var allRunways = _context.Runways.First();
            Console.WriteLine("HERE IS THE QUERY");
            Console.WriteLine(allRunways);

            
            
            return allRunways;
        }

        // GET api/Runway/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {

            return "values";
        }

        // POST api/Runway
        [HttpPost]
        public ActionResult newRunway()
        {
            
            Runway newRunway = new Runway();
            // int aid = 4;
            // newRunway.airportId = aid;
            // newRunway.headingDeg = 38;
            // newRunway.airport = _context.Airports.Single(a => a.id == aid);
            
            // _context.Add(newRunway);
            // _context.SaveChanges();

            return new JsonResult(newRunway);

        }

        // PUT api/Runway/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Runway/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
