using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class ClienteRanking
    {
        public int Id { get; set; }
        public int Ranking { get; set; }
        [Required]
        public DateTime DataCalculo { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public ClienteRanking()
        {

        }

        public ClienteRanking(int id, int ranking, DateTime dataCalculo, Cliente cliente)
        {
            Id = id;
            Ranking = ranking;
            DataCalculo = dataCalculo;
            Cliente = cliente;
        }


    }
}
