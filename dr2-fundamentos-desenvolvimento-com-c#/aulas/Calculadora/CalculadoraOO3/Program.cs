using CalculadoraOO3.Models;

namespace CalculadoraOO3;

class Program
{
    static void Main(string[] args)
    {
        double op1, op2, resultado;

        ExibirMenu();
        int opcao = EntrarOpcao();

        op1 = EntrarOperando("Entre o operando 1: ");
        op2 = EntrarOperando("Entre o operando 2: ");
        
        Calcular(op1, op2, opcao);
    }

    public static void Calcular(double op1, double op2, int opcao)
    {
        Calcula calcula = new();

        double resultado;

        switch (opcao)
        {
            case 1:
                resultado = calcula.Somar(op1, op2);
                Console.WriteLine($"\nSoma: {resultado}");
                break;
            case 2:
                resultado = calcula.Subtrair(op1, op2);
                Console.WriteLine($"\nSubtração: {resultado}");
                break;
            case 3:
                resultado = calcula.Multiplicar(op1, op2);
                Console.WriteLine($"\nMultiplicação: {resultado}");
                break;
            case 4:
                try
                {
                    resultado = calcula.Dividir(op1, op2);
                    Console.WriteLine($"\nDivisão: {resultado}");
                }
                catch (DivideByZeroException ex)
                {  
                    Console.WriteLine(ex.Message);
                }
                break;
            default:
                Console.WriteLine("\nErro: Opção inválida");
                break;
        }
    }

    public static void ExibirMenu()
    {
        Console.WriteLine("---- Calculadora ----");
        Console.WriteLine("1\tSomar\n2\tSubtrair");
        Console.WriteLine("3\tMultiplicar\n4\tDividir");
    }

    public static int EntrarOpcao()
    {
        int opcao = 0;

        try
        {
            Console.Write("\nEntre com a opção: ");
            opcao = int.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"\tErro: Opção inválida.\n\t{ex.Message}");
        }
        
        Console.WriteLine();
        
        return opcao;
    }

    public static double EntrarOperando(String msg)
    {
        double operando = 0;
        
        try
        {
            Console.Write(msg);
            operando = double.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"\tErro: Operando inválido.\n\t{ex.Message}");
        }
        
        return operando;
    }
}