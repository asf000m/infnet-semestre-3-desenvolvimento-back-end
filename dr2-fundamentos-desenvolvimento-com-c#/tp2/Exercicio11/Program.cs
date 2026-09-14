Console.WriteLine("Informe um número:");
int n = int.Parse(Console.ReadLine());

int i = 1;
while (i <= 10)
{
    Console.WriteLine($"{n} x {i}  =  {n * i}");
    i++;
}