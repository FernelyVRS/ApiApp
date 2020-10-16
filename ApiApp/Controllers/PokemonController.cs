using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiApp.Request;

namespace ApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Solicitud soli = new Solicitud();
            object soli2 = soli.Respuesta();
            return Ok(soli2);
        }
    }
}
