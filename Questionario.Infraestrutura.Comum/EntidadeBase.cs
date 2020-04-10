using System;
using System.Collections.Generic;

namespace Questionario.Infraestrutura.Comum
{
    public abstract class EntidadeBase<IdTipo>
    {
        public IdTipo Id { get; set; }

        public override bool Equals(object entidade)
       {
           return entidade != null && entidade is EntidadeBase<IdTipo> 
               && this == (EntidadeBase<IdTipo>) entidade;
        }
  
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
  
         public static bool operator ==(EntidadeBase<IdTipo> entidade1,
            EntidadeBase<IdTipo> entidade2)
        {
            if ((object) entidade1 == null && (object) entidade2 == null)
            {
                return true;
            }
  
            if ((object) entidade1 == null || (object) entidade2 == null)
            {
                return false;
            }
  
            if (entidade1.Id.ToString() == entidade2.Id.ToString())
            {
                return true;
            }
  
            return false;
        }
  
        public static bool operator !=(EntidadeBase<IdTipo> entidade1,
             EntidadeBase<IdTipo> entidade2)
        {
            return (!(entidade1 == entidade2));
        }

        protected abstract void Valida();

        private List<RegrasNegocio> _regrasQuebrada = new List<RegrasNegocio>();

        public IEnumerable<RegrasNegocio> GetRegrasQuebradas()
        {
            _regrasQuebrada.Clear();
            Valida();
            return _regrasQuebrada;
        }

        protected void AdicionaRegraQuebrada(RegrasNegocio RegrasNegocio)
        {
            _regrasQuebrada.Add(RegrasNegocio);
        }

    }
}

