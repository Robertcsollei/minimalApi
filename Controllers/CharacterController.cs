using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tutor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {Name = "Sam", Id = 1},
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<Character> AddCharacter(Character newCharacter)
        {
            if (characters.FindIndex(c => c.Id == newCharacter.Id) != -1) return BadRequest("Character already exists.");
            characters.Add(newCharacter);
            return Ok(newCharacter);
        }
    }
}