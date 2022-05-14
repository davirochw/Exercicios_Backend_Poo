using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class VerificaDependentes
    {
        public VerificaDependentes(string dependentes)
        {
            verificaDependentes(dependentes);
        }

        public bool verificaDependentes(string dependentes)
        {
            try
            {
                int dependentesInt = Convert.ToInt32(dependentes);
                if (dependentesInt >= 0 && dependentesInt <= 10)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("O número de dependentes deve ser maior ou igual a 0");
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("O número de dependentes deve ser um número inteiro");
                return false;
            }
        }
    }
}
