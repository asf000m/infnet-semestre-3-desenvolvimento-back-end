using System.Runtime.CompilerServices;

namespace DataHora1;

class Program
{
    static void Main(string[] args)
    {
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Data agora: {agora}");
        Console.WriteLine();

        DateTime hoje = DateTime.Today;
        Console.WriteLine($"Data e hora hoje: {hoje}");
        Console.WriteLine($"Data hoje: {hoje.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Hora hoje: {agora.ToString("HH:mm:ss")}");
        Console.WriteLine();

        Console.WriteLine($"Dia: {agora.Day}");
        Console.WriteLine($"Mês: {agora.Month}");
        Console.WriteLine($"Ano: {agora.Year}");
        Console.WriteLine($"Horas: {agora.Hour}");
        Console.WriteLine($"Minutos: {agora.Minute}");
        Console.WriteLine($"Segundos: {agora.Second}");
        Console.WriteLine();

        Console.WriteLine($"Dia da semana: {agora.DayOfWeek}");
        Console.WriteLine($"Dia do ano: {agora.DayOfYear}");
    }
}
