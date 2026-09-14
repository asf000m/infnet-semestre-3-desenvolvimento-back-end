using Encapsulamento1.Models;

namespace Encapsulamento1;

class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new();

        conta1.id = 0;
        conta1.nome = "Asafe";
        conta1.saldo = 100;

        Console.WriteLine($"ID: {conta1.id}\tNome: {conta1.nome}\tSaldo: {conta1.saldo}");

        Conta conta2 = new();

        conta2.id = 1;
        conta2.nome = "Sofia";
        conta2.saldo = 200;

        Console.WriteLine($"ID: {conta2.id}\tNome: {conta2.nome}\tSaldo: {conta2.saldo}");
    }
}
