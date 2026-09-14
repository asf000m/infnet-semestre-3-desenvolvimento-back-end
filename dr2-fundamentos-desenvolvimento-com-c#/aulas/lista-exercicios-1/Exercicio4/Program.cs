// Média de Três Notas
// Leia três notas e calcule a média aritmética.

Console.WriteLine("Informe três notas:");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

double media = (n1 + n2 + n3) / 3;

Console.WriteLine($"Média: {media}");
