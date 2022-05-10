using Ex02.src;

Turma turma = new Turma();

while (true)
{
    Console.WriteLine("- Digite os dados do aluno que deseja cadastrar -\n");

    Console.WriteLine("MATRICULA:");
    int matricula = int.Parse(Console.ReadLine());

    Console.WriteLine("NOME:");
    string nome = Console.ReadLine();

    Console.WriteLine("Deseja adicionar as notas P1 e P2? [S/N]");
    char c = char.Parse(Console.ReadLine());

    if (c == 'S' || c == 's')
    {
        Console.WriteLine("Digite a nota P1");
        int notaP1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota P2");
        int notaP2 = int.Parse(Console.ReadLine());

        Turma turma1 = new Turma(matricula, nome, notaP1, notaP2);
        turma.AdicionaAluno(turma1);
    }
    else
    {
        Turma turma1 = new Turma(matricula, nome);
        turma.AdicionaAluno(turma1);
    }

    Console.WriteLine("Deseja adicionar mais um estudante? [S/N]");
    c = char.Parse(Console.ReadLine());

    if (c == 'S' || c == 's')
    {
        continue;
    } else
    {
        break;
    }
}

turma.MediaP1();
turma.MediaP2();
turma.NotasFinais();
turma.ImprimeAluno();
turma.MaiorNotaFinal();
