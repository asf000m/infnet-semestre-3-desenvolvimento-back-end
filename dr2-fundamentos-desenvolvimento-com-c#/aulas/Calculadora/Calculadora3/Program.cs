using System.Net;

namespace Calculadora3;

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
        switch (opcao)
        {
            case 1:
                Somar(op1, op2);
                break;
            case 2:
                Subtrair(op1, op2);
                break;
            case 3:
                Multiplicar(op1, op2);
                break;
            case 4:
                Dividir(op1, op2);
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
        int opcao;
        
        Console.Write("\nEntre com a opção: ");
        opcao = int.Parse(Console.ReadLine());
        
        Console.WriteLine();
        
        return opcao;
    }

    public static double EntrarOperando(String msg)
    {
        double operando;
        
        Console.Write(msg);
        operando = double.Parse(Console.ReadLine());
        
        return operando;
    }

    public static void Somar(double op1, double op2)
    {
        double resultado = op1 + op2;
        Console.WriteLine($"\nSoma: {resultado}");
    }

    public static void Subtrair(double op1, double op2)
    {
        double resultado = op1 - op2;
        Console.WriteLine($"\nSubtração: {resultado}");
    }

    public static void Multiplicar(double op1, double op2)
    {
        double resultado = op1 * op2;
        Console.WriteLine($"\nMultiplicação: {resultado}");
    }

    public static void Dividir(double op1, double op2)
    {
        if (op2 != 0)
        {
            double resultado = op1 / op2;
            Console.WriteLine($"\nDivisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero");
        }
    }
}
