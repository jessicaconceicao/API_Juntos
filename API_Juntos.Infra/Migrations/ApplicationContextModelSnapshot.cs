﻿// <auto-generated />
using System;
using API_Juntos.Infra.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_Juntos.Infra.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_Juntos.Core.Entidades.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Telefone")
                        .HasColumnType("VARCHAR(15)");

                    b.HasKey("IdCliente");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("DATETIME");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorPedido")
                        .HasColumnType("DECIMAL");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCliente");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lote")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<decimal>("QuantidadeEmbalagem")
                        .HasColumnType("DECIMAL");

                    b.Property<decimal>("QuantidadeEstoque")
                        .HasColumnType("DECIMAL");

                    b.Property<string>("Validade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(10)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL");

                    b.HasKey("IdProduto");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.ProdutosDoPedido", b =>
                {
                    b.Property<int>("IdProdutosDoPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("DECIMAL");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("DECIMAL");

                    b.HasKey("IdProdutosDoPedido");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("produtosDosPedidos");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.Pedido", b =>
                {
                    b.HasOne("API_Juntos.Core.Entidades.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.ProdutosDoPedido", b =>
                {
                    b.HasOne("API_Juntos.Core.Entidades.Pedido", "Pedido")
                        .WithMany("ProdutosDoPedido")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_Juntos.Core.Entidades.Produto", "Produto")
                        .WithMany("PodutosDoPedido")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.Pedido", b =>
                {
                    b.Navigation("ProdutosDoPedido");
                });

            modelBuilder.Entity("API_Juntos.Core.Entidades.Produto", b =>
                {
                    b.Navigation("PodutosDoPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
