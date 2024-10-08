﻿using AdmCondominio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdmCondominio.Domain.Configurations
{
    public class BlocoConfiguration : IEntityTypeConfiguration<Bloco>
    {
        public void Configure(EntityTypeBuilder<Bloco> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .Property(x => x.Nome)
                .IsRequired();
            builder
                .Property(x => x.DataCadastro)
                .IsRequired();
            builder
                .Property(x => x.DataAtualizacao);
        }
    }
}
