using Construtor2.Models;

namespace Construtor2;

class Program
{
    static void Main(string[] args)
    {
        Conta conta = new(1, "Asafe", 100);

        Console.WriteLine($"ID: {conta.Id}\tNome: {conta.Nome}\tSaldo: {conta.Saldo}");
    }
}
