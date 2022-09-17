using API_Juntos.Application.Models.Cliente.ListarClientePorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Clientes
{
    public class ListarClientePorIdUseCase : IUseCaseAsync<ListarClientePorIdRequest, ListarClientePorIdResponse>
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ListarClientePorIdUseCase(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarClientePorIdResponse> ExecuteAsync(ListarClientePorIdRequest request)
        {
            var cliente = await _repository.ListarPorId(request.IdCliente);

            var retorno = (ListarClientePorIdResponse)null; 
            
            if (cliente != null)
            {
                retorno = _mapper.Map<ListarClientePorIdResponse>(retorno);
            }

            return await Task.FromResult(retorno);
        }
    }
}
