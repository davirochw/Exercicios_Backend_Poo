using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    public class VerificaDados
    {
        public VerificaDados (string nome, string cpf, string dataNascimento, string estadoCivil, string dependentes)
        {
            VerificaNome(nome);
            VerificaCPF(cpf);
            VerificaDataNascimento(dataNascimento);
            VerificaEstadoCivil(estadoCivil);
            VerificaDependentes(dependentes);
        }
        public bool VerificaNome(string nome)
        {
            if (nome.Length < 5)
            {
                Console.WriteLine("O nome do cliente precisa ter pelo menos 5 caracteres");
                return false;
            }
            return true;
        }

        public bool VerificaCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                Console.WriteLine("CPF inválido!");
                return false;
            }
            return true;
        }

        public bool VerificaDataNascimento(string dataNascimento)
        { 
            DateTime dataNasc = Convert.ToDateTime(dataNascimento);

            if (DateTime.Now.Year - dataNasc.Year < 18)
            {
                Console.WriteLine("Cliente precisar ter mais de 18 anos!");
                return false;
            }
            return true; 
        }

        public bool VerificaEstadoCivil(string estadoCivil)
        {
            Char estadoC = Convert.ToChar(estadoCivil);

            if (estadoC != 'S' || estadoC != 'C' || estadoC != 'V' || estadoC != 'D' || estadoC != 's' || estadoC != 'c' || estadoC != 'v' || estadoC != 'd')
            {
                return false;
            }
            else
            {
                Console.WriteLine("Estado civil inválido!");
                return true;
            }
        }

        public bool VerificaDependentes(string dependentes)
        {
            int dependente = Convert.ToInt32(dependentes);

            if (dependente >= 0 && dependente <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
