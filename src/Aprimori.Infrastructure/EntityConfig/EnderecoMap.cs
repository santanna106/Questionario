using Aprimori.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.Infrastructure.EntityConfig
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            #region Configurações de Endereço
            


            builder.Property(end => end.Bairro)
                      .HasColumnType("varchar(200)")
                      .IsRequired();

            builder.Property(end => end.Cep)
                      .HasColumnType("varchar(15)")
                      .IsRequired();


            builder.Property(end => end.Logradouro)
                      .HasColumnType("varchar(200)")
                      .IsRequired();

            builder.Property(end => end.Referencia)
                .HasColumnType("varchar(400)");

            #endregion
        }
    }
}
