using Encapsulamento3.Models;

namespace Encapsulamento3;

class Program
{
    static void Main(string[] args)
    {
        Conta conta1 = new();

        try
        {
            conta1.SetId(1);
            conta1.SetNome("Asafe");
            conta1.SetSaldo(100);
            
            Console.WriteLine($"ID: {conta1.GetId()}\tNome: {conta1.GetNome()}\tSaldo: {conta1.GetSaldo()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }



        Conta conta2 = new();

        try
        {
            conta2.SetId(2);
            conta2.SetNome("Sofia");
            conta2.SetSaldo(200);

            Console.WriteLine($"ID: {conta2.GetId()}\tNome: {conta2.GetNome()}\tSaldo: {conta2.GetSaldo()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
