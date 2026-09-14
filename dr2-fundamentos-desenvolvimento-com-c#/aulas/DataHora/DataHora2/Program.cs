namespace DataHora2;

class Program
{
    static void Main(string[] args)
    {
        DateTime dataHora = new(1999, 8, 21, 12, 12, 30, 45);
        Console.WriteLine(dataHora);

        Console.WriteLine();

        DateTime novaData = dataHora.AddYears(1).AddMonths(1).AddDays(5);
        Console.WriteLine(novaData);

        Console.WriteLine();

        DateTime novaHora = dataHora.AddHours(2).AddMinutes(4).AddSeconds(54);
        Console.WriteLine(novaHora);
    }
}
