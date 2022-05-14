using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class VerificaCpf
    {
        public VerificaCpf(string cpf)
        {
            verificaCPF(cpf);
        }

        public bool verificaCPF(string cpf)
        {
            if (cpf.Length == 11)
            {
                try
                {
                    long cpfLong = Convert.ToInt64(cpf);
                    if (cpfLong.Equals(00000000000) || cpfLong.Equals(11111111111) || cpfLong.Equals(22222222222)
                    || cpfLong.Equals(33333333333) || cpfLong.Equals(44444444444) || cpfLong.Equals(55555555555)
                    || cpfLong.Equals(66666666666) || cpfLong.Equals(77777777777) || cpfLong.Equals(88888888888)
                    || cpfLong.Equals(99999999999))
                    {
                        Console.WriteLine("CPF inválido!");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("CPF inválido");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("CPF inválido");
                return false;
            }
        }
    }
}
