using Questionario.Infraestrutura.Comum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Dominio
{
    public static class ClienteRegrasNegocio
    {
        public static readonly RegrasNegocio NomeClienteObrigatorio =
           new RegrasNegocio("O nome do cliente não pode ser vazio.Informe o nome do Cliente.");
    }
}   

