using System;
using System.Collections.Generic;
using System.Text;

namespace Questionario.Infraestrutura.Comum
{
    public class RegrasNegocio
 {
    private string _regraDescricao;
  
    public RegrasNegocio(string regraDescricao)
    {
        _regraDescricao = regraDescricao;
    }
  
    public String RegraDescricao
   {
        get
       {
            return _regraDescricao;
        }
    }
 }
}
