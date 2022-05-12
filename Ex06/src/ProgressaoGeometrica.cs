using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.src
{
    internal class ProgressaoGeometrica : Progressao
    {
        private List<int> Pa { get; set; } = new List<int>();
        public override int ProximoValor => throw new NotImplementedException();

        public override int TermoAt(int posicao)
        {
            throw new NotImplementedException();
        }
    }
}
