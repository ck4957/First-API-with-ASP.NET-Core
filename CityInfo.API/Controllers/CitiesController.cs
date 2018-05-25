using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace CityInfo.API.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        public CitiesController()
        {
        }

        [HttpGet()]
        public IActionResult GetCities(){
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id){
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(
                    c => c.id == id
            );

            if(cityToReturn == null){
                return NotFound();
            }
            return Ok(cityToReturn);
        }
    }
}
