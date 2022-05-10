using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.src
{
    internal class CertidaoNascimento
    {
        private DateTime dataEmissao;
        public DateTime DataEmissao { get { return dataEmissao; } }

        public Pessoa Pessoa { get; set; }

        public CertidaoNascimento(DateTime dataEmissao, Pessoa pessoa)
        {
            if (pessoa.CertidaoNascimento != null)
            {
                throw new Exception("Já possui certidão de nascimento.");
            }

            this.dataEmissao = dataEmissao;
        }
    }
}
