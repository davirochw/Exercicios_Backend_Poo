using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.src
{
    internal class ProgressaoGeometrica : Progressao
    {
        public int Primeiro { get; set; }
        public int Razao { get; set; }

        private List<int> PG = new List<int>();

        public ProgressaoGeometrica(int primeiro, int razao) : base(primeiro, razao)
        {
            Primeiro = primeiro;
            Razao = razao;
        }
    }
}
