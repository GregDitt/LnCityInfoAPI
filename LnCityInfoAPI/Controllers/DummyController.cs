using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LnCityInfoAPI.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace LnCityInfoAPI.Controllers
{

    [ApiController]
    [Route("api/testdatabase")]

    public class DummyController : ControllerBase
    {
        public CityInfoContext _ctx { get; }
        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }




        [HttpGet]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
