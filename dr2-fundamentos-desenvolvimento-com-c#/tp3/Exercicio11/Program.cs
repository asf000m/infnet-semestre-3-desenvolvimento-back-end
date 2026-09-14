namespace Exercicio11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Circulo
{
    double Raio;


    public double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}


class Esfera
{
    double Raio;


    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
    }
}