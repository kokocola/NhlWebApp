using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lib.Classes;
using NhlDAL;

namespace NhlStatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerStatsController : ControllerBase
    {
        private readonly NhlContext _context;

        public PlayerStatsController(NhlContext context)
        {
            _context = context;
        }

        // GET: api/PlayerStats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerStats>>> GetPlayerStats()
        {
            return await _context.PlayerStats.ToListAsync();
        }

        // GET: api/PlayerStats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerStats>> GetPlayerStats(Guid id)
        {
            var playerStats = await _context.PlayerStats.FindAsync(id);

            if (playerStats == null)
            {
                return NotFound();
            }

            return playerStats;
        }

        // PUT: api/PlayerStats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayerStats(Guid id, PlayerStats playerStats)
        {
            if (id != playerStats.PlayerStatsId)
            {
                return BadRequest();
            }

            _context.Entry(playerStats).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerStatsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PlayerStats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PlayerStats>> PostPlayerStats(PlayerStats playerStats)
        {
            _context.PlayerStats.Add(playerStats);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlayerStats", new { id = playerStats.PlayerStatsId }, playerStats);
        }

        // DELETE: api/PlayerStats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlayerStats(Guid id)
        {
            var playerStats = await _context.PlayerStats.FindAsync(id);
            if (playerStats == null)
            {
                return NotFound();
            }

            _context.PlayerStats.Remove(playerStats);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PlayerStatsExists(Guid id)
        {
            return _context.PlayerStats.Any(e => e.PlayerStatsId == id);
        }
    }
}
