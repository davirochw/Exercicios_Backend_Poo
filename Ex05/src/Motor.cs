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
        
        public double Cilindrada { get { return cilindrada; } set { } }

        public Carro Carro { get; set; }

        public Motor(double cilindrada, Carro carro)
        {
            if(carro.Motor != null)
            {
                throw new Exception("Não pode ter mais de um motor");
            }

            this.cilindrada = cilindrada;
        }

        public Motor(double cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public void VelocidadeMaxima(Carro carro)
        {
            if(carro.Motor.Cilindrada <= 1.0)
            {
                Console.WriteLine("\nVelocidade máxima do carro é 140 km/h");
            }
            else if (carro.Motor.Cilindrada <= 1.6)
            {
                Console.WriteLine("\nVelocidade máxima do carro é 180 km/h");
            }
            else if (carro.Motor.Cilindrada <= 2.0)
            {
                Console.WriteLine("\nVelocidade máxima do carro é 220 km/h");
            }
        }
    }
}
