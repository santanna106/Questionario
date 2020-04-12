using System;
using System.Collections.Generic;
using System.Text;

namespace Aprimori.ApplicationCore.Entity
{
    public class Profissao
    {
        public Profissao()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public string Cbo { get; set; }

        public ICollection<ProfissaoCliente> ProfissaoClientes { get; set; }
    }
}
