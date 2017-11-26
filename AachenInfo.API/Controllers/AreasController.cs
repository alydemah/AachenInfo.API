using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AachenInfo.API.Controllers
{
    [Route("api/areas")]
    public class AreasController : Controller
    {
        [HttpGet()]
        public JsonResult GetAreas()
        {
            return new JsonResult(new List<object>()
            {
                new { id=1, Name="Beverau"},
                new { id=2, Name="Bildchen"},
                new { id=3, Name="Burtscheid"},
                new { id=4, Name="Forst"},

            });
        }


    }
}
