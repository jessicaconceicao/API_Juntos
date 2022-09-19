﻿using API_Juntos.Application.Models.Produtos.AtualizarProduto;
using API_Juntos.Application.Models.Produtos.ExcluirProduto;
using API_Juntos.Application.Models.Produtos.InserirProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.Models.Produtos.ListarProdutos;
using API_Juntos.Application.UseCases;
using API_Juntos.Application.UseCases.Produtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse> _useCaseInserir;
        //private readonly IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse> _useCaseAtualizar;
        private readonly IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse> _useCaseExcluir;
        private readonly IUseCaseAsync<int, ListarProdutoPorIdResponse> _useCaseListarPorId;
        private readonly IUseCaseAsync<ListarProdutosRequest, List<ListarProdutosResponse>> _useCaseListarProdutos;
        

        public ProdutoController(IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse> useCaseInserir,
           /* IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse> useCaseAtualizar,*/
            IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse> useCaseExcluir,
            IUseCaseAsync<int, ListarProdutoPorIdResponse> useCaseListarPorId,
            IUseCaseAsync<ListarProdutosRequest, List<ListarProdutosResponse>> useCaseListarProdutos)
        {
            
            _useCaseInserir = useCaseInserir;
            //_useCaseAtualizar = useCaseAtualizar;
            _useCaseExcluir = useCaseExcluir;
            _useCaseListarPorId = useCaseListarPorId;
            _useCaseListarProdutos = useCaseListarProdutos;
        }

        [HttpPost]
        public async Task<ActionResult<InserirProdutoResponse>> Post([FromBody] InserirProdutoRequest request)
        {
            return await _useCaseInserir.ExecuteAsync(request);
        }

        /*
          SE FOR DELETAR, APAGAR DA ID (IMPLEMENTAÇÃO CONTROLLER  E STARTUP)
        [HttpPut("atualizacao_produto{id:int}")] 
        public async Task<ActionResult<AtualizarProdutoResponse>> Put([FromRoute] int id) //Seria a melhor maneira?
        {
            return await _useCaseAtualizar.ExecuteAsync(new AtualizarProdutoRequest() { Id = id }); 
        }
        */
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirProdutoResponse>> Delete([FromRoute] int id)
        {
            return await _useCaseExcluir.ExecuteAsync(new ExcluirProdutoRequest() { IdProduto = id });
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ListarProdutoPorIdResponse>> Get(int id)
        {
            var response = await _useCaseListarPorId.ExecuteAsync(id);
            if (response == null)
                return new NotFoundObjectResult("Produto não encontrado");

            return new OkObjectResult(response);

        }

        [HttpGet("listar_todos")]
        public async Task<ActionResult<List<ListarProdutosResponse>>> Get([FromQuery] ListarProdutosRequest request)
        {
            return await _useCaseListarProdutos.ExecuteAsync(request); //é preciso manter o request acima???
        }

    }
}
