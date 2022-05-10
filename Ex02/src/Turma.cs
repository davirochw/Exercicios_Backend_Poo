using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.src
{
    internal class Turma
    {
        private int matricula;
        private string nome;
        private double notaP1;
        private double notaP2;
        private double notaFinal;

        public int Matricula { get { return matricula; } set { matricula = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public double NotaP1 { get { return notaP1; } set { notaP1 = value; } }
        public double NotaP2 { get { return notaP2; } set { notaP2 = value; } }
        public double NotaFinal { get { return notaFinal; } private set { } }

        private List<Turma> alunos;

        public List<Turma> Alunos { get { return alunos; } }

        public Turma()
        {
        }

        public Turma(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
            NotaP1 = NotaP1;
            NotaP2 = NotaP2;
            this.notaFinal = (NotaP1 + NotaP2) / 2;
        }

        public Turma(int matricula, string nome, double notaP1, double notaP2)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.notaP1 = notaP1;
            this.notaP2 = notaP2;
            this.notaFinal = (notaP1 + notaP2) / 2;
        }

        public void AdicionaAluno(Turma aluno)
        {
            alunos.Add(aluno);
        }

        public void RemoveAluno(Turma aluno)
        {
            if (alunos.Contains(aluno))
            {
                alunos.Remove(aluno);
            }
        }

        public void ImprimeAluno()
        {
            var lista = alunos.OrderBy(li => li.Nome).ToList();

            foreach(Turma aluno in lista)
            {
                Console.WriteLine("Aluno: {0}, Nota Final: {1}", aluno.Nome, aluno.NotaFinal);
            }
        }

        public void MediaP1()
        {
            double soma = 0;
            foreach(Turma aluno in alunos)
            {
                soma += aluno.NotaP1;
            }

            double mediaP1 = soma / alunos.Count;

            Console.WriteLine("A média P1 da turma foi: {0}", mediaP1);
        }

        public void MediaP2()
        {
            double soma = 0;
            foreach (Turma aluno in alunos)
            {
                soma += aluno.NotaP2;
            }

            double mediaP2 = soma / alunos.Count;

            Console.WriteLine("A média P1 da turma foi: {0}", mediaP2);
        }

        public void NotasFinais()
        {
            foreach(Turma aluno in alunos)
            {
                Console.WriteLine("A média final do aluno {0}, foi {1}", aluno.Nome, aluno.NotaFinal);
            }
        }

        public void MaiorNotaFinal()
        {
            double maiorNotaFinal = 0;
            string nomeDoAluno = "";
            int matriculaDoAluno = 0;

            foreach (Turma aluno in alunos)
            {
                if(aluno.NotaFinal > maiorNotaFinal)
                {
                    matriculaDoAluno = aluno.Matricula;
                    nomeDoAluno = aluno.Nome;
                    maiorNotaFinal = aluno.NotaFinal;
                }
            }
            Console.WriteLine("O aluno com a maior nota final foi:{0}, matrícula {1}, a nota foi: {2}", nomeDoAluno, matriculaDoAluno, maiorNotaFinal);
        }
    }
}
