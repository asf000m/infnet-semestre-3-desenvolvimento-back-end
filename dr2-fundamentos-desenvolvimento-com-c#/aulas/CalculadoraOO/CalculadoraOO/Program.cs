using CalculadoraOO1.Models;

namespace CalculadoraOO { 
    internal class Program { 
        static void Main(string[] args) {
            const int SAIR = 5;
            double op1, op2, result;
            int opcao;

            opcao = EntrarOpcao();
            while (opcao != SAIR) {
                op1 = EntrarOperando("Entre com o op1: ");
                op2 = EntrarOperando("Entre com o op2: ");
                Calcular(opcao, op1, op2);
                opcao = EntrarOpcao();
            }
        }

        public static void ExibirMenu() {
            Console.WriteLine("---- Calculadora ----");
            Console.WriteLine("[1] - Somar");
            Console.WriteLine("[2] - Subtrair");
            Console.WriteLine("[3] - Multiplicar");
            Console.WriteLine("[4] - Dividir");
            Console.WriteLine("[5] - Sair");
        }

        public static int EntrarInteiro(string msg) {
            int num = 0;

            do {
                try {
                    Console.Write("Selecione uma opção: ");
                    num = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex) {
                    Console.WriteLine("Erro: valor inválido " + ex.Message);
                }
            } while (true);
            return num;
        }

        public static int EntrarOpcao() {
            int opcao;

            do {
                ExibirMenu();
                opcao = EntrarInteiro("Entre com a opção: ");
                if ((opcao < 1) || (opcao > 5)) {
                    Console.WriteLine("Erro: opção inválida");
                }
                else {
                    break;
                }
            } while ((opcao < 1) || (opcao > 5));
            return opcao;
        }

        public static double EntrarOperando(string msg) {
            double operando;

            do {
                try {
                    Console.Write(msg);
                    operando = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException ex) {
                    Console.WriteLine("Erro: valor inválido " + ex.Message);
                }
            } while (true);
            return operando;
        }

        public static void Calcular(int opcao, double op1, double op2) {
            Calcula calcula = new Calcula ();

            switch (opcao) {
                case 1:
                    calcula.Somar(op1, op2);
                    break;
                case 2:
                    calcula.Subtrair(op1, op2);
                    break;
                case 3:
                    calcula.Multiplicar(op1, op2);
                    break;
                case 4:
                    calcula.Dividir(op1, op2);
                    break;
                default:
                    Console.WriteLine("Erro: opção inválida");
                    break;
            }
        }
    }
}