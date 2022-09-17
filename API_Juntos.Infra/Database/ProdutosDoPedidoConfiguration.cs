﻿using API_Juntos.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Juntos.Infra.Database
{
    public class ProdutosDoPedidoConfiguration : IEntityTypeConfiguration<ProdutosDoPedido>
    {
        public void Configure(EntityTypeBuilder<ProdutosDoPedido> builder)
        {
            builder.ToTable("produtosDosPedidos");
            builder.HasKey(pk => pk.IdProdutosDoPedido);
            builder.Property(p => p.Quantidade)
                .HasColumnType("DECIMAL")
                .IsRequired();
            builder.Property(p => p.ValorUnitario)
                .HasColumnType("DECIMAL")
                .IsRequired();
            builder.HasOne(fk => fk.Pedido)
                .WithMany(fk => fk.ProdutosDoPedido)
                .HasForeignKey(fk => fk.IdPedido);
            builder.HasOne(fk => fk.Produto)
                .WithMany(fk => fk.PodutosDoPedido)
                .HasForeignKey(fk => fk.IdProduto);

        }
    }
}
