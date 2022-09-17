using System;
using System.Collections.Generic;

namespace API_Juntos.Core.Entidades
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public List<ProdutosDoPedido> ProdutosDoPedido { get; set; } 
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
            
    }
}
