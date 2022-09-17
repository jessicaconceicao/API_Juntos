using API_Juntos.Application.Models.Produtos.InserirProduto;
using FluentValidation;

namespace API_Juntos.Application.Models.Produtos.InserirProduto
{
    public class InserirProdutoRequest
    {
        public string Nome { get; set; }
        public string Lote { get; set; }
        public string Validade { get; set; }
        public decimal QuantidadeEmbalagem { get; set; }
        public decimal Valor { get; set; }
        public decimal QuantidadeEstoque { get; set; }
    }
}

public class InserirProdutoRequestValidator : AbstractValidator<InserirProdutoRequest>
{
    public InserirProdutoRequestValidator()
    {
        RuleFor(r => r.Nome)
            .NotEmpty()
            .WithMessage("Nome não pode ser vazio.")
            .NotNull()
            .WithMessage("Nome não pode ser nulo.");
        RuleFor(r => r.Lote)
            .NotEmpty()
            .WithMessage("Lote não pode ser vazio.")
            .NotNull()
            .WithMessage("Lote não pode ser nulo.");
        RuleFor(r => r.Validade)
            .NotEmpty()
            .WithMessage("Validade não pode ser vazia.")
            .NotNull()
            .WithMessage("Validade não pode ser nula.");
        RuleFor(r => r.QuantidadeEmbalagem)
            .NotEmpty()
            .WithMessage("Quantidade da embalagem não pode ser vazia.")
            .NotNull()
            .WithMessage("Quantidade da embalagem não pode ser nula.");
        RuleFor(r => r.Valor)
            .NotEmpty()
            .WithMessage("Valor não pode ser vazio.")
            .NotNull()
            .WithMessage("Valor não pode ser nulo.");
        RuleFor(r => r.QuantidadeEstoque)
            .NotEmpty()
            .WithMessage("Quantidade não pode ser vazia.")
            .NotNull()
            .WithMessage("Quantidade não pode ser nula.");
    }
}
