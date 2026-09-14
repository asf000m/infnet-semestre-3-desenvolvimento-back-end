namespace Polimorfismo2.Models;

public class Quadrado : Figura
{
    public double Lado {get; set;}


    public Quadrado() {}

    public Quadrado (double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }
}