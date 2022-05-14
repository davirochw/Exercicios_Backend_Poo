using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class VerificaDataNascimento
    {
        public VerificaDataNascimento(string dataNascimento)
        {
            verificaDataNascimento(dataNascimento);
        }

        public bool verificaDataNascimento(string dataNascimento)
        {
            try
            {
                DateTime data = Convert.ToDateTime(dataNascimento);
                if (DateTime.Now.Year - data.Year < 18)
                {
                    Console.WriteLine("Cliente precisar ter mais de 18 anos!");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Data de nascimento inválida: [DD/MM/AAAA]");
                return false;
            }
        }
    }
}
