using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Dominio
{
    class ValueObjectIsInvalidException : Exception
    {
        public ValueObjectIsInvalidException(string mensagem)
            : base(mensagem)
        {}
    }
}
