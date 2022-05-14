using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.src
{
    internal class Aluno
    {
        private string nome;

        public Random matricula = new Random();
        public string Nome { get { return nome; } set { nome = value; } }

        public List<Turma> turmas = new List<Turma>();

        public Aluno(string nome)
        {
            this.nome = nome;
        }

        public int Matricula()
        {
            return matricula.Next(1, 1000);
        }
    }
}
