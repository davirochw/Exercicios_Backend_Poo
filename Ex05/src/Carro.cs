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
        private Motor motor;

        public string Placa { get { return placa; } set { placa = value;} }
        public string Modelo { get { return modelo; } set { modelo = value;} }
        public Motor Motor { get { return motor; } set { motor = value; } }

        public Carro(string placa, string modelo, Motor motor)
        {
            this.placa = placa;
            this.modelo = modelo;
            this.motor = motor;
        }

    }
}
