﻿using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class ListarPedidoPorIdUseCase : IUseCaseAsync<ListarPedidoPorIdRequest, ListarPedidoPorIdResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public ListarPedidoPorIdUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarPedidoPorIdResponse> ExecuteAsync(ListarPedidoPorIdRequest request)
        {
            var pedido = await _repository.ListarPorId(request.IdPedido);

            var retorno = (ListarPedidoPorIdResponse)null;
            if (pedido != null)
            {
                retorno = _mapper.Map<ListarPedidoPorIdResponse>(retorno);
            }
            return await Task.FromResult(retorno);
        }
    }
}
