using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    class VerificaDados
    {
        public VerificaNome VerificaNome { get; set; }
        public VerificaCpf VerificaCpf { get; set; }
        public VerificaDataNascimento VerificaDataNascimento { get; set; }
        public VerificaEstadoCivil VerificaEstadoCivil { get; set; }
        public VerificaDependentes VerificaDependentes { get; set; }

        public VerificaDados(string nome, string cpf, string dataNascimento, string estadoCivil, string dependentes)
        {
            VerificaNome = new VerificaNome(nome);
            VerificaCpf = new VerificaCpf(cpf);
            VerificaDataNascimento = new VerificaDataNascimento(dataNascimento);
            VerificaEstadoCivil = new VerificaEstadoCivil(estadoCivil);
            VerificaDependentes = new VerificaDependentes(dependentes);
        }
    }
}
