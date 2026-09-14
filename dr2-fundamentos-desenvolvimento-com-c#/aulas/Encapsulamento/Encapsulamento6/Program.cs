using Encapsulamento6.Models;

namespace Encapsulamento6;

class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new();

        try
        {
            conta1.Id = 1;
            conta1.Nome = "Asafe";
            conta1.Saldo = 100;
            
            Console.WriteLine($"ID: {conta1.Id}\tNome: {conta1.Nome}\tSaldo: {conta1.Saldo}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


        Conta conta2 = new();

        try
        {
            conta2.Id = 2;
            conta2.Nome = "Sofia";
            conta2.Saldo = 200;

            Console.WriteLine($"ID: {conta2.Id}\tNome: {conta2.Nome}\tSaldo: {conta2.Saldo}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
