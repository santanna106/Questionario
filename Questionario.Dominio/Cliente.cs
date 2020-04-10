using Questionario.Dominio.ObjetoValor;
using Questionario.Infraestrutura.Comum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Dominio
{
    public class Cliente : EntidadeBase<int>
 {

        public string nome { get; set; }


        public Endereco ClienteEndereco { get; set; }

        protected override void Valida()
       {
            if (string.IsNullOrEmpty(nome))
            {
                AdicionaRegraQuebrada(ClienteRegrasNegocio.NomeClienteObrigatorio);
            }
            ClienteEndereco.ThrowExceptionIfInvalid();
        }
  }
}
