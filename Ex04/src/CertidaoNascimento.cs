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

        public DateTime DataEmissao { get { return dataEmissao; } set { dataEmissao = value; } }
        public Pessoa Pessoa { get; set; }

        public CertidaoNascimento(Pessoa pessoa, DateTime dataEmissao)
        {
            if (pessoa == null)
            {
                throw new ArgumentNullException("Precisa de uma pessoa para emitir a certidão de nascimento");
            }
            if (pessoa.CertidaoNascimento != null)
            {
                throw new ArgumentException("Pessoa já possui certidão de nascimento");
            }

            this.Pessoa = pessoa;
            this.DataEmissao = dataEmissao;
        }
    }
}
