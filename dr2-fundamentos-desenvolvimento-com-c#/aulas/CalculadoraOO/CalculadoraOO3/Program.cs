using CalculadoraOO3.Models;

namespace CalculadoraOO3 {
    internal class Program {
        static void Main(string[] args) {
            Calcula calcula1 = new Calcula();
            Console.WriteLine("Soma = " + calcula1.Somar(3,2));
            Console.WriteLine("Subtração = " + calcula1.Subtrair(3, 2));
            Console.WriteLine("Multiplicação = " + calcula1.Multiplicar(3, 2));
            Console.WriteLine("Divisão = " + calcula1.Dividir(3, 2));
            Console.WriteLine();
            Calcula calcula2 = new Calcula(3, 2);
            Console.WriteLine("Soma = " + calcula2.Somar());
            Console.WriteLine("Subtração = " + calcula2.Subtrair());
            Console.WriteLine("Multiplicação = " + calcula2.Multiplicar());
            Console.WriteLine("Divisão = " + calcula2.Dividir(3, 2));
        }
    }
}
