using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Descrição { get; set; }
        public double PrecoUnitario { get; set; }
        public int QtdEstoque { get; set; }

        public Item()
        {

        }

        public Item(int id, string descrição, double precoUnitario, int qtdEstoque)
        {
            Id = id;
            Descrição = descrição;
            PrecoUnitario = precoUnitario;
            QtdEstoque = qtdEstoque;
        }
    }
}
