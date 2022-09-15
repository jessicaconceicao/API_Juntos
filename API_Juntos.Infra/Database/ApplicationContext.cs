using API_Juntos.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
       // public DbSet<Produto> Produtos { get; set; }
        //public DbSet<Pedido> Pedidos { get; set; }
        //public DbSet<ProdutosDoPedido> Produtos_DoPedido { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            //modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            //modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            //modelBuilder.ApplyConfiguration(new ProdutosDoPedidoConfiguration());
        }
    }
}
