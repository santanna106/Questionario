using Aprimori.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.Infrastructure.EntityConfig
{
    public class ProfissaoClienteMap : IEntityTypeConfiguration<ProfissaoCliente>
    {
        public void Configure(EntityTypeBuilder<ProfissaoCliente> builder)
        {
            #region Configurações Profissão Cliente

            builder
                .HasKey(pc => pc.Id);

            builder
                .HasOne(pc => pc.Cliente)
                .WithMany(c => c.ProfissaoClientes)
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);


            builder
              .HasOne(pc => pc.Profissao)
              .WithMany(c => c.ProfissaoClientes)
              .HasForeignKey(c => c.ProfissaoId);

            #endregion
        }
    }
}
