using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma.Data;
using Plataforma.Models;

namespace Plataforma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesRankingControllersController : ControllerBase
    {
        private readonly PlataformaContext _context;

        public ClientesRankingControllersController(PlataformaContext context)
        {
            _context = context;
        }

        // GET: api/ClientesRankingControllers
        [HttpGet]
        public IEnumerable<ClienteRanking> GetClienteRanking()
        {
            return _context.ClienteRanking;
        }

        // GET: api/ClientesRankingControllers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClienteRanking([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clienteRanking = await _context.ClienteRanking.FindAsync(id);

            if (clienteRanking == null)
            {
                return NotFound();
            }

            return Ok(clienteRanking);
        }

        // PUT: api/ClientesRankingControllers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClienteRanking([FromRoute] int id, [FromBody] ClienteRanking clienteRanking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != clienteRanking.Id)
            {
                return BadRequest();
            }

            _context.Entry(clienteRanking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteRankingExists(id))
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

        // POST: api/ClientesRankingControllers
        [HttpPost]
        public async Task<IActionResult> PostClienteRanking([FromBody] ClienteRanking clienteRanking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ClienteRanking.Add(clienteRanking);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClienteRanking", new { id = clienteRanking.Id }, clienteRanking);
        }

        // DELETE: api/ClientesRankingControllers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClienteRanking([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clienteRanking = await _context.ClienteRanking.FindAsync(id);
            if (clienteRanking == null)
            {
                return NotFound();
            }

            _context.ClienteRanking.Remove(clienteRanking);
            await _context.SaveChangesAsync();

            return Ok(clienteRanking);
        }

        private bool ClienteRankingExists(int id)
        {
            return _context.ClienteRanking.Any(e => e.Id == id);
        }
    }
}