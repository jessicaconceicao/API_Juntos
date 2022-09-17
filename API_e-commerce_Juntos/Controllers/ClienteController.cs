using API_Juntos.Application.Models.Cliente.ExcluirCliente;
using API_Juntos.Application.Models.Cliente.InserirCliente;
using API_Juntos.Application.Models.Cliente.ListarClientePorId;
using API_Juntos.Application.Models.Cliente.ListarClientes;
using API_Juntos.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        public readonly IUseCaseAsync<InserirClienteRequest, InserirClienteResponse> _useCaseInserir;
        //public readonly IUseCaseAsync<AtualizarClienteRequest, AtualizarClienteResponse> _useCaseAtualizar;
        private readonly IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse> _useCaseExcluir;
        private readonly IUseCaseAsync<ListarClientePorIdRequest, ListarClientePorIdResponse> _useCaseListarPorId;
        private readonly IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>> _useCaseListarUsuarios;

        public ClienteController(IUseCaseAsync<InserirClienteRequest, InserirClienteResponse> useCaseInserir,
            /*IUseCaseAsync<AtualizarClienteRequest, AtualizarClienteResponse> useCaseAtualizar,*/
            IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse> useCaseExcluir,
            IUseCaseAsync<ListarClientePorIdRequest, ListarClientePorIdResponse> useCaseListarPorId,
            IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>> useCaseListarUsuarios)
        {
            _useCaseInserir = useCaseInserir;
            //_useCaseAtualizar = useCaseAtualizar;
            _useCaseExcluir = useCaseExcluir;
            _useCaseListarPorId = useCaseListarPorId;
            _useCaseListarUsuarios = useCaseListarUsuarios;

        }

        [HttpPost]
        public async Task<ActionResult<InserirClienteResponse>> Post([FromBody] InserirClienteRequest request)
        {
            return await _useCaseInserir.ExecuteAsync(request); 
        }
        /* SE FOR DELETAR, APAGAR DA ID (IMPLEMENTAÇÃO CONTROLLER  E STARTUP)
        [HttpPut("atualizacao_usuario/{id:int}")]
        public async Task<ActionResult<AtualizarUsuarioResponse>> Put([FromRoute] int id) 
        {
            return await _useCaseAtualizar.ExecuteAsync(new AtualizarUsuarioRequest() { Id = id }); //(NÃO ENTENDI MUITO BEM PORQUE SERIA DESTE MODO, AO INVÉS DE PASSAR UM REQUEST)
        }*/

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirClienteResponse>> Delete([FromRoute] int id)
        {
            return await _useCaseExcluir.ExecuteAsync(new ExcluirClienteRequest() { IdCliente = id });
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ListarClientePorIdResponse>> Get([FromQuery] int id)
        {
            return await _useCaseListarPorId.ExecuteAsync(new ListarClientePorIdRequest() { IdCliente = id });

        }

        [HttpGet("listar_todos")]
        public async Task<ActionResult<List<ListarClientesResponse>>> Get([FromQuery] ListarClientesRequest request)
        {
            return await _useCaseListarUsuarios.ExecuteAsync(request);
        }

    }
}
