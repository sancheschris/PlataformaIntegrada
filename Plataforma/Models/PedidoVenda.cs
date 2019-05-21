using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class PedidoVenda
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public double PorcetagemDesconto { get; set; }
        public double ValorTotalPedido { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        public PedidoVenda()
        {

        }

        public PedidoVenda(int id, DateTime dataPedido, DateTime dataEntrega, double porcetagemDesconto, double valorTotalPedido, Cliente cliente)
        {
            Id = id;
            DataPedido = dataPedido;
            DataEntrega = dataEntrega;
            PorcetagemDesconto = porcetagemDesconto;
            ValorTotalPedido = valorTotalPedido;
            Cliente = cliente;
        }
    }
}
