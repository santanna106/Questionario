using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Aluno
    {
        public int Idade { get; set; }
        public String Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public String Cep { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }

        public String Serie { get; set; }

        public virtual IList<Turma> Turmas { get; set; }

        public Aluno()
        {
            Turmas = new List<Turma>();
        }

    }
}
