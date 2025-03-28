using Infra.UPX4.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.UPX4.Data.Mapping
{
    public class ProdutoEntityMap : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {

            builder.ToTable("produto");
            builder.HasKey(p => p.Id);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(200);

            builder.HasIndex(u => u.CategoriaId);

            builder.HasIndex(u => u.FornecedorId);



        }

    }
}