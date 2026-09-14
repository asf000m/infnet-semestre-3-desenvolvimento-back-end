namespace Exercicio12;

class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new();
        circulo.Raio = 3.0;
        double area = circulo.CalcularArea();
        Console.WriteLine($"Área do círculo de raio {circulo.Raio}: {area:F2}");

        Esfera esfera = new();
        esfera.Raio = 5.0;
        double volume = esfera.CalcularVolume();
        Console.WriteLine($"Volume da esfera de raio {esfera.Raio}: {volume:F2}");
    }
}


class Circulo
{
    public double Raio;


    public double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}


class Esfera
{
    public double Raio;


    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
    }
}