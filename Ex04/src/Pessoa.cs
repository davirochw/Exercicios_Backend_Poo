using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.src
{
    internal class Pessoa
    {
        private string nome;

        public string Nome { get { return nome; } set { nome = value; } }

        public CertidaoNascimento CertidaoNascimento { get; set; }

        public Pessoa(string nome, CertidaoNascimento certidaoNascimento)
        {
            if (nome == null)
            {
                throw new ArgumentNullException("Precisa de um nome para a pessoa");
            }
            if (certidaoNascimento == null)
            {
                throw new ArgumentNullException("Precisa de uma certidão de nascimento para a pessoa");
            }
            this.Nome = nome;
        }

        public Pessoa(string nome)
        {
            if (nome == null)
            {
                throw new ArgumentNullException("Precisa de um nome para a pessoa");
            } 
            this.Nome = nome;
        }
    }
}
