namespace CalculadoraOO3.Models {
    public  class Calcula {
        public double Op1 { get; set; }
        public double Op2 { get; set; }

        // Sobrecarga de construtor, polimorfismo estático
        public Calcula() { }

        public Calcula(double op1, double op2) {
            Op1 = op1;
            Op2 = op2;
        }

        // Sobrecarga de métodos, polimorfismo estático
        public double Somar() {
            return Op1 + Op2;
        }

        public double Somar(double op1, double op2) {
            double result = op1 + op2;
            return result;
        }

        public double Subtrair() {
            return Op1 - Op2;
        }

        public double Subtrair(double op1, double op2) {
            return op1 - op2;
        }

        public double Multiplicar() {
            return Op1 * Op2;
        }

        public double Multiplicar(double op1, double op2) {
            return op1 * op2;
        }

        public double Dividir() {
            if (Op2 != 0) {
                return Op1 / Op2;
            }
            throw new DivideByZeroException("Erro: divisão por zero");
        }

        public double Dividir(double op1, double op2) {
            if (op2 != 0) {
                return op1 / op2;
            }
            throw new DivideByZeroException("Erro: divisão por zero");
        }
    }
}
