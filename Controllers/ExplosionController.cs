using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{number}")]
        public string Explode(string number)
        {
            if (number)
                return string.Join("", number.Select(c => new String(c, int.Parse(c.ToString()))));
        }
    }
}