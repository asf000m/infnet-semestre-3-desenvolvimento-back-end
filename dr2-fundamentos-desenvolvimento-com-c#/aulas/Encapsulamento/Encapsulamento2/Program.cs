using Encapsulamento2.Models;

namespace Encapsulamento2;

class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new();

        conta1.SetId(0);
        conta1.SetNome("Asafe");
        conta1.SetSaldo(100);

        Console.WriteLine($"ID: {conta1.GetId()}\tNome: {conta1.GetNome()}\tSaldo: {conta1.GetSaldo()}");


        Conta conta2 = new();

        conta2.SetId(1);
        conta2.SetNome("Sofia");
        conta2.SetSaldo(200);

        Console.WriteLine($"ID: {conta2.GetId()}\tNome: {conta2.GetNome()}\tSaldo: {conta2.GetSaldo()}");
    }
}
