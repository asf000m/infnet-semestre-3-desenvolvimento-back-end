Random rand = new();
int randInt = rand.Next(1, 101);

Console.WriteLine("Adivinhe um número de 1 a 100:");
int n = int.Parse(Console.ReadLine());

while (n != randInt)
{
    if (n > randInt)
    {
        Console.WriteLine("O seu palpite é maior. Informe um número menor:");
    }
    else if (n < randInt)
    {
        Console.WriteLine("O seu palpite é menor. Informe um número maior:");
    }

    n = int.Parse(Console.ReadLine());
}

Console.WriteLine("Você acertou!");