namespace CalculadoraOO4.Models {
    public class Cientifica : Calcula {

        public Cientifica() { }

        public Cientifica(double op1, double op2) :
            base(op1, op2) {
        }

        public double Potencia(double numBase, double expoente) {
            return Math.Pow(numBase, expoente);
        }

        public double RaizQuadrada(double num) {
            return Math.Sqrt(num);
        }
    }
}
