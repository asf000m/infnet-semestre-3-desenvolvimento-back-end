using Construtor3.Models;

namespace Construtor3;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Conta conta = new(1, "Asafe", 100);
            Console.WriteLine($"ID: {conta.Id}\tNome: {conta.Nome}\tSaldo: {conta.Saldo}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
