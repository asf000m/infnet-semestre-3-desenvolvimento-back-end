using Heranca3.Models;

namespace Heranca3 {
    internal class Program {
        static void Main(string[] args) {
            ContaComum contaComum = new ContaComum(1, "Ju", 1000);
            //Console.WriteLine(contaComum.ToString());
            Console.WriteLine(contaComum);
            ContaEspecial contaEspecial = new ContaEspecial(2, "Daniel", 2000, 200);
            Console.WriteLine(contaEspecial);
            ContaPoupanca contaPoupanca = new ContaPoupanca(3, "Felipe", 3000, 0.2);
            Console.WriteLine(contaPoupanca);
        }
    }
}
