using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Core.Entidades;
using FluentValidation;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.InserirPedido
{
    public class InserirPedidoRequest
    {
       // public DateTime DataPedido { get; set; } //COMO ATRIBUIR DATETIME POR MEIO DO SISTEMA??? SERIA NO USE CASE?
        public List<ProdutosDoPedido> ProdutosDoPedido { get; set; } //como fazer para inserir os produtos a serem pedidos???
        public int IdCliente { get; set; }
    }
}

