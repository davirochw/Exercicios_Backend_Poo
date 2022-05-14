using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.src
{
    internal class Carro
    {
        private string placa;
        private string modelo;

        public string Placa { get { return placa; } set { placa = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }
        public Motor Motor { get; set; }

        public Carro(string placa, string modelo, Motor motor)
        {
            if (placa == null)
            {
                throw new ArgumentNullException("Precisa de uma placa para o carro");
            }
            if (modelo == null)
            {
                throw new ArgumentNullException("Precisa de um modelo para o carro");
            }
            if (motor == null)
            {
                throw new ArgumentNullException("Precisa de um motor para o carro");
            }

            this.Placa = placa;
            this.Modelo = modelo;
            this.Motor = motor;
        }

        public void VelocidadeMaxima(Carro carro)
        {
            if (carro.Motor.Cilindrada <= 1.0)
            {
                Console.WriteLine("Velocidade máxima: 140km/h");
            }
            else if (carro.Motor.Cilindrada <= 1.6)
            {
                Console.WriteLine("Velocidade máxima: 160km/h");
            }
            else if (carro.Motor.Cilindrada <= 2.0)
            {
                Console.WriteLine("Velocidade máxima: 180km/h");
            }
            else
            {
                Console.WriteLine("Velocidade máxima: 220km/h");
            }
        }
    }
}
