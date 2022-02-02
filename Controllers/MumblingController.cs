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
    public class MumblingController : ControllerBase
    {
        [HttpGet("{word}")]
        public string Mumbling(string word)
        {
            int num = 0;
            if (int.TryParse(word, out num))
            {
                return "That is not a word";
            }
            else
            {
                //return string.Join("", number.Select(character => new String(character, int.Parse(character.ToString()))));

                return string.Join("-", word.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
            }
        }
    }
}
// return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));