using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Core.Entidades;
using FluentValidation;
using System.Collections.Generic;

namespace API_Juntos.Application.Models.Pedidos.InserirPedido
{
    public class InserirPedidoRequest
    {
       // public DateTime DataPedido { get; set; } //COMO ATRIBUIR DATETIME POR MEIO DO SISTEMA??? SERIA NO USE CASE?
        public List<ProdutosDoPedido> ProdutosDoPedido { get; set; }
        public int IdCliente { get; set; }
    }
}

public class InserirPedidoRequestValidator : AbstractValidator<InserirPedidoRequest>
{
    public InserirPedidoRequestValidator()
    {
           RuleFor(r => r.ProdutosDoPedido)
                .NotEmpty()
                .WithMessage("Produtos do pedido não pode ser vazio.")
                .NotNull()
                .WithMessage("Produtos do pedido não pode ser nulo.");
            RuleFor(r => r.IdCliente)
                .NotEmpty()
                .WithMessage("Id do cliente não pode ser vazio.")
                .NotNull()
                .WithMessage("Id do cliente não pode ser nulo.");
    }
}

