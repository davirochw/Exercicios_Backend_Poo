using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.src
{
    internal class Controller
    {
        public List<Aluno> alunos = new List<Aluno>();
        public List<Turma> turmas = new List<Turma>();

        public void MatriculaAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public void RemoveAluno(Aluno aluno)
        {
            if (aluno.turmas == null)
            {
                alunos.Remove(aluno);
            }
        }

        public void CriaTurma(Turma turma)
        {
            turmas.Add(turma);
        }

        public void RemoveTurma(Turma turma)
        {
            if (turma.alunos.Count == 0)
            {
                turmas.Remove(turma);
            }
        }

        public void InserirAlunoTurma(Aluno aluno, Turma turma)
        {
            if (aluno.turmas.Contains(turma))
            {
                throw new Exception("Aluno já está na turma");
            }
            else
            {
                turma.alunos.Add(aluno);
            }
        }

        public void RemoverAlunoTurma(Aluno aluno, Turma turma)
        {
            if (aluno.turmas.Contains(turma))
            {
                turma.alunos.Remove(aluno);
            }
            else
            {
                throw new Exception("Aluno não está na turma");
            }
        }

        public void ListaAlunoPorTurma(Turma turma)
        {
            Console.WriteLine("Alunos listados por ordem: ");
            foreach (Aluno aluno in turma.alunos.OrderBy(a => a.Nome))
            {
                Console.WriteLine(aluno.Nome);
            }
        }

        public void ListaTurmaPorOrdem(Aluno aluno)
        {
            Console.WriteLine("Turmas listadas por ordem: ");
            foreach (Turma turma in aluno.turmas.OrderBy(t => t.Codigo))
            {
                Console.WriteLine(turma.Codigo);

                foreach (Aluno aluno1 in turma.alunos.OrderBy(a => a.Nome))
                {
                    Console.WriteLine(aluno1.Nome);
                }
            }
        }
    }
}
