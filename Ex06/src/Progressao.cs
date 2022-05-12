using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.src
{
    abstract class Progressao
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }

        public abstract int ProximoValor { get; }

        public Progressao()
        {

        }

        public abstract int TermoAt(int posicao);

        /*public void Reinicializar() { }*/
    }
}
