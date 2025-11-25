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
    public class CarritoDeComprasController : ControllerBase
    {
        private readonly Contexto _context;

        public CarritoDeComprasController(Contexto context)
        {
            _context = context;
        }

        // GET: api/CarritoDeCompras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarritoDeCompras>>> GetCarritoDeCompras()
        {
            return await _context.CarritoDeCompras.ToListAsync();
        }

        // GET: api/CarritoDeCompras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarritoDeCompras>> GetCarritoDeCompras(int id)
        {
            var carritoDeCompras = await _context.CarritoDeCompras.FindAsync(id);

            if (carritoDeCompras == null)
            {
                return NotFound();
            }

            return carritoDeCompras;
        }

        // PUT: api/CarritoDeCompras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarritoDeCompras(int id, CarritoDeCompras carritoDeCompras)
        {
            if (id != carritoDeCompras.CarritoId)
            {
                return BadRequest();
            }

            _context.Entry(carritoDeCompras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarritoDeComprasExists(id))
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

        // POST: api/CarritoDeCompras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarritoDeCompras>> PostCarritoDeCompras(CarritoDeCompras carritoDeCompras)
        {
            _context.CarritoDeCompras.Add(carritoDeCompras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarritoDeCompras", new { id = carritoDeCompras.CarritoId }, carritoDeCompras);
        }

        // DELETE: api/CarritoDeCompras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarritoDeCompras(int id)
        {
            var carritoDeCompras = await _context.CarritoDeCompras.FindAsync(id);
            if (carritoDeCompras == null)
            {
                return NotFound();
            }

            _context.CarritoDeCompras.Remove(carritoDeCompras);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarritoDeComprasExists(int id)
        {
            return _context.CarritoDeCompras.Any(e => e.CarritoId == id);
        }
    }
}
