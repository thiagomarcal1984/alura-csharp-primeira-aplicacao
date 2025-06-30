Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 11);

int chute = -1;
do
{
    Console.Write("Adivinhe o número: ");
    try
    {
        chute = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Escreva um número!");
    }
    if (chute < numeroSecreto)
        Console.WriteLine("O número é maior");
    else if (chute > numeroSecreto)
        Console.WriteLine("O número é menor");
    else
        Console.WriteLine("Você adivinhou!");
} while (chute != numeroSecreto);
