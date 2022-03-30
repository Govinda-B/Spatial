using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;

namespace Spatial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public CityController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> PostCity(CityCreateDto cityDto)
        {
            City2 city = new City2()
            {
                CityName = cityDto.CityName,
                Location = new Point(cityDto.Longitude, cityDto.Latitude) { SRID=4326}
            };
            _context.Cities2.Add(city);
            await _context.SaveChangesAsync();

            return Ok();
        }

        

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetCity(int id)
        {
            var city = await _context.Cities2.FindAsync(id);

            if (city == null)
            {
                return NotFound();
            }
            CityDto cityDto = new CityDto
            {
                CityID = city.CityID,
                CityName = city.CityName,
                Longitude = city.Location.X,
                Latitude = city.Location.Y
            };
            return Ok(cityDto);
        }
    }
}
