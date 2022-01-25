string matricula;
string matricula_alto;
string matricula_baixo;

double altura;
double altura_alto;
double altura_baixo;

int i = 0;

Console.WriteLine("Programa Para Mostrar Matrícula dos Alunos Mais Baixo e Mais Alto");

Console.WriteLine("Insira a matrícula do aluno:");
matricula = Console.ReadLine();
Console.WriteLine("Insira a altura do aluno de matrícula " + matricula);
altura = Convert.ToDouble(Console.ReadLine());

altura_alto = altura;
altura_baixo = altura;
matricula_alto = matricula;
matricula_baixo = matricula;

while (i < 9)
{
    Console.WriteLine("Insira a matrícula do aluno:");
    matricula = Console.ReadLine();
    Console.WriteLine("Insira a altura do aluno de matrícula " + matricula);
    altura = Convert.ToDouble(Console.ReadLine());

    if (altura > altura_alto)
    {
        altura_alto = altura;
        matricula_alto = matricula;
    }
    if (altura < altura_baixo)
    {
        altura_baixo = altura;
        matricula_baixo = matricula;
    }
    i++;
}
Console.WriteLine("O aluno de menor estatura possui " + altura_baixo + " metros e matrícula " + matricula_baixo);
Console.WriteLine("Já o aluno de maior estatura possui " + altura_alto + " metros e matrícula " + matricula_alto);
Console.ReadKey();
