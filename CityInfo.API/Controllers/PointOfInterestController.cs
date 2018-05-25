using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class PointOfInterestController : Controller
    {
        [HttpGet("{cityid}/pointsofinterest")]
        public IActionResult GetPointOfInterest(int cityid){
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.id == cityid);

            if(city == null){
                return NotFound();
            }
            return Ok(city.PointOfInterest);
        }

        [HttpGet("{cityid}/pointsofinterest/{id}")]
        public IActionResult GetPointOfInterest(int cityid, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.id == cityid);

            if (city == null)
            {
                return NotFound();
            }

            var pointOfInterest = city.PointOfInterest.FirstOrDefault(p => p.id == id);
            if(pointOfInterest == null){
                return NotFound();
            }

            return Ok(pointOfInterest);
        }

    }
}
