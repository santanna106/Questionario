using Aprimori.ApplicationCore.Entity;
using Aprimori.ApplicationCore.Interfaces.Repository;
using Aprimori.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Aprimori.Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ClienteContext dbContext):base(dbContext)
        {


        }
        public Cliente ObterClientePorProfissao(int clienteId)
        {
            return Buscar(x => x.ProfissaoClientes.Any(p=> p.ClienteId == clienteId))
                .FirstOrDefault();
        }
    }
}
