using Aprimori.ApplicationCore.Entity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void  Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome= "Fulano da Silva",
                    Cpf = "11111111111"
                },
                new Cliente{
                    Nome= "Beltrano da Silva",
                    Cpf = "22222222222"
                }
            };

            context.AddRange(clientes);
            context.SaveChanges();

            if (context.Contatos.Any())
            {
                return;
            }

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome= "Fulano da Silva",
                    Email="fulano@gmail.com",
                    Telefone = "11111111111",
                    Cliente = clientes[0]
                },
                 new Contato
                {
                    Nome= "Beltrano da Silva",
                    Email="beltrano@gmail.com",
                    Telefone = "11111111111",
                    Cliente = clientes[1]
                }
            };

            context.AddRange(contatos);
            context.SaveChanges();

        }
    }
}
