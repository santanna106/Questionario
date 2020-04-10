using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Dominio.ObjetoValor
{
    public class Endereco : ObjetoValor
    {
        public string EnderecoLine1 { get; set; }
        public string EnderecoLine2 { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        protected override void Valida()
        {
            if (string.IsNullOrEmpty(Cidade))
            {
                AdicionaRegraQuebrada(ValueObjectRegrasNegocio.EnderecoCidadeObrigatorio);
            }
        }
    }
}
