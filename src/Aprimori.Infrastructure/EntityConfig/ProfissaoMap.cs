using Aprimori.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.Infrastructure.EntityConfig
{
    public class ProfissaoMap : IEntityTypeConfiguration<Profissao>
    {
        public void Configure(EntityTypeBuilder<Profissao> builder)
        {
            #region Configurações de Profissões

            builder.Property(p => p.Nome)
                      .HasColumnType("varchar(400)")
                      .IsRequired();

            builder.Property(p => p.Cbo)
                      .HasColumnType("varchar(10)")
                      .IsRequired();

            builder.Property(p => p.Descricao)
                    .HasColumnType("varchar(1000)")
                    .IsRequired();

            #endregion
        }
    }
}
