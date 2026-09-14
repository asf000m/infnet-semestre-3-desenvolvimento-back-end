namespace Calculadora2;

class Program
{
    static void Main(string[] args)
    {
        int opcao;
        double op1, op2, resultado;

        Console.WriteLine("---- Calculadora ----");
        Console.WriteLine("1\tSomar\n2\tSubtrair");
        Console.WriteLine("3\tMultiplicar\n4\tDividir");
        
        Console.Write("\nEntre com a opção: ");
        opcao = int.Parse(Console.ReadLine());

        Console.Write("\nEntre com o operando 1: ");
        op1 = double.Parse(Console.ReadLine());
        Console.Write("Entre com o operando 2: ");
        op2 = double.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                resultado = op1 + op2;
                Console.WriteLine($"\nSoma: {resultado}");
                break;
            case 2:
                resultado = op1 - op2;
                Console.WriteLine($"\nSubtração: {resultado}");
                break;
            case 3:
                resultado = op1 * op2;
                Console.WriteLine($"\nMultiplicação: {resultado}");
                break;
            case 4:
                resultado = op1 / op2;
                Console.WriteLine($"\nDivisão: {resultado}");
                break;
            default:
                Console.WriteLine("\nErro: Opção inválida");
                break;
        }
    }
}
