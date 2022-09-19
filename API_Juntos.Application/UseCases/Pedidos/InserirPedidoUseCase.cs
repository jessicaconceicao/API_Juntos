using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Validations;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class InserirPedidoUseCase : IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public InserirPedidoUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<InserirPedidoResponse> ExecuteAsync(InserirPedidoRequest request)
        {
            var validator = new InserirPedidoRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErros = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErros += error.ErrorMessage + " | ";

                throw new Exception(validatorErros);
            }

            if (request == null)
            { return null; }

            var pedido = _mapper.Map<Pedido>(request);

            await _repository.Inserir(pedido); //COMO ATRIBUIR DATETIME.NOW?????/
            pedido.DataPedido = DateTime.Now;

            var pedidoResponse = new InserirPedidoResponse();
            pedidoResponse.Messagem = "Pedido inserido com sucesso!";
            return pedidoResponse;

        }
        
    }
}
