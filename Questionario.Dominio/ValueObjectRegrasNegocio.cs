using Questionario.Infraestrutura.Comum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Dominio.ObjetoValor
{
    public static class ValueObjectRegrasNegocio
    {
        public static readonly RegrasNegocio EnderecoCidadeObrigatorio = new RegrasNegocio("O nome da cidade é obrigatório.");
    }

}
