namespace CalculadoraOO4.Models {
    public class Programacao : Calcula {

        public Programacao() { }

        public Programacao(double op1, double op2) :
            base(op1, op2) { 
        }

        public string ConverterParaBinario(int num) {
            return Convert.ToString(num, 2);
        }

        public string ConverterParaHexa(int num) {
            return Convert.ToString(num, 16).ToUpper();
        }
    }
}
