using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieCharacterWebAPIProject.Data;
using MovieCharacterWebAPIProject.DTO;
using MovieCharacterWebAPIProject.Models;

namespace MovieCharacterWebAPIProject.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCharacterController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MovieCharacterController(AppDbContext context)
        {
            _context = context;   
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> CreateCharacter(charactercreateDTO request)
        {
            var newcharacter = new Character
            {
                Name = request.Name
            };
            var backpack = new Backpack
            {
                Description = request.Backpackcreate.Description,
                character = newcharacter
            };
            newcharacter.backpack = backpack;
            var weapons = request.weapon.Select(w => new weaponcreateDTO
            {
                Name= w.Name
            });
            var faction = request.factions.Select(f => new factioncreateDTO
            {
                Name = f.Name
               
            });

            _context.Characters.Add(newcharacter);
            await _context.SaveChangesAsync();
            return Ok(await _context.Characters.Include(c => c.backpack).Include(w => w.weapon).Include(f => f.faction).ToListAsync());
            

        }
    }
}
