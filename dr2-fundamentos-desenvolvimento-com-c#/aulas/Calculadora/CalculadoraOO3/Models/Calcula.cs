namespace CalculadoraOO3.Models;

public class Calcula {
    public double Op1 {get; set;}
    public double Op2 {get; set;}
    int operacao;


    public Calcula(double op1, double op2)
    {
        Op1 = op1;
        Op2 = op2;
    }

    public double Somar()
    {
        return Op1 + Op2;
    }

    public double Somar(double op1, double op2)
    {
        return op1 + op2;
    }

    public double Subtrair(double op1, double op2)
    {
        return op1 - op2;
    }

    public double Multiplicar(double op1, double op2)
    {
        return op1 * op2;
    }

    public double Dividir(double op1, double op2)
    {
        if (op2 != 0)
        {
            return op1 / op2;
        }
        throw new DivideByZeroException("Erro: Divisão por zero.");
    }

}
