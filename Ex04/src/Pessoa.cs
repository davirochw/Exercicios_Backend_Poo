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
        private CertidaoNascimento certidaoNascimento;
        public string Nome { get { return nome; } set { nome = value; } }
        public CertidaoNascimento CertidaoNascimento { get { return certidaoNascimento; } 
            private set { if(certidaoNascimento != null) 
                { throw new Exception("Não pode ter mais de uma certidão."); 
                } certidaoNascimento = value; } }

        public Pessoa(string nome, CertidaoNascimento certidaoNascimento)
        {
            this.nome = nome;
            this.certidaoNascimento = certidaoNascimento;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }
    }
}
