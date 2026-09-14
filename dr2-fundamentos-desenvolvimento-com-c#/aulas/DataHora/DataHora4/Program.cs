namespace DataHora4;

class Program
{
    static void Main(string[] args)
    {
        String texto;
        DateTime data;

        Console.Write("Entre com uma data: ");
        texto = Console.ReadLine();
        data = DateTime.Parse(texto);
        Console.WriteLine($"Data: {data}");
    }
}
