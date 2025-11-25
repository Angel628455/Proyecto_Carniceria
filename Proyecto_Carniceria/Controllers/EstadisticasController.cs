using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.Models;
using Proyecto_Carniceria.DAL;

namespace Proyecto_Carniceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadisticasController : ControllerBase
    {
        private readonly Contexto _context;

        public EstadisticasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Estadisticas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estadisticas>>> GetEstadisticas()
        {
            return await _context.Estadisticas.ToListAsync();
        }

        // GET: api/Estadisticas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Estadisticas>> GetEstadisticas(int id)
        {
            var estadisticas = await _context.Estadisticas.FindAsync(id);

            if (estadisticas == null)
            {
                return NotFound();
            }

            return estadisticas;
        }

        // PUT: api/Estadisticas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadisticas(int id, Estadisticas estadisticas)
        {
            if (id != estadisticas.EstadisticaId)
            {
                return BadRequest();
            }

            _context.Entry(estadisticas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadisticasExists(id))
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

        // POST: api/Estadisticas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Estadisticas>> PostEstadisticas(Estadisticas estadisticas)
        {
            _context.Estadisticas.Add(estadisticas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadisticas", new { id = estadisticas.EstadisticaId }, estadisticas);
        }

        // DELETE: api/Estadisticas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadisticas(int id)
        {
            var estadisticas = await _context.Estadisticas.FindAsync(id);
            if (estadisticas == null)
            {
                return NotFound();
            }

            _context.Estadisticas.Remove(estadisticas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadisticasExists(int id)
        {
            return _context.Estadisticas.Any(e => e.EstadisticaId == id);
        }
    }
}
