namespace Polimorfismo2.Models;

public class Triangulo : Figura
{
    public double Base {get; set;}
    public double Altura {get; set;}


    public Triangulo() {}

    public Triangulo(double _base, double altura)
    {
        Base = _base;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura / 2;
    }
}