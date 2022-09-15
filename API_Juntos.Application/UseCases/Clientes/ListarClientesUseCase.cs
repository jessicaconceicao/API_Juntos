//using API_Juntos.Application.Models.Usuario.ListarUsuario;
//using API_Juntos.Application.Models.Usuario.ListarUsuarios;
//using API_Juntos.Core.Repositorios;
//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace API_Juntos.Application.UseCases.Usuarios
//{
//    public class ListarClientesUseCase : IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>>
//    {
//        private readonly IClienteRepository _repository;
//        private readonly IMapper _mapper;

//        public ListarClientesUseCase(IClienteRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        public async Task<List<ListarClientesResponse>> ExecuteAsync(ListarClientesRequest request)
//        {
//            var usuarios = await _repository.ListarTodos();
//            var retorno = _mapper.Map<List<ListarClientesResponse>>(usuarios);
//            return retorno;
//        }
//    }
//}
