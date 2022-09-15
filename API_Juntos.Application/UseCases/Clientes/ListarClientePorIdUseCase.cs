//using API_Juntos.Application.Models.Usuario.ListarUsuarioPorId;
//using API_Juntos.Core.Repositorios;
//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace API_Juntos.Application.UseCases.Usuarios
//{
//    public class ListarClientePorIdUseCase : IUseCaseAsync<ListarClientePorIdRequest, ListarClientePorIdResponse>
//    {
//        private readonly IClienteRepository _repository;
//        private readonly IMapper _mapper;

//        public ListarClientePorIdUseCase(IClienteRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        public async Task<ListarClientePorIdResponse> ExecuteAsync(ListarClientePorIdRequest request)
//        {
//            var usuario = await _repository.ListarPorId(request.IdCliente);

//            var retorno = (ListarClientePorIdResponse)null; //POR QUE A ESCRITA É DESSA MANEIRA?
//            if (usuario != null)
//            {
//                retorno = _mapper.Map<ListarClientePorIdResponse>(retorno);
//            }
//            return  await Task.FromResult(retorno);
//        }
//    }
//}
