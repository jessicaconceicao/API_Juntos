using API_Juntos.Core.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Database
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");
            builder.HasKey(pk => pk.IdProduto);
            builder.Property(p => p.Nome)
                .HasColumnType("VARCHAR(20")
                .IsRequired();
            builder.Property(p => p.Lote)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();
            builder.Property(P => P.Validade)
                .HasColumnType("VARCHAR(10)")
                .IsRequired();
            builder.Property(p => p.QuantidadeEmbalagem)
                .HasColumnType("DECIMAL");
            builder.Property(p => p.Valor)
                .HasColumnType("DECIMAL")
                .IsRequired();
            builder.Property(p => p.QuantidadeEstoque)
                .HasColumnType("DECIMAL")
                .IsRequired();
        }
    }
}
