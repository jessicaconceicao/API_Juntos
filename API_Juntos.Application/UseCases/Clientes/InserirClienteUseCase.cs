//using API_Juntos.Application.Models.InserirUsuario;
//using API_Juntos.Core.Entidades;
//using API_Juntos.Core.Repositorios;
//using AutoMapper;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace API_Juntos.Application.UseCases.Usuarios
//{
//    public class InserirClienteUseCase : IUseCaseAsync<InserirClienteRequest, InserirClienteResponse>
//    {
//        private readonly IClienteRepository _repository;
//        private readonly IMapper _mapper;

//        public InserirClienteUseCase(IClienteRepository repository, IMapper mapper)
//        {
//            _repository = repository;
//            _mapper = mapper;
//        }

//        public async Task<InserirClienteResponse> ExecuteAsync(InserirClienteRequest request)
//        {
//            //validar com o fluent validation?
//            if(request == null)
//            { return null; }

//            var usuario = _mapper.Map<Cliente>(request); //mapeando o que chega do request para Usuário

//            await _repository.Inserir(usuario); //acessa instância do repositório,chamando método Inserir(), passando os dados do mapeamento como parâmetro
//            return new InserirClienteResponse();
//        }
//    }
//}
