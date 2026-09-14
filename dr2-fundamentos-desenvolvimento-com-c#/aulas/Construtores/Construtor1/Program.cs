using Construtor1.Models;

namespace Construtor1;

class Program
{
    static void Main(string[] args)
    {
        Conta conta = new();

        Console.WriteLine($"ID: {conta.Id}\tNome: {conta.Nome}\tSaldo: {conta.Saldo}");

    }
}
