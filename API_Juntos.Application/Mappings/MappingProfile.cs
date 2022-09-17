﻿using API_Juntos.Application.Models.Cliente.InserirCliente;
using API_Juntos.Application.Models.Cliente.ListarClientePorId;
using API_Juntos.Application.Models.Cliente.ListarClientes;
using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Application.Models.Pedidos.ListarPedidos;
using API_Juntos.Application.Models.Produtos.InserirProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.Models.Produtos.ListarProdutos;
using API_Juntos.Core.Entidades;
using AutoMapper;

namespace API_Juntos.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<InserirClienteRequest, Cliente>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            CreateMap<Cliente, ListarClientePorIdResponse>()
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.IdCliente))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            CreateMap<Cliente, ListarClientesResponse>()
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.IdCliente))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            CreateMap<InserirProdutoRequest, Produto>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Lote, fonte => fonte.MapFrom(src => src.Lote))
                .ForMember(dest => dest.Validade, fonte => fonte.MapFrom(src => src.Validade))
                .ForMember(dest => dest.QuantidadeEmbalagem, fonte => fonte.MapFrom(src => src.QuantidadeEmbalagem))
                .ForMember(dest => dest.Valor, fonte => fonte.MapFrom(src => src.Valor))
                .ForMember(dest => dest.QuantidadeEstoque, fonte => fonte.MapFrom(src => src.QuantidadeEstoque));

            CreateMap<Produto, ListarProdutoPorIdResponse>()
                .ForMember(dest => dest.IdProduto, fonte => fonte.MapFrom(src => src.IdProduto))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Lote, fonte => fonte.MapFrom(src => src.Lote))
                .ForMember(dest => dest.Validade, fonte => fonte.MapFrom(src => src.Validade))
                .ForMember(dest => dest.QuantidadeEmbalagem, fonte => fonte.MapFrom(src => src.QuantidadeEmbalagem))
                .ForMember(dest => dest.Valor, fonte => fonte.MapFrom(src => src.Valor))
                .ForMember(dest => dest.QuantidadeEstoque, fonte => fonte.MapFrom(src => src.QuantidadeEstoque));

            CreateMap<Produto, ListarProdutosResponse>()
                .ForMember(dest => dest.IdProduto, fonte => fonte.MapFrom(src => src.IdProduto))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Lote, fonte => fonte.MapFrom(src => src.Lote))
                .ForMember(dest => dest.Validade, fonte => fonte.MapFrom(src => src.Validade))
                .ForMember(dest => dest.QuantidadeEmbalagem, fonte => fonte.MapFrom(src => src.QuantidadeEmbalagem))
                .ForMember(dest => dest.Valor, fonte => fonte.MapFrom(src => src.Valor))
                .ForMember(dest => dest.QuantidadeEstoque, fonte => fonte.MapFrom(src => src.QuantidadeEstoque));
              
            CreateMap<InserirPedidoRequest, Pedido>()
                //.ForMember(dest => dest.DataPedido, fonte => fonte.MapFrom(src => src.DataPedido)) se colocar pelo sistema não mapeia!
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.IdCliente))
                .ForMember(dest => dest.ProdutosDoPedido, fonte => fonte.MapFrom(src => src.ProdutosDoPedido));

            //seria assim? como colocar as demais infos (lista de ProdutosDoPedido??????? o valor é gerado internamente, o que entraria aqui?

            CreateMap<Pedido, ListarPedidoPorIdResponse>()
                .ForMember(dest => dest.IdPedido, fonte => fonte.MapFrom(src => src.IdPedido))
                .ForMember(dest => dest.ValorPedido, fonte => fonte.MapFrom(src => src.ValorPedido))
                .ForMember(dest => dest.DataPedido, fonte => fonte.MapFrom(src => src.DataPedido))
                .ForMember(dest => dest.ProdutosDoPedido, fonte => fonte.MapFrom(src => src.ProdutosDoPedido))
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.IdCliente));

            CreateMap<Pedido, ListarPedidosResponse>()
                .ForMember(dest => dest.IdPedido, fonte => fonte.MapFrom(src => src.IdPedido))
                .ForMember(dest => dest.ValorPedido, fonte => fonte.MapFrom(src => src.ValorPedido))
                .ForMember(dest => dest.DataPedido, fonte => fonte.MapFrom(src => src.DataPedido))
                .ForMember(dest => dest.ProdutosDoPedido, fonte => fonte.MapFrom(src => src.ProdutosDoPedido))
                .ForMember(dest => dest.IdCliente, fonte => fonte.MapFrom(src => src.IdCliente));


            


        }
    }
}
