Console.WriteLine("Informe um número:");
int n = int.Parse(Console.ReadLine());

for (int i = n; i > 0; i--)
{
    Console.Write($"{i}, ");
}
Console.Write("0\n");