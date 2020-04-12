using Aprimori.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.Infrastructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            #region Configuraçõe de Cliente

            builder
                .HasKey(c => c.ClienteId);

            builder
                 .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(e => e.Cpf)
                        .HasColumnType("varchar(11)")
                        .IsRequired();

            builder.Property(e => e.Nome)
                      .HasColumnType("varchar(200)")
                      .IsRequired();

            builder.HasOne(c => c.Endereco)
                   .WithOne(e => e.Cliente)
                   .HasForeignKey<Endereco>(e => e.ClienteId);
            #endregion
        }
    }
}
