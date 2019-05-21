using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Plataforma.Data;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Services
{
    public class ClienteService
    {
        private readonly PlataformaContext _plataformaContext;

        public ClienteService(PlataformaContext plataformaContext)
        {
            _plataformaContext = plataformaContext;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _plataformaContext.Cliente.ToList();
        }

        public IEnumerable<Cliente> GetById(int id)
        {
            return _plataformaContext.Cliente.Where(x => x.Id == id).ToList();
        }

        public IEnumerable<Cliente> GetByEmail(string email)
        {
            return _plataformaContext.Cliente.Where(x => x.Email == email).ToList();
        }

        public Cliente Insert(Cliente obj)
        {
            _plataformaContext.Add(obj);
            _plataformaContext.SaveChangesAsync();
            
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _plataformaContext.Cliente.Find(id);
                _plataformaContext.Cliente.Remove(obj);
                _plataformaContext.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Can't delete cliente");
            }
        }

        public void UpdateAsync(Cliente obj)
        {
            bool hasAny = _plataformaContext.Cliente.Any(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new Exception("Id not found");
            }
            try
            {
                _plataformaContext.Update(obj);
                _plataformaContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }
    }
}
