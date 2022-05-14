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
        public string Nome { get { return nome; } set { nome = value; } }

        public List<Aluno> alunos = new List<Aluno>();
        public List<Turma> turmas = new List<Turma>();

        public Curso(string nome)
        {
            this.nome = nome;
        }
    }
}
