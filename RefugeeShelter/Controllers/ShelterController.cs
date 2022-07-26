using Microsoft.AspNetCore.Mvc;
using RefugeeShelter.Data;
using RefugeeShelter.Models;

namespace RefugeeShelter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class SheltersController : ControllerBase
    {
        private readonly ShelterDbContext _context;

        public SheltersController(ShelterDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}", Name = "GetShelter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponse))]
        public ActionResult<Shelter> GetShelter(int id)
        {
            var shelter = _context.Shelters.Find(id);
            if (shelter == null)
            {
                return NotFound(new ErrorResponse(404, "Shelter not found"));
            }
            return Ok(shelter);
        }

        [HttpGet(Name = "GetShelters")]
        public IEnumerable<Shelter> GetShelters()
        {
            return _context.Shelters.ToList();
        }

        [HttpPost(Name = "AddShelter")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public ActionResult<Shelter> Add(Shelter shelter)
        {
            shelter.ShelterId = 0;
            _context.Shelters.Add(shelter);
            _context.SaveChanges();
            return Created(Url.Action(nameof(GetShelter), new {id = shelter.ShelterId}) ?? String.Empty, shelter);
        }

        [HttpPut(Name = "UpdateShelter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
        public ActionResult<Shelter> Update(Shelter shelter)
        {
            _context.Update(shelter);
            _context.SaveChanges();
            return Ok(shelter);
        }

        [HttpDelete("{id}", Name = "DeleteShelter")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponse))]
        public ActionResult Delete(int id)
        {
            var shelter = _context.Shelters.Find(id);
            if (shelter == null)
            {
                return NotFound(new ErrorResponse(404, "Shelter not found"));
            }
            _context.Remove(shelter);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
