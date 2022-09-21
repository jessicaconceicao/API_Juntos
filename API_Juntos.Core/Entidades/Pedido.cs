using System;
using System.Collections.Generic;

namespace API_Juntos.Core.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdCliente { get; set; } 
        public Cliente Cliente { get; set; }
        public DateTime Now { get; }
        public List<ProdutosDoPedido> ProdutosDoPedido { get; }

        public Pedido(DateTime dataPedido, List<ProdutosDoPedido> produtosDoPedido, int idCliente)
        {
            DataPedido = dataPedido;
            ProdutosDoPedido = produtosDoPedido;
            IdCliente = idCliente;
        }

        
    }
}
