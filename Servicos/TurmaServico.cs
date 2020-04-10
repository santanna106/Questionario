using System;
using Dominio;

namespace Servicos
{
    public class TurmaServico
    {
        public bool matricularAlunoTurma(Turma turma, Aluno aluno)
        {
            if (this.verificaTurmaVagaOciosa(turma))
            {
                turma.Alunos.Add(aluno);
                aluno.Turmas.Add(turma);
                return true;
            }
            return false;
            
        }
        public bool verificaTurmaVagaOciosa(Turma turma)
        {
            if (turma.Capacidade < (turma.Alunos.Count + 1))
            {
                return false;
            }

            return true;
        }
    }
}
