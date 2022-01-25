int numero;

Console.WriteLine("Programa para Verificar se o Número Inserido é Par ou Ímpar");
Console.WriteLine("Por favor insira um número.");
numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número inserido é par.");
}
else
{
    Console.WriteLine("O número inserido é ímpar.");
}
Console.ReadKey();