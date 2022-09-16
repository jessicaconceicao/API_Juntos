//using API_Juntos.Application.Mappings;
using API_Juntos.Application.Models.InserirUsuario;
using API_Juntos.Application.Models.Pedidos.AtualizarPedido;
using API_Juntos.Application.Models.Pedidos.ExcluirPedidos;
using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Models.Pedidos.ListarPedidoPorId;
using API_Juntos.Application.Models.Pedidos.ListarPedidos;
using API_Juntos.Application.Models.Produtos.AdicionarProduto;
using API_Juntos.Application.Models.Produtos.AtualizarProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.Models.Produtos.ListarProdutos;
using API_Juntos.Application.Models.Usuario.AtualizarUsuario;
using API_Juntos.Application.Models.Usuario.ExcluirUsuario; //PQ NÃO TÁ FICANDO MODELS.CLIENTE.EXCLUIRCLIENTE??????????/
using API_Juntos.Application.Models.Usuario.ListarUsuario;  //PQ NÃO TÁ FICANDO MODELS.CLIENTE.LISTARCLIENTE??????????/
using API_Juntos.Application.Models.Usuario.ListarUsuarioPorId;  //PQ NÃO TÁ FICANDO MODELS.CLIENTE.LISTARCLIENTEPORID??????????/
using API_Juntos.Application.Models.Usuario.ListarUsuarios;      //PQ NÃO TÁ FICANDO MODELS.CLIENTE.LISTARCLIENTES??????????/
using API_Juntos.Application.UseCases;
//using API_Juntos.Application.UseCases.Pedidos;
//using API_Juntos.Application.UseCases.Produtos;
//using API_Juntos.Application.UseCases.Usuarios; //PQ NÃO TÁ FICANDO USECASES.CLIENTE??????????/
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Database;
using API_Juntos.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IClienteRepository, ClienteRepository>();
            //services.AddTransient<IProdutoRepository, ProdutoRepository>();
           // services.AddTransient<IUseCaseAsync<InserirClienteRequest, InserirClienteResponse>, InserirClienteUseCase>();
           // //services.AddTransient<IUseCaseAsync<AtualizarClienteRequest, AtualizarClienteResponse>, AtualizarClienteUseCase>();
           // services.AddTransient<IUseCaseAsync<ExcluirClienteRequest, ExcluirClienteResponse>, ExcluirClienteUseCase>();
           // services.AddTransient<IUseCaseAsync<ListarClientePorIdRequest, ListarClientePorIdResponse>, ListarClientePorIdUseCase>();
           // services.AddTransient<IUseCaseAsync<ListarClientesRequest, List<ListarClientesResponse>>, ListarClientesUseCase>();
           // services.AddTransient<IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse>, InserirProdutoUseCase > ();
           // //services.AddTransient<IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse>, AtualizarProdutoUseCase>();
           // services.AddTransient<IUseCaseAsync<ListarProdutosRequest, List<ListarProdutosResponse>>, ListarProdutosUseCase>();
           // services.AddTransient<IUseCaseAsync<ListarProdutoPorIdRequest, ListarProdutoPorIdResponse>, ListarProdutoPorIdUseCase>();
           // services.AddTransient<IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>, InserirPedidoUseCase>();
           //// services.AddTransient<IUseCaseAsync<AtualizarPedidoRequest, AtualizarPedidoResponse>, AtualizarPedidoUseCase>();
           // services.AddTransient<IUseCaseAsync<ExcluirPedidoRequest, ExcluirPedidoResponse>, ExcluirPedidoUseCase>();
           // services.AddTransient<IUseCaseAsync<ListarPedidoPorIdRequest, ListarPedidoPorIdResponse>, ListarPedidoPorIdUseCase>();
           // services.AddTransient<IUseCaseAsync<ListarPedidosRequest, List<ListarPedidosResponse>>, ListarPedidosUseCase>();
                                 
            //services.AddAutoMapper(typeof(MappingProfile)); //SERIA MAIS ADEQUADO O TRANSIENT OU SCOPED?

            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
             );

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_e_commerce_Juntos", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_e_commerce_Juntos v1"));
            }

            //context.Database.Migrate();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
