using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.src
{
    class Cliente
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public string rendaMensal { get; set; }
        public string estadoCivil { get; set; }
        public string dependentes { get; set; }

        public VerificaDados verificaDados;

        public Cliente(string nome, string cpf, string dataNascimento, string rendaMensal, string estadoCivil, string dependentes)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
            this.rendaMensal = rendaMensal;
            this.estadoCivil = estadoCivil;
            this.dependentes = dependentes;

            verificaDados = new VerificaDados(nome, cpf, dataNascimento, estadoCivil, dependentes);
        }

        public Cliente()
        {
        }

        public void imprimeDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Data de Nascimento: " + dataNascimento);
            Console.WriteLine("Renda Mensal: " + rendaMensal);
            Console.WriteLine("Estado Civil: " + estadoCivil);
            Console.WriteLine("Dependentes: " + dependentes);
        }
    }
}
