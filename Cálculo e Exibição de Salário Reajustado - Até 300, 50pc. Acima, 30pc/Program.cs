double salario;
double salarionovo;
int i = 0;

Console.WriteLine("Programa Para Calcular Salário Reajustado");

while (i < 10)
{
    Console.WriteLine("Inserir salário do colaborador:");
    salario = Convert.ToDouble(Console.ReadLine());
    if (salario <= 300)
    {
        salarionovo = salario * 1.5;
            }
    else
    {
        salarionovo = salario * 1.3;
    }
    Console.WriteLine("O salário reajustado do colaborador é " + salarionovo);
}
Console.ReadKey();
