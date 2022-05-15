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
                        int[] v1 = new int[9];
                        int[] v2 = new int[10];
                        int soma = 0;

                        for (int i = 0; i < 9; i++)
                        {
                            v1[i] = Convert.ToInt32(cpf[i].ToString());
                            soma += v1[i] * (10 - i);
                        }

                        int resto = soma % 11;
                        int j = 0;

                        if (resto < 2)
                        {
                            j = 0;
                        }
                        else
                        {
                            j = 11 - resto;
                        }

                        soma = 0;

                        for (int i = 0; i < 10; i++)
                        {
                            v2[i] = Convert.ToInt32(cpf[i].ToString());
                            soma += v2[i] * (11 - i);
                        }

                        resto = soma % 11;
                        int k = 0;

                        if (resto < 2)
                        {
                            k = 0;
                        }
                        else
                        {
                            k = 11 - resto;
                        }

                        if (j == Convert.ToInt32(cpf[9].ToString()) && k == Convert.ToInt32(cpf[10].ToString()))
                        {
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("CPF inválido!");
                            return false;
                        }
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
