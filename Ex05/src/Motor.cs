using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.src
{
    internal class Motor
    {
        private double cilindrada;

        public double Cilindrada { get { return cilindrada; } set { cilindrada = value; } }

        public Carro Carro { get; set; }

        public Motor(double cilindrada)
        {
            if (cilindrada <= 0)
            {
                throw new ArgumentException("Cilindrada deve ser maior que zero");
            }
            this.Cilindrada = cilindrada;
        }

        public Motor(double cilindrada, Carro carro)
        {
            if (cilindrada <= 0)
            {
                throw new ArgumentException("Cilindrada deve ser maior que zero");
            }
            this.Cilindrada = cilindrada;
            this.Carro = carro;
        }
    }
}
