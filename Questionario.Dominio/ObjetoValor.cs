using Questionario.Infraestrutura.Comum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Dominio.ObjetoValor
{
    public abstract class ObjetoValor
    {
        private List<RegrasNegocio> _regrasQuebrada = new List<RegrasNegocio>();

        public ObjetoValor()
        {
        }

        protected abstract void Valida();

        public void ThrowExceptionIfInvalid()
        {
            _regrasQuebrada.Clear();
            Valida();
            if (_regrasQuebrada.Count > 0)
            {
                StringBuilder emitir = new StringBuilder();
                foreach (RegrasNegocio RegrasNegocio in _regrasQuebrada)
                {
                    emitir.AppendLine(RegrasNegocio.RegraDescricao);
                }
                throw new ValueObjectIsInvalidException(emitir.ToString());
            }
        }

        protected void AdicionaRegraQuebrada(RegrasNegocio RegrasNegocio)
        {
            _regrasQuebrada.Add(RegrasNegocio);
        }
    }

}
