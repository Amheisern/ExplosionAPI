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
            int num = 0;
            if (!int.TryParse(number, out num))
            {
                return "That is not an number";
            }
            else
            {
                //return string.Join("", number.Select(character => new String(character, int.Parse(character.ToString()))));
                return string.Join("", number.Select(character => new String(character, int.Parse(character.ToString()))));
            }
        }
    }
}