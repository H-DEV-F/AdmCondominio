using AdmCondominio.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmCondominio.Data.Config
{
    public class ApartamentoConfiguration : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Identificador)
                .IsRequired();
            builder
                .Property(x => x.DataCadastro)
                .IsRequired();
            builder
                .Property(x => x.DataAtualizacao);
        }
    }
}
