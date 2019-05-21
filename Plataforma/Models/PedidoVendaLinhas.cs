using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class PedidoVendaLinhas
    {
        public int Id { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public Item Item { get; set; }
        public int ItemId { get; set; }

        public PedidoVendaLinhas()
        {

        }

        public PedidoVendaLinhas(int id, double precoUnitario, int quantidade, Item item)
        {
            Id = id;
            PrecoUnitario = precoUnitario;
            Quantidade = quantidade;
            Item = item;
        }
    }
}
