namespace CalculadoraOO1.Models {
    public  class Calcula {
        double op1, op2;
        int operacao;

        public void Somar(double op1, double op2) {
            double result = op1 + op2;
            Console.WriteLine("Soma = " + result);
        }

        public void Subtrair(double op1, double op2) {
            double result = op1 - op2;
            Console.WriteLine("Subtração = " + result);
        }

        public void Multiplicar(double op1, double op2) {
            double result = op1 * op2;
            Console.WriteLine("Multiplicação = " + result);
        }

        public void Dividir(double op1, double op2) {
            if (op2 != 0) {
                double result = op1 / op2;
                Console.WriteLine("Divisão = " + result);
            }
            else {
                Console.WriteLine("Erro: divisão por zero");
            }
        }
    }
}
