using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    internal class VerificaEstadoCivil
    {
        public VerificaEstadoCivil(string estadoCivil)
        {
            verificaEstadoCivil(estadoCivil);
        }

        public bool verificaEstadoCivil(string estadoCivil)
        {
            Char estadoC = Convert.ToChar(estadoCivil);
            if (estadoCivil == "S" || estadoCivil == "C" || estadoCivil == "D" || estadoCivil == "V"
            || estadoCivil == "s" || estadoCivil == "c" || estadoCivil == "d" || estadoCivil == "v")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Estado civil inválido");
                return false;
            }
        }
    }
}
