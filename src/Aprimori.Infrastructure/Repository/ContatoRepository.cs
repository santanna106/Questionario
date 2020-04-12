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
    public class ContatoRepository : EFRepository<Contato>, IContatoRepository
    {
        public ContatoRepository(ClienteContext dbContext):base(dbContext)
        {


        }
        
    }
}
