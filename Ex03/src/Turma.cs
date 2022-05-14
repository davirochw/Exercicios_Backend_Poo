using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.src
{
    internal class Turma
    {
        private string codigo;

        public string Codigo { get { return codigo; } set { codigo = value; } }

        public List<Aluno> alunos = new List<Aluno>();

        public Turma(string codigo)
        {
            this.codigo = codigo;
        }
    }
}
