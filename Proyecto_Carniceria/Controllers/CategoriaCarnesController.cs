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
    public class CategoriaCarnesController : ControllerBase
    {
        private readonly Contexto _context;

        public CategoriaCarnesController(Contexto context)
        {
            _context = context;
        }

        // GET: api/CategoriaCarnes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaCarnes>>> GetCategoriaCarnes()
        {
            return await _context.CategoriaCarnes.ToListAsync();
        }

        // GET: api/CategoriaCarnes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaCarnes>> GetCategoriaCarnes(int id)
        {
            var categoriaCarnes = await _context.CategoriaCarnes.FindAsync(id);

            if (categoriaCarnes == null)
            {
                return NotFound();
            }

            return categoriaCarnes;
        }

        // PUT: api/CategoriaCarnes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaCarnes(int id, CategoriaCarnes categoriaCarnes)
        {
            if (id != categoriaCarnes.CategoriaCarnesId)
            {
                return BadRequest();
            }

            _context.Entry(categoriaCarnes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaCarnesExists(id))
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

        // POST: api/CategoriaCarnes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoriaCarnes>> PostCategoriaCarnes(CategoriaCarnes categoriaCarnes)
        {
            _context.CategoriaCarnes.Add(categoriaCarnes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoriaCarnes", new { id = categoriaCarnes.CategoriaCarnesId }, categoriaCarnes);
        }

        // DELETE: api/CategoriaCarnes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoriaCarnes(int id)
        {
            var categoriaCarnes = await _context.CategoriaCarnes.FindAsync(id);
            if (categoriaCarnes == null)
            {
                return NotFound();
            }

            _context.CategoriaCarnes.Remove(categoriaCarnes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoriaCarnesExists(int id)
        {
            return _context.CategoriaCarnes.Any(e => e.CategoriaCarnesId == id);
        }
    }
}
