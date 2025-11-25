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
    public class DetalleProductosController : ControllerBase
    {
        private readonly Contexto _context;

        public DetalleProductosController(Contexto context)
        {
            _context = context;
        }

        // GET: api/DetalleProductos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalleProductos>>> GetDetalleProductos()
        {
            return await _context.DetalleProductos.ToListAsync();
        }

        // GET: api/DetalleProductos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DetalleProductos>> GetDetalleProductos(int id)
        {
            var detalleProductos = await _context.DetalleProductos.FindAsync(id);

            if (detalleProductos == null)
            {
                return NotFound();
            }

            return detalleProductos;
        }

        // PUT: api/DetalleProductos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetalleProductos(int id, DetalleProductos detalleProductos)
        {
            if (id != detalleProductos.DetalleId)
            {
                return BadRequest();
            }

            _context.Entry(detalleProductos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalleProductosExists(id))
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

        // POST: api/DetalleProductos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DetalleProductos>> PostDetalleProductos(DetalleProductos detalleProductos)
        {
            _context.DetalleProductos.Add(detalleProductos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalleProductos", new { id = detalleProductos.DetalleId }, detalleProductos);
        }

        // DELETE: api/DetalleProductos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalleProductos(int id)
        {
            var detalleProductos = await _context.DetalleProductos.FindAsync(id);
            if (detalleProductos == null)
            {
                return NotFound();
            }

            _context.DetalleProductos.Remove(detalleProductos);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalleProductosExists(int id)
        {
            return _context.DetalleProductos.Any(e => e.DetalleId == id);
        }
    }
}
