namespace CalculadoraOO1.Models;

public class Calcula {
    double op1, op2;
    int operacao;


    public void Somar(double op1, double op2)
    {
        double resultado = op1 + op2;
        Console.WriteLine($"\nSoma: {resultado}");
    }

    public void Subtrair(double op1, double op2)
    {
        double resultado = op1 - op2;
        Console.WriteLine($"\nSubtração: {resultado}");
    }

    public void Multiplicar(double op1, double op2)
    {
        double resultado = op1 * op2;
        Console.WriteLine($"\nMultiplicação: {resultado}");
    }

    public void Dividir(double op1, double op2)
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
