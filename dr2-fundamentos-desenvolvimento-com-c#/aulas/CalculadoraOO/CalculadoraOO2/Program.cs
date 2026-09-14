using CalculadoraOO2.Models;

namespace CalculadoraOO2 {
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
            Calcula calcula = new Calcula();
            double result;

            switch (opcao) {
                case 1:
                    result = calcula.Somar(op1, op2);
                    Console.WriteLine("Soma = " + result);
                    break;
                case 2:
                    result = calcula.Subtrair(op1, op2);
                    Console.WriteLine("Subtração = " + result);
                break;
                case 3:
                    result = calcula.Multiplicar(op1, op2);
                    Console.WriteLine("Multiplicação = " + result);
                    break;
                case 4:
                    try {
                        result = calcula.Dividir(op1, op2);
                        Console.WriteLine("Divisão = " + result);
                    }
                    catch (DivideByZeroException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Erro: opção inválida");
                    break;
            }
        }
    }
}