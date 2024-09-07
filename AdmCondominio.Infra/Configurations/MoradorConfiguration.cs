using AdmCondominio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmCondominio.Domain.Configurations
{
    public class MoradorConfiguration : IEntityTypeConfiguration<Morador>
    {
        public void Configure(EntityTypeBuilder<Morador> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Nome)
                .IsRequired();
            builder
                .Property(x => x.Telefone)
                .IsRequired();
            builder
                .Property(x => x.Pets)
                .IsRequired();
            builder
                .Property(x => x.DataCadastro)
                .IsRequired();
            builder
                .Property(x => x.DataAtualizacao);
        }
    }
}
