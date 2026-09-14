namespace CalculadoraOO2.Models {
    public  class Calcula {
        public double Op1 { get; set; }
        public double Op2 { get; set; }
        
        public double Somar(double op1, double op2) {
            double result = op1 + op2;
            return result;
        }

        public double Subtrair(double op1, double op2) {
            return op1 - op2;
        }

        public double Multiplicar(double op1, double op2) {
            return op1 * op2;
        }

        public double Dividir(double op1, double op2) {
            if (op2 != 0) {
                return op1 / op2;
            }
            throw new DivideByZeroException("Erro: divisão por zero");
        }
    }
}
