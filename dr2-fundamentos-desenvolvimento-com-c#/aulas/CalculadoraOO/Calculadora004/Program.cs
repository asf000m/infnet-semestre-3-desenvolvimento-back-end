using CalculadoraOO4.Models;

namespace CalculadoraOO4 {
    internal class Program {
        static void Main(string[] args) {
            Calcula calcula1 = new Calcula();
            Console.WriteLine("Soma = " + calcula1.Somar(3, 2));
            Calcula calcula2 = new Calcula(3, 2);
            Console.WriteLine("Soma = " + calcula2.Somar());
            Console.WriteLine();
            Cientifica cientifica1 = new Cientifica();
            Console.WriteLine("Soma = " + cientifica1.Somar(3, 2));
            Cientifica cientifica2 = new Cientifica(3, 2);
            Console.WriteLine("Soma = " + cientifica2.Somar());
            Console.WriteLine("Potência = " + cientifica1.Potencia(2, 10));
            Console.WriteLine("Raiz = " + cientifica1.RaizQuadrada(4));
            Console.WriteLine();
            Programacao prog1 = new Programacao();
            Console.WriteLine("Soma = " + prog1.Somar(3, 2));
            Programacao prog2 = new Programacao(3, 2);
            Console.WriteLine("Soma = " + prog2.Somar());
            Console.WriteLine("Converter para a base 2 = " + prog1.ConverterParaBinario(10));
            Console.WriteLine("Converter para base 16 = " + prog1.ConverterParaHexa(10));
        }
    }
}
