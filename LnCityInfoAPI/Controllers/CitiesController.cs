using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LnCityInfoAPI.Controllers
{
    [ApiController]
    public class CitiesController : ControllerBase
    {
       public JsonResult GetCities()
        {
            return new JsonResult(
            new List<object>()
            {
                new { id=1, Name = "New York CIty"},
                new { id=2, Name = "Antwerp"}
            });
        }
        
    }
}
