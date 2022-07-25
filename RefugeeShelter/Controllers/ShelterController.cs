using Microsoft.AspNetCore.Mvc;
using RefugeeShelter.Models;

namespace RefugeeShelter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SheltersController : ControllerBase
    {
        [HttpGet(Name = "GetShelters")]
        public IEnumerable<Shelter> Get()
        {
            var shelters = new List<Shelter>
            {
                new Shelter
                {
                    ShelterId = 1,
                    ShelterName = "Pokój dwuosobowy",
                    Address = "Asdf 13",
                    City = "Rzeszów",
                    Latitude = 23.456,
                    Longitude = 14.569
                }
            };
            return shelters;
        }
    }
}
