using Microsoft.EntityFrameworkCore;
using Plataforma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plataforma.Data
{
    public class PlataformaContext : DbContext
    {
        public PlataformaContext(DbContextOptions<PlataformaContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ClienteRanking> ClienteRanking { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<PedidoVenda> PedidoVenda { get; set; }
        public DbSet<PedidoVendaLinhas> PedidoVendaLinhas { get; set; }
    }
}
