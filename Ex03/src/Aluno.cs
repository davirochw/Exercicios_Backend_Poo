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
        private int matricula;
        Random randNum = new Random();

        public string Nome { get { return nome; } }
        public int Matricula { get { return matricula; } }

        public Turma Turma { get { return Turma; } }

        public Aluno(string nome)
        {
            this.nome = nome;
            this.matricula = randNum.Next(100000, 999999);         
        }
    }
}
