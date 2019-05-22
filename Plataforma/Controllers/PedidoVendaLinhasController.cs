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
    public class PedidoVendaLinhasController : ControllerBase
    {
        private readonly PlataformaContext _context;

        public PedidoVendaLinhasController(PlataformaContext context)
        {
            _context = context;
        }

        // GET: api/PedidoVendaLinhas
        [HttpGet]
        public IEnumerable<PedidoVendaLinhas> GetPedidoVendaLinhas()
        {
            return _context.PedidoVendaLinhas;
        }

        // GET: api/PedidoVendaLinhas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedidoVendaLinhas([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pedidoVendaLinhas = await _context.PedidoVendaLinhas.FindAsync(id);

            if (pedidoVendaLinhas == null)
            {
                return NotFound();
            }

            return Ok(pedidoVendaLinhas);
        }

        // PUT: api/PedidoVendaLinhas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedidoVendaLinhas([FromRoute] int id, [FromBody] PedidoVendaLinhas pedidoVendaLinhas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pedidoVendaLinhas.Id)
            {
                return BadRequest();
            }

            _context.Entry(pedidoVendaLinhas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoVendaLinhasExists(id))
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

        // POST: api/PedidoVendaLinhas
        [HttpPost]
        public async Task<IActionResult> PostPedidoVendaLinhas([FromBody] PedidoVendaLinhas pedidoVendaLinhas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PedidoVendaLinhas.Add(pedidoVendaLinhas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedidoVendaLinhas", new { id = pedidoVendaLinhas.Id }, pedidoVendaLinhas);
        }

        // DELETE: api/PedidoVendaLinhas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedidoVendaLinhas([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pedidoVendaLinhas = await _context.PedidoVendaLinhas.FindAsync(id);
            if (pedidoVendaLinhas == null)
            {
                return NotFound();
            }

            _context.PedidoVendaLinhas.Remove(pedidoVendaLinhas);
            await _context.SaveChangesAsync();

            return Ok(pedidoVendaLinhas);
        }

        private bool PedidoVendaLinhasExists(int id)
        {
            return _context.PedidoVendaLinhas.Any(e => e.Id == id);
        }
    }
}