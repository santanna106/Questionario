using System;
using Xunit;
using Dominio;
using Servicos;

namespace Domini.Test
{
    public class TurmaTest
    {
        private readonly Turma _turma;
        private readonly TurmaServico _turmaServico;
        public TurmaTest()
        {
            _turma = new Turma();
            _turmaServico = new TurmaServico();
        }
        [Fact]
        public void Turma_NumeroMatriculados()
        {
            int num_matriculados = 1;
            Aluno _aluno = new Aluno();
            _aluno.Nome = "Aluno 01";
            _turma.Alunos.Add(_aluno);
            Assert.Equal(num_matriculados, _turma.Alunos.Count);
            _aluno = new Aluno();
            _aluno.Nome = "Aluno 02";
            _turma.Alunos.Add(_aluno);
            Assert.Equal(++num_matriculados, _turma.Alunos.Count);
        }

        [Fact]
        public void Turma_MatricularAluno()
        {
            int num_matriculados = 1;
            
            _turma.Capacidade = 2;
            Aluno _aluno = new Aluno();
            _aluno.Nome = "Aluno 01";
            bool resultado = _turmaServico.matricularAlunoTurma(_turma, _aluno);
            Assert.True(resultado);
        }


        [Fact]
        public void Turma_VagaOciosa()
        {
            _turma.Capacidade = 1;
            Aluno _aluno = new Aluno();
            _aluno.Nome = "Aluno 01";
            _turma.Alunos.Add(_aluno);

            bool resultado = _turmaServico.verificaTurmaVagaOciosa(_turma);
            Assert.False(resultado, "A turma não tem Vaga Ociosa");

            _turma.Capacidade = 10;
            
            resultado = _turmaServico.verificaTurmaVagaOciosa(_turma);
            Assert.True(resultado, "A turma tem Vaga Ociosa");
        }
    }
}
