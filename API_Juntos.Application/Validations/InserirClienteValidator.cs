using API_Juntos.Application.Models.Cliente.InserirCliente;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Validations
{

    public class InserirClienteRequestValidator : AbstractValidator<InserirClienteRequest>
    {
        public InserirClienteRequestValidator()
        {
            RuleFor(r => r.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome deve ser informado.");
            RuleFor(r => r.CPF)
                .NotEmpty()
                .NotNull()
                .WithMessage("CPF deve ser informado.");
            RuleFor(r => r.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email deve ser informado.");
            RuleFor(r => r.Telefone)
                .NotEmpty()
                .NotNull()
                .WithMessage("Telefone deve ser informado.");
            RuleFor(r => r.Endereco)
                .NotEmpty()
                .NotNull()
                .WithMessage("Endereço deve ser informado.");
        }
    }

}
