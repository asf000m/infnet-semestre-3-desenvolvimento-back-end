namespace Exercicio03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Operando 1: ");
        double op1 = double.Parse(Console.ReadLine());
        Console.Write("Operando 2: ");
        double op2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nEscolha uma operação matemática:");
        Console.WriteLine(
            "1 - Soma\n" +
            "2 - Subtração\n" +
            "3 - Multiplicação\n" +
            "4 - Divisão"
        );
        
        int opcao = int.Parse(Console.ReadLine());

        double resultado = 0;
        switch (opcao)
        {
            case 1:
                resultado = op1 + op2;
                break;
            case 2:
                resultado = op1 - op2;
                break;
            case 3:
                resultado = op1 * op2;
                break;
            case 4:
                if (op2 != 0)
                    resultado = op1 / op2;
                else
                    Console.WriteLine("Erro: Divisão por zero.");
                break;
            default:
                Console.WriteLine("Erro: Opção inválida.");
                break;
        }

        Console.WriteLine($"\nResultado: {resultado}");
    }
}
