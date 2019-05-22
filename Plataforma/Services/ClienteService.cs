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

        public void Insert(Cliente obj)
        {
            _plataformaContext.Add(obj);
            _plataformaContext.SaveChanges();
            
        }

        public void Remove(int id)
        {
            try
            {
                var obj = _plataformaContext.Cliente.Find(id);
                _plataformaContext.Cliente.Remove(obj);
                _plataformaContext.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new Exception("Can't delete cliente");
            }
        }

        public void Update(Cliente obj)
        {
            bool hasAny = _plataformaContext.Cliente.Any(x => x.Id == obj.Id);
            //var hasAny = _plataformaContext.Cliente.Find(id);
            if (!hasAny)
            {
                throw new Exception("Id not found");
            }
            try
            {
                _plataformaContext.Update(obj);
                _plataformaContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }
    }
}
