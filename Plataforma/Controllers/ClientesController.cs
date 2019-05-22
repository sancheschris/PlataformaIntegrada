using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plataforma.Models;
using Plataforma.Services;

namespace Plataforma.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteService _clienteService;

        public ClientesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET: api/Clientes
        [HttpGet]
        public IEnumerable<Cliente> GetCliente()
        {
            return _clienteService.GetAll();
        }

        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Cliente> GetById(int id)
        {
            return _clienteService.GetById(id);
        }

        // POST: api/Clientes
        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            _clienteService.Insert(cliente);
            return Ok("Record update Successfully");
        }

        // PUT: api/Clientes/5
        [HttpPut]
        public IActionResult Put([FromBody] Cliente cliente)
        {
            _clienteService.Update(cliente);
            return Ok("Update successfully");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}