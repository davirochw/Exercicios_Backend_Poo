using Ex03.src;

Console.WriteLine("Quantos alunos deseja adicionar?");
int qtdAluno = int.Parse(Console.ReadLine());

Aluno aluno;
Curso curso = new Curso("Desenvolvimento Backend com C#");
Controller controller = new Controller();
Turma turma = new Turma("A");

controller.CriaTurma(turma);

while (qtdAluno > 0)
{
    Console.WriteLine("Digite o nome do aluno: ");
    string nome = Console.ReadLine();
    aluno = new Aluno(nome);

    controller.MatriculaAluno(aluno);
    controller.InserirAlunoTurma(aluno, turma);

    qtdAluno--;
    if (qtdAluno == 0)
    {
        controller.ListaAlunoPorTurma(turma);
    }
}


