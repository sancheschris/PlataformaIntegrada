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
    public class PedidoVendasController : ControllerBase
    {
        private readonly PlataformaContext _context;

        public PedidoVendasController(PlataformaContext context)
        {
            _context = context;
        }

        // GET: api/PedidoVendas
        [HttpGet]
        public IEnumerable<PedidoVenda> GetPedidoVenda()
        {
            return _context.PedidoVenda;
        }

        // GET: api/PedidoVendas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPedidoVenda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pedidoVenda = await _context.PedidoVenda.FindAsync(id);

            if (pedidoVenda == null)
            {
                return NotFound();
            }

            return Ok(pedidoVenda);
        }

        // PUT: api/PedidoVendas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedidoVenda([FromRoute] int id, [FromBody] PedidoVenda pedidoVenda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pedidoVenda.Id)
            {
                return BadRequest();
            }

            _context.Entry(pedidoVenda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoVendaExists(id))
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

        // POST: api/PedidoVendas
        [HttpPost]
        public async Task<IActionResult> PostPedidoVenda([FromBody] PedidoVenda pedidoVenda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PedidoVenda.Add(pedidoVenda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedidoVenda", new { id = pedidoVenda.Id }, pedidoVenda);
        }

        // DELETE: api/PedidoVendas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedidoVenda([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pedidoVenda = await _context.PedidoVenda.FindAsync(id);
            if (pedidoVenda == null)
            {
                return NotFound();
            }

            _context.PedidoVenda.Remove(pedidoVenda);
            await _context.SaveChangesAsync();

            return Ok(pedidoVenda);
        }

        private bool PedidoVendaExists(int id)
        {
            return _context.PedidoVenda.Any(e => e.Id == id);
        }
    }
}