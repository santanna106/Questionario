using System;
using System.Collections.Generic;
using System.Text;


namespace Dominio
{
    public class Turma
    {
        public int Capacidade { get; set; }
  
        public virtual IList<Aluno> Alunos { get; set; }

        public String Serie { get; set; }

        public Turma()
        {
            Alunos = new List<Aluno>();
        }

        
    }
}
