using API_Juntos.Application.Models.Cliente.InserirCliente;
using FluentValidation;

namespace API_Juntos.Application.Models.Cliente.InserirCliente
{
    public class InserirClienteRequest
    {
        public string Nome { get; set; }
        public string CPF { get; set; } 
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}

public class InserirClienteRequestValidator : AbstractValidator<InserirClienteRequest>
{
    public InserirClienteRequestValidator()
    {
        RuleFor(r => r.Nome)
            .NotEmpty()
            .WithMessage("Nome não pode ser vazio.")
            .NotNull()
            .WithMessage("Nome não pode ser nulo.");
        RuleFor(r => r.CPF)
            .NotEmpty()
            .WithMessage("CPF não pode ser vazio.")
            .NotNull()
            .WithMessage("CPF não pode ser nulo.");
        RuleFor(r => r.Email)
            .NotEmpty()
            .WithMessage("Email não pode ser vazio.")
            .NotNull()
            .WithMessage("Email não pode ser nulo.");
        RuleFor(r => r.Telefone)
            .NotEmpty()
            .WithMessage("Telefone não pode ser vazio.")
            .NotNull()
            .WithMessage("Telefone não pode ser nulo.");
        RuleFor(r => r.Endereco)
            .NotEmpty()
            .WithMessage("Endereço não pode ser vazio.")
            .NotNull()
            .WithMessage("Endereço não pode ser nulo.");
    }
}
