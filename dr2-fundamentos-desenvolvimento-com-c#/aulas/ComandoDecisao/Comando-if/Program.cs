namespace Comando_if;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre com um número: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Número maior que zero");
        }
    }
}
