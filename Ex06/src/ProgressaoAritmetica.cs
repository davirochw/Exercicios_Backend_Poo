using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.src
{
    internal class ProgressaoAritmetica : Progressao
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }

        private List<int> PA = new List<int>();

        public ProgressaoAritmetica(int primeiro, int razao) : base(primeiro, razao)
        {
        }

        public override int ProximoValor { get { return PA[PA.Count - 1] + Razao; } }

        public override int TermoAt(int posicao)
        {
            int r = Razao;
            int n = posicao - 1;

            if (PA.Count == 0)
            {
                PA.Add(Primeiro);
                return Primeiro;
            }
            else
            {
                PA.Add(PA[PA.Count - 1] + Razao);
                return PA.Count - 1 + Razao;
            }
        }

        public override void Reinicializar()
        {
            if (PA.Count != 0)
            {
                PA.Clear();
            }
        }
    }
}
