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
            Primeiro = primeiro;
            Razao = razao;
        }

    }
}
