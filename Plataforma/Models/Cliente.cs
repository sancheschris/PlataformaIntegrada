using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string Estado { get; set; }

        public Cliente()
        {

        }

        public Cliente(int id, string email, string senha, string estado)
        {
            Id = id;
            Email = email;
            Senha = senha;
            Estado = estado;
        }
    }
}
