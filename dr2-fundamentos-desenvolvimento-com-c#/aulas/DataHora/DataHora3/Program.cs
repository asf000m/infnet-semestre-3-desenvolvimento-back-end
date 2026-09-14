namespace DataHora3;

class Program
{
    static void Main(string[] args)
    {
        DateTime inicio = new(2026, 8, 29);
        Console.WriteLine($"Início: {inicio.ToString("dd/MM/yyyy")}");

        DateTime fim = new(2027, 9, 5);
        Console.WriteLine($"Fim: {fim:dd/MM/yyy}");

        Console.WriteLine();

        TimeSpan intervalo = fim.Subtract(inicio);
        Console.WriteLine(intervalo.Days);

        intervalo = fim - inicio;
        Console.WriteLine(intervalo.Days);

        Console.WriteLine();

        Console.WriteLine($"Início > Fim: {inicio > fim}");
        Console.WriteLine($"Início = Fim: {inicio == fim}");
        Console.WriteLine($"Início < Fim: {inicio < fim}");
    }
}
