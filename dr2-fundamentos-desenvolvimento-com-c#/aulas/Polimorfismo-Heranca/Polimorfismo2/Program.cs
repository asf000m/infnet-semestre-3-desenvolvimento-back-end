using Polimorfismo2.Models;

namespace Polimorfismo2;

class Program
{
    static void Main(string[] args)
    {
        List<Figura> figuras = new();

        figuras.Add(new Quadrado(2));
        figuras.Add(new Retangulo(2, 3));
        figuras.Add(new Triangulo(3, 4));

        foreach (Figura figura in figuras) {
            Console.WriteLine(figura.GetType().Name);
            Console.WriteLine(figura.CalcularArea());
            Console.WriteLine();
        }

        // Quadrado quadrado = new(2);
        // Console.WriteLine($"Área = {quadrado.CalcularArea()}");

        // Retangulo retangulo = new(2, 3);
        // Console.WriteLine($"Área = {retangulo.CalcularArea()}");

        // Triangulo triangulo = new(2, 3);
        // Console.WriteLine($"Área = {triangulo.CalcularArea()}");
    }
}
