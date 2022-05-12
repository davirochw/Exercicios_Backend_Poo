using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.src
{
    internal class Curso
    {
        private string nome;
        public string Nome { get; set; }

        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<Turma> Turmas { get; set; } = new List<Turma>();

        public Curso(string nome)
        {
            this.nome = nome;
        }

        public void MatriculaAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoveAluno(Aluno aluno)
        {
            if(aluno.Turma == null)
            {
                Alunos.Remove(aluno);
            }
        }

        public void CriaTurma(Turma turma)
        {
            Turmas.Add(turma);
        }

        public void RemoveTurma(Turma turma)
        {
            if (turma.Alunos.Count == 0)
            {
                Turmas.Remove(turma);
            }
        }
    }
}
