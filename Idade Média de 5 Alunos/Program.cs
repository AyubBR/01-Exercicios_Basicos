int idade1;
int idade2;
int idade3;
int idade4;
int idade5;
int media;

Console.WriteLine("Programa para Calcular a Média de Idade de 5 Alunos.");
Console.WriteLine("Qual a idade do primeiro aluno?");
idade1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual a idade do segundo aluno?");
idade2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual a idade do terceiro aluno?");
idade3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual a idade do quarto aluno?");
idade4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Qual a idade do quinto aluno?");
idade5 = Convert.ToInt32(Console.ReadLine());

media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

Console.WriteLine("A média de idade dos 5 alunos é " + media);
Console.ReadKey();

