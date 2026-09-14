namespace Polimorfismo2.Models;

public class Retangulo : Figura
{
    public double Base {get; set;}
    public double Altura {get; set;}


    public Retangulo() {}

    public Retangulo(double _base, double altura)
    {
        Base = _base;
        Altura = altura;
    }

    public override double CalcularArea()
    {
        return Base * Altura;
    }
}