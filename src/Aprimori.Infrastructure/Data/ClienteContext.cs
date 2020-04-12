using Aprimori.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base (options)
        {


        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");
            modelBuilder.Entity<Profissao>().ToTable("Profissao");
            modelBuilder.Entity<ProfissaoCliente>().ToTable("ProfissaoCliente");

            #region Configuraçõe de Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Contatos)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>().Property(e => e.Cpf)
                        .HasColumnType("varchar(11)")
                        .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                      .HasColumnType("varchar(200)")
                      .IsRequired();
            #endregion

            #region Configurações de Contato

            modelBuilder.Entity<Contato>()
                .HasKey(c => c.ContatoId);

            modelBuilder.Entity<Contato>()
                .HasOne(c => c.Cliente)
                .WithMany(c => c.Contatos)
                .HasForeignKey(c => c.ClienteId)
                .HasPrincipalKey(c => c.ClienteId);


            modelBuilder.Entity<Contato>().Property(e => e.Email)
                     .HasColumnType("varchar(100)")
                     .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
                      .HasColumnType("varchar(200)")
                      .IsRequired();


            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
                     .HasColumnType("varchar(15)");
            #endregion

            #region Configurações de Profissões

            modelBuilder.Entity<Profissao>().Property(p => p.Nome)
                      .HasColumnType("varchar(400)")
                      .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.Cbo)
                      .HasColumnType("varchar(10)")
                      .IsRequired();

            modelBuilder.Entity<Profissao>().Property(p => p.Descricao)
                    .HasColumnType("varchar(1000)")
                    .IsRequired();

            #endregion

            #region Configurações de Endereço


            modelBuilder.Entity<Endereco>().Property(end => end.Bairro)
                      .HasColumnType("varchar(200)")
                      .IsRequired();

            modelBuilder.Entity<Endereco>().Property(end => end.Cep)
                      .HasColumnType("varchar(15)")
                      .IsRequired();


            modelBuilder.Entity<Endereco>().Property(end => end.Logradouro)
                      .HasColumnType("varchar(200)")
                      .IsRequired();

            modelBuilder.Entity<Endereco>().Property(end => end.Referencia)
                .HasColumnType("varchar(400)");

            #endregion

            #region Configurações Profissão Cliente

            modelBuilder.Entity<ProfissaoCliente>()
                .HasKey(pc => pc.Id);

            modelBuilder.Entity<ProfissaoCliente>()
                .HasOne(pc => pc.Cliente)
                .WithMany(c => c.ProfissaoClientes)
                .HasForeignKey(c => c.ClienteId);


            modelBuilder.Entity<ProfissaoCliente>()
              .HasOne(pc => pc.Profissao)
              .WithMany(c => c.ProfissaoClientes)
              .HasForeignKey(c => c.ProfissaoId);

            #endregion

            #region Configurações de Menu
            modelBuilder.Entity<Menu>()
                .HasMany(x => x.SubMenu)
                .WithOne()
                .HasForeignKey(x => x.MenuId);
            #endregion
        }
    }

}
