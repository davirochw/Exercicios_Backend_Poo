using Ex01.src;

Console.Write("Quantos clientes deseja adicionar? ");
int n = int.Parse(Console.ReadLine());

Cliente cliente = new Cliente();

while (n > 0)
{
    Console.Write("Digite o nome do cliente: ");
    string nome = Console.ReadLine();

    Console.Write("Digite o CPF do cliente: ");
    string cpf = (Console.ReadLine());

    Console.Write("Digite a data de nascimento do cliente: [DD/MM/YYYY]");
    string dataNascimento = (Console.ReadLine());

    Console.Write("Digite a renda mensal do cliente: ");
    string rendaMensal = (Console.ReadLine());

    Console.Write("Digite o estado civil do cliente: [S, C, V, D] ");
    string estadoCivil = (Console.ReadLine());

    Console.Write("Digite o número de dependentes do cliente: ");
    string dependentes = (Console.ReadLine());

    n--;

    Cliente cliente1 = new Cliente(nome, cpf, dataNascimento, rendaMensal, estadoCivil, dependentes);
    Console.WriteLine();
    cliente1.imprimeDados();
}
