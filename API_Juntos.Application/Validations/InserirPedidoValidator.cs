using API_Juntos.Application.Models.Pedidos.InserirPedido;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Validations
{

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

}
