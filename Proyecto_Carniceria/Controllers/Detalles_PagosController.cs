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
    public class Detalles_PagosController : ControllerBase
    {
        private readonly Contexto _context;

        public Detalles_PagosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/Detalles_Pagos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Detalles_Pagos>>> GetDetalles_Pagos()
        {
            return await _context.Detalles_Pagos.ToListAsync();
        }

        // GET: api/Detalles_Pagos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Detalles_Pagos>> GetDetalles_Pagos(int id)
        {
            var detalles_Pagos = await _context.Detalles_Pagos.FindAsync(id);

            if (detalles_Pagos == null)
            {
                return NotFound();
            }

            return detalles_Pagos;
        }

        // PUT: api/Detalles_Pagos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalles_Pagos(int id, Detalles_Pagos detalles_Pagos)
        {
            if (id != detalles_Pagos.DetallePagoId)
            {
                return BadRequest();
            }

            _context.Entry(detalles_Pagos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Detalles_PagosExists(id))
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

        // POST: api/Detalles_Pagos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Detalles_Pagos>> PostDetalles_Pagos(Detalles_Pagos detalles_Pagos)
        {
            _context.Detalles_Pagos.Add(detalles_Pagos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalles_Pagos", new { id = detalles_Pagos.DetallePagoId }, detalles_Pagos);
        }

        // DELETE: api/Detalles_Pagos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalles_Pagos(int id)
        {
            var detalles_Pagos = await _context.Detalles_Pagos.FindAsync(id);
            if (detalles_Pagos == null)
            {
                return NotFound();
            }

            _context.Detalles_Pagos.Remove(detalles_Pagos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Detalles_PagosExists(int id)
        {
            return _context.Detalles_Pagos.Any(e => e.DetallePagoId == id);
        }
    }
}
