using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class VerificaNome
    {
        public VerificaNome(string nome)
        {
            verificaNome(nome);
        }

        public bool verificaNome(string nome)
        {
            if (nome.Length >= 5)
            {
                return true;
            }
            else
            {
                Console.WriteLine("O nome do cliente precisa ter pelo menos 5 caracteres");
                return false;
            }
        }
    }
}
