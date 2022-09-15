//using API_Juntos.Application.Models.Usuario.ExcluirUsuario;
//using API_Juntos.Core.Repositorios;
//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace API_Juntos.Application.UseCases.Usuarios
//{
//    public class ExcluirClienteUseCase : IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse>
//    {
//        private readonly IClienteRepository _repository;
//        private readonly IMapper _mapper;

//        public ExcluirClienteUseCase(IClienteRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        public async Task<ExcluirClienteResponse> ExecuteAsync(ExcluirClienteRequest request)
//        {
//            var usuario = await _repository.ListarPorId(request.IdCliente); //busca pelo id pra saber qual vai deletar
//            //mapeamento???
//            await _repository.Excluir(usuario); //chama no repository o excluir, passando o identificado como parâmetro
//            return new ExcluirClienteResponse(); //só pq tem que retornar algo??? - o response é vazio

//        }
//    }
//}
//*/