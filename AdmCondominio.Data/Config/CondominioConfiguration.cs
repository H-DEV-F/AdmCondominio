using AdmCondominio.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmCondominio.Data.Config
{
    public class CondominioConfiguration : IEntityTypeConfiguration<Condominio>
    {
        public void Configure(EntityTypeBuilder<Condominio> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Nome)
                .IsRequired();
            builder
                .Property(x => x.Telefone)
                .IsRequired();
            builder
                .Property(x => x.Endereco)
                .IsRequired();
            builder
                .Property(x => x.Numero)
                .IsRequired();
            builder
                .Property(x => x.Bairro)
                .IsRequired();
            builder
                .Property(x => x.Cidade)
                .IsRequired();
            builder
                .Property(x => x.Estado)
                .IsRequired();
            builder
                .Property(x => x.CEP)
                .IsRequired();
            builder
                .Property(x => x.DataCadastro)
                .IsRequired();
            builder
                .Property(x => x.DataAtualizacao);
        }
    }
}
