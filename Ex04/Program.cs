using Ex04.src;

Pessoa pessoa;
CertidaoNascimento certidaoNascimento;

Console.WriteLine("Digite o nome da pessoa:");
string nome = Console.ReadLine();

Console.WriteLine("Essa pessoa tem a certidão de nascimento? [S/N]");
char c = char.Parse(Console.ReadLine());

if (c == 'S' || c == 's')
{
    Console.WriteLine("Digite a data de emissão da certidão de nascimento [DD/MM/YYYY]:");
    DateTime dataEmissao = DateTime.Parse(Console.ReadLine());

    pessoa = new Pessoa(nome);
    certidaoNascimento = new CertidaoNascimento(pessoa, dataEmissao);
    pessoa = new Pessoa(nome, certidaoNascimento);
} else
{
    pessoa = new Pessoa(nome);
}
