int idade;
int quantidade = 0;
int i = 0;

Console.WriteLine("Programa Para Verificar Quantas Pessoas São Maiores de Idade.");

while (i < 10)
{
    Console.WriteLine("Por favor, insira a idade:");
    idade = Convert.ToInt32(Console.ReadLine());

    if (idade >= 18)
    {
        quantidade = quantidade + 1;
    }
    i++;
}
Console.WriteLine(quantidade + " pessoas são maiores de idade.");
Console.ReadKey();